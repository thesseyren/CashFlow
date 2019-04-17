﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using Gtk;
using OxyPlot;
using OxyPlot.GtkSharp;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace CashFlow
{
    public partial class MainWindow : Gtk.Window
    {
        private const string DateStringFormat = "dd-MM-yyyy";
        private const string ReadyStatusText = "Hazır.";

        private PlotView MainPlotView;
        private PlotModel MainPlotModel;
        private PlotController MainPlotController = new PlotController();

        private CurrencyFetcher Fetcher = new CurrencyFetcher();

        private void ChangeStatus(string message)
        {
            const uint MsgID = 0;
            MainStatusBar.Pop(MsgID);
            MainStatusBar.Push(MsgID, message);
        }

        public MainWindow() : base(Gtk.WindowType.Toplevel)
        {
            Build();

            DateStartEntry.Text = Fetcher.StartAt.ToString(DateStringFormat);
            DateEndEntry.Text = Fetcher.EndAt.ToString(DateStringFormat);

            foreach (string currency in Enum.GetNames(typeof(Currencies)))
                CurrencyBaseSelection.AppendText(currency);
            CurrencyBaseSelection.Active = (int)Fetcher.Base;

            MainPlotController.BindMouseDown(OxyMouseButton.Left, PlotCommands.PanAt);
            MainPlotController.BindMouseDown(OxyMouseButton.Right, PlotCommands.PointsOnlyTrack);

            MainPlotModel = new PlotModel();
            MainPlotModel.Axes.Add(new DateTimeAxis
            {
                Position = AxisPosition.Bottom,
                IntervalType = DateTimeIntervalType.Days,
                StringFormat = "dd-MM\nyyyy",
                MajorGridlineStyle = LineStyle.Solid,
                Minimum = DateTimeAxis.ToDouble(new DateTime(2018, 1, 1)),
                Maximum = DateTimeAxis.ToDouble(new DateTime(2018, 9, 1))
            });
            MainPlotModel.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Left,
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot,
                TickStyle = TickStyle.Outside
            });

            MainPlotView = new PlotView { Model = MainPlotModel, Controller = MainPlotController };
            MainPlotAlignment.Add(MainPlotView);
            MainPlotView.Show();

            ChangeStatus(ReadyStatusText);
        }

        protected void OnDeleteEvent(object sender, DeleteEventArgs a)
        {
            Application.Quit();
            a.RetVal = true;
        }

        protected void OnDateStartEntryFocusGrabbed(object sender, EventArgs e)
        {
            DateTimeDialog dialog;
            if (Fetcher.StartAt == new DateTime())
                dialog = new DateTimeDialog();
            else
                dialog = new DateTimeDialog(Fetcher.StartAt);

            dialog.Response += delegate (object obj, ResponseArgs resp) {
                if (resp.ResponseId == ResponseType.Ok)
                {
                    Fetcher.StartAt = dialog.Calendar.Date;
                    DateStartEntry.Text = Fetcher.StartAt.ToString(DateStringFormat);
                }
                else if (resp.ResponseId != ResponseType.Ok && Fetcher.StartAt == new DateTime())
                {
                    MessageDialog message = new MessageDialog(dialog, DialogFlags.DestroyWithParent,
                        MessageType.Warning, ButtonsType.Ok, "Başlangıç tarihi seçmediniz.");
                    message.Run();
                    message.Destroy();
                }
            };
            dialog.Run();
            dialog.Destroy();
        }

        protected void OnDateEndEntryFocusGrabbed(object sender, EventArgs e)
        {
            DateTimeDialog dialog;
            if (Fetcher.EndAt == new DateTime())
                dialog = new DateTimeDialog();
            else
                dialog = new DateTimeDialog(Fetcher.EndAt);

            dialog.Response += delegate (object obj, ResponseArgs resp) {
                if (resp.ResponseId == ResponseType.Ok)
                {
                    Fetcher.EndAt = dialog.Calendar.Date;
                    DateEndEntry.Text = Fetcher.EndAt.ToString(DateStringFormat);
                }
                else if (resp.ResponseId != ResponseType.Ok && Fetcher.EndAt == new DateTime())
                {
                    MessageDialog message = new MessageDialog(dialog, DialogFlags.DestroyWithParent,
                        MessageType.Warning, ButtonsType.Ok, "Bitiş tarihi seçmediniz.");
                    message.Run();
                    message.Destroy();
                }
            };
            dialog.Run();
            dialog.Destroy();
        }

        protected void OnCurrencyBaseSelectionChanged(object sender, EventArgs e)
        {
            ComboBox box = (ComboBox)sender;
            Enum.TryParse(box.ActiveText, out Fetcher.Base);
        }

        protected void OnCurrencyListButtonClicked(object sender, EventArgs e)
        {
            CurrencyListDialog dialog = new CurrencyListDialog(Fetcher.Symbols);
            dialog.Response += (object obj, ResponseArgs resp) => Fetcher.Symbols = dialog.CurrencySelections;
            dialog.Run();
            dialog.Destroy();
        }

        private static int FetchThreadFlag;

        private void FetchThread()
        {
            if (Interlocked.CompareExchange(ref FetchThreadFlag, 1, 0) == 0)
            {
                Application.Invoke((sender, e) => ChangeStatus("Veriler getiriliyor..."));
                try
                {
                    Dictionary<Currencies, List<Node>> dict = Fetcher.Fetch();
                    Application.Invoke(delegate
                    {
                        MainPlotModel.Series.Clear();
                        foreach (KeyValuePair<Currencies, List<Node>> pair in dict)
                        {
                            MainPlotModel.Series.Add(new LineSeries
                            {
                                Title = pair.Key.ToString(),
                                ItemsSource = pair.Value,
                                DataFieldX = "Time",
                                DataFieldY = "Value",
                                MarkerType = MarkerType.Circle
                            });
                        }
                        MainPlotModel.InvalidatePlot(true);
                    });
                }
                catch (Exception ex) when (ex is DateException || ex is SymbolsException)
                {
                    Application.Invoke(delegate
                    {
                        MessageDialog dialog = new MessageDialog(this, DialogFlags.DestroyWithParent,
                            MessageType.Error, ButtonsType.Ok, ex.Message);
                        dialog.Run();
                        dialog.Destroy();
                    });
                }
                catch (WebException ex)
                {
                    Application.Invoke(delegate
                    {
                        MessageDialog dialog = new MessageDialog(this, DialogFlags.DestroyWithParent,
                            MessageType.Error, ButtonsType.Ok,
                        "Sunucuya istekte bulunurken bir hata ile karşılaşıldı.\n\n" +
                        "Mesaj: " + ex.Message + "\n" +
                        "HResult: " + ex.HResult + "\n" +
                        "Status: " + ex.Status);
                        dialog.Run();
                        dialog.Destroy();
                    });
                }
                Application.Invoke((sender, e) => ChangeStatus(ReadyStatusText));

                Interlocked.Decrement(ref FetchThreadFlag);
            }
            else
            {
                Application.Invoke(delegate {
                    MessageDialog dialog = new MessageDialog(this, DialogFlags.DestroyWithParent,
                        MessageType.Error, ButtonsType.Ok, "Lütfen çalışan işlemin bitmesini bekleyin.");
                    dialog.Run();
                    dialog.Destroy();
                });
            }
        }

        protected void OnFetchButtonClicked(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(FetchThread));
            thread.Start();
        }




        protected class Item
        {
            public DateTime X { get; set; }
            public double Y { get; set; }
        }

        protected static PlotModel TestPlotModel()
        {
            var tmp = new PlotModel { Title = "Test" };
            tmp.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Left,
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot,
                TickStyle = TickStyle.Outside
            });

            var dt = new DateTime(2010, 1, 1);
            tmp.Axes.Add(new DateTimeAxis
            {
                Position = AxisPosition.Bottom,
                Minimum = DateTimeAxis.ToDouble(dt),
                Maximum = DateTimeAxis.ToDouble(dt.AddDays(1)),
                IntervalType = DateTimeIntervalType.Hours,
                MajorGridlineStyle = LineStyle.Solid,
                Angle = 90,
                StringFormat = "HH:mm",
                MajorStep = 1.0 / 24 / 2, // 1/24 = 1 hour, 1/24/2 = 30 minutes
                IsZoomEnabled = true,
                MaximumPadding = 0,
                MinimumPadding = 0,
                TickStyle = TickStyle.None
            });

            var ls = new LineSeries { Title = "Line1", DataFieldX = "X", DataFieldY = "Y" };
            var ii = new List<Item>();

            for (int i = 0; i < 24; i++)
                ii.Add(new Item { X = dt.AddHours(i), Y = i * i });
            ii.Add(new Item { X = dt.AddHours(26), Y = 800 });
            ls.ItemsSource = ii;
            tmp.Series.Add(ls);
            return tmp;
        }
    }
}