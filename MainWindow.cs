﻿using System;
using Gtk;
using OxyPlot;
using OxyPlot.GtkSharp;
using OxyPlot.Axes;
using OxyPlot.Series;
using System.Collections.Generic;

public partial class MainWindow : Gtk.Window
{
    private PlotView MainPlotView;

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        MainPlotView = new PlotView { Model = TestPlotModel() };
        MainPlotAlignment.Add(MainPlotView);
        MainPlotView.Show();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
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