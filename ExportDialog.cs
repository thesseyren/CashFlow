﻿using System;
using Gtk;

namespace CashFlow
{
    public enum ExportType
    {
        PDF, PNG, SVG
    }

    public class ExportProperties
    {
        public ExportType Type;
        public uint Height, Width;
        public byte[] Color;
        public string FileName;
    }

    public partial class ExportDialog : Gtk.Dialog
    {
        public ExportProperties Properties;

        public ExportDialog(ExportType type)
        {
            this.Build();

            foreach (ExportType option in Enum.GetValues(typeof(ExportType)))
                ExportTypeSelection.AppendText(option.ToString());
            ExportTypeSelection.Active = (int)type;
        }

        protected void OnResponse(object o, ResponseArgs args)
        {
            if (args.ResponseId == ResponseType.Ok)
            {
                Properties = new ExportProperties
                {
                    Type = (ExportType)ExportTypeSelection.Active,
                    Height = (uint)HeightInput.Value,
                    Width = (uint)WidthInput.Value,
                    Color = new byte[3]
                    {
                        (byte)ColorButton.Color.Red,
                        (byte)ColorButton.Color.Green,
                        (byte)ColorButton.Color.Blue
                    }
                };
            }
        }
    }
}
