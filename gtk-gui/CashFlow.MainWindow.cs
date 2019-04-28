
// This file has been generated by the GUI designer. Do not modify.
namespace CashFlow
{
	public partial class MainWindow
	{
		private global::Gtk.UIManager UIManager;

		private global::Gtk.Action DosyaAction;

		private global::Gtk.Action PlanAction;

		private global::Gtk.Action YardmAction;

		private global::Gtk.Action PDFExportAction;

		private global::Gtk.Action PNGExportAction;

		private global::Gtk.Action SVGExportAction;

		private global::Gtk.Action CloseAction;

		private global::Gtk.Action ClearPlotAction;

		private global::Gtk.Action FocusOnDataAction;

		private global::Gtk.Action ShortcutsAction;

		private global::Gtk.Action AboutAction;

		private global::Gtk.Action CSVExportAction;

		private global::Gtk.Action CopyToClipboardAction;

		private global::Gtk.VBox MainVbox;

		private global::Gtk.MenuBar MainMenuBar;

		private global::Gtk.HBox PropsVbox;

		private global::Gtk.Frame DateFrame;

		private global::Gtk.Alignment GtkAlignment;

		private global::Gtk.Table DateFrameTable;

		private global::Gtk.Button DateEndButton;

		private global::Gtk.Entry DateEndEntry;

		private global::Gtk.Label DateEndLabel;

		private global::Gtk.Button DateStartButton;

		private global::Gtk.Entry DateStartEntry;

		private global::Gtk.Label DateStartLabel;

		private global::Gtk.Label DateFrameLabel1;

		private global::Gtk.Frame CurrencyFrame;

		private global::Gtk.Alignment GtkAlignment1;

		private global::Gtk.VBox CurrencyVbox;

		private global::Gtk.HBox CurrencyHbox;

		private global::Gtk.Label CurrencyBaseLabel;

		private global::Gtk.ComboBox CurrencyBaseSelection;

		private global::Gtk.Button CurrencyListButton;

		private global::Gtk.Label CurrencyFrameLabel;

		private global::Gtk.Button FetchButton;

		private global::Gtk.Alignment MainPlotAlignment;

		private global::Gtk.Statusbar MainStatusBar;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget CashFlow.MainWindow
			this.UIManager = new global::Gtk.UIManager();
			global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
			this.DosyaAction = new global::Gtk.Action("DosyaAction", global::Mono.Unix.Catalog.GetString("Dosya"), null, null);
			this.DosyaAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Dosya");
			w1.Add(this.DosyaAction, null);
			this.PlanAction = new global::Gtk.Action("PlanAction", global::Mono.Unix.Catalog.GetString("Plan"), null, null);
			this.PlanAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Plan");
			w1.Add(this.PlanAction, null);
			this.YardmAction = new global::Gtk.Action("YardmAction", global::Mono.Unix.Catalog.GetString("Yardım"), null, null);
			this.YardmAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Yardım");
			w1.Add(this.YardmAction, null);
			this.PDFExportAction = new global::Gtk.Action("PDFExportAction", global::Mono.Unix.Catalog.GetString("PDF Olarak Dışarı Aktar..."), null, "gtk-save-as");
			this.PDFExportAction.ShortLabel = global::Mono.Unix.Catalog.GetString("PDF Olarak Dışarı Aktar...");
			w1.Add(this.PDFExportAction, null);
			this.PNGExportAction = new global::Gtk.Action("PNGExportAction", global::Mono.Unix.Catalog.GetString("PNG Olarak Dışarı Aktar..."), null, "gtk-save-as");
			this.PNGExportAction.ShortLabel = global::Mono.Unix.Catalog.GetString("PNG Olarak Dışarı Aktar...");
			w1.Add(this.PNGExportAction, null);
			this.SVGExportAction = new global::Gtk.Action("SVGExportAction", global::Mono.Unix.Catalog.GetString("SVG Olarak Dışarı Aktar..."), null, "gtk-save-as");
			this.SVGExportAction.ShortLabel = global::Mono.Unix.Catalog.GetString("SVG Olarak Dışarı Aktar...");
			w1.Add(this.SVGExportAction, null);
			this.CloseAction = new global::Gtk.Action("CloseAction", global::Mono.Unix.Catalog.GetString("Çıkış"), null, "gtk-close");
			this.CloseAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Çıkış");
			w1.Add(this.CloseAction, null);
			this.ClearPlotAction = new global::Gtk.Action("ClearPlotAction", global::Mono.Unix.Catalog.GetString("Planı Temizle"), null, "gtk-missing-image");
			this.ClearPlotAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Planı Temizle");
			w1.Add(this.ClearPlotAction, null);
			this.FocusOnDataAction = new global::Gtk.Action("FocusOnDataAction", global::Mono.Unix.Catalog.GetString("Verilere Odaklan"), null, "gtk-zoom-fit");
			this.FocusOnDataAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Verilere Odaklan");
			w1.Add(this.FocusOnDataAction, null);
			this.ShortcutsAction = new global::Gtk.Action("ShortcutsAction", global::Mono.Unix.Catalog.GetString("Kısayollar"), null, "gtk-info");
			this.ShortcutsAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Kısayollar");
			w1.Add(this.ShortcutsAction, null);
			this.AboutAction = new global::Gtk.Action("AboutAction", global::Mono.Unix.Catalog.GetString("Hakkında"), null, "gtk-about");
			this.AboutAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Hakkında");
			w1.Add(this.AboutAction, null);
			this.CSVExportAction = new global::Gtk.Action("CSVExportAction", global::Mono.Unix.Catalog.GetString("CSV Olarak Dışarı Aktar..."), null, "gtk-save-as");
			this.CSVExportAction.ShortLabel = global::Mono.Unix.Catalog.GetString("CSV Olarak Dışarı Aktar...");
			w1.Add(this.CSVExportAction, null);
			this.CopyToClipboardAction = new global::Gtk.Action("CopyToClipboardAction", global::Mono.Unix.Catalog.GetString("Planın Resmini Panoya Kopyala"), null, "gtk-copy");
			this.CopyToClipboardAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Planın Resmini Panoya Kopyala");
			w1.Add(this.CopyToClipboardAction, null);
			this.UIManager.InsertActionGroup(w1, 0);
			this.AddAccelGroup(this.UIManager.AccelGroup);
			this.Name = "CashFlow.MainWindow";
			this.Title = global::Mono.Unix.Catalog.GetString("CashFlow");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.DefaultWidth = 1280;
			this.DefaultHeight = 720;
			// Container child CashFlow.MainWindow.Gtk.Container+ContainerChild
			this.MainVbox = new global::Gtk.VBox();
			this.MainVbox.Name = "MainVbox";
			this.MainVbox.Spacing = 6;
			// Container child MainVbox.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString(@"<ui><menubar name='MainMenuBar'><menu name='DosyaAction' action='DosyaAction'><menuitem name='PDFExportAction' action='PDFExportAction'/><menuitem name='PNGExportAction' action='PNGExportAction'/><menuitem name='SVGExportAction' action='SVGExportAction'/><menuitem name='CSVExportAction' action='CSVExportAction'/><separator/><menuitem name='CloseAction' action='CloseAction'/></menu><menu name='PlanAction' action='PlanAction'><menuitem name='ClearPlotAction' action='ClearPlotAction'/><menuitem name='FocusOnDataAction' action='FocusOnDataAction'/><separator/><menuitem name='CopyToClipboardAction' action='CopyToClipboardAction'/></menu><menu name='YardmAction' action='YardmAction'><menuitem name='ShortcutsAction' action='ShortcutsAction'/><separator/><menuitem name='AboutAction' action='AboutAction'/></menu><menu/></menubar></ui>");
			this.MainMenuBar = ((global::Gtk.MenuBar)(this.UIManager.GetWidget("/MainMenuBar")));
			this.MainMenuBar.Name = "MainMenuBar";
			this.MainVbox.Add(this.MainMenuBar);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.MainVbox[this.MainMenuBar]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child MainVbox.Gtk.Box+BoxChild
			this.PropsVbox = new global::Gtk.HBox();
			this.PropsVbox.Name = "PropsVbox";
			this.PropsVbox.Spacing = 6;
			// Container child PropsVbox.Gtk.Box+BoxChild
			this.DateFrame = new global::Gtk.Frame();
			this.DateFrame.Name = "DateFrame";
			this.DateFrame.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child DateFrame.Gtk.Container+ContainerChild
			this.GtkAlignment = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.GtkAlignment.Name = "GtkAlignment";
			this.GtkAlignment.LeftPadding = ((uint)(12));
			this.GtkAlignment.TopPadding = ((uint)(6));
			this.GtkAlignment.RightPadding = ((uint)(6));
			this.GtkAlignment.BottomPadding = ((uint)(6));
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			this.DateFrameTable = new global::Gtk.Table(((uint)(2)), ((uint)(3)), false);
			this.DateFrameTable.Name = "DateFrameTable";
			this.DateFrameTable.RowSpacing = ((uint)(6));
			this.DateFrameTable.ColumnSpacing = ((uint)(6));
			// Container child DateFrameTable.Gtk.Table+TableChild
			this.DateEndButton = new global::Gtk.Button();
			this.DateEndButton.CanFocus = true;
			this.DateEndButton.Name = "DateEndButton";
			this.DateEndButton.UseUnderline = true;
			this.DateEndButton.Label = global::Mono.Unix.Catalog.GetString("Seç...");
			this.DateFrameTable.Add(this.DateEndButton);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.DateFrameTable[this.DateEndButton]));
			w3.TopAttach = ((uint)(1));
			w3.BottomAttach = ((uint)(2));
			w3.LeftAttach = ((uint)(2));
			w3.RightAttach = ((uint)(3));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child DateFrameTable.Gtk.Table+TableChild
			this.DateEndEntry = new global::Gtk.Entry();
			this.DateEndEntry.WidthRequest = 140;
			this.DateEndEntry.Name = "DateEndEntry";
			this.DateEndEntry.Text = global::Mono.Unix.Catalog.GetString("-tarih seçin-");
			this.DateEndEntry.IsEditable = false;
			this.DateEndEntry.InvisibleChar = '•';
			this.DateFrameTable.Add(this.DateEndEntry);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.DateFrameTable[this.DateEndEntry]));
			w4.TopAttach = ((uint)(1));
			w4.BottomAttach = ((uint)(2));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child DateFrameTable.Gtk.Table+TableChild
			this.DateEndLabel = new global::Gtk.Label();
			this.DateEndLabel.Name = "DateEndLabel";
			this.DateEndLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Bitiş:");
			this.DateFrameTable.Add(this.DateEndLabel);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.DateFrameTable[this.DateEndLabel]));
			w5.TopAttach = ((uint)(1));
			w5.BottomAttach = ((uint)(2));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child DateFrameTable.Gtk.Table+TableChild
			this.DateStartButton = new global::Gtk.Button();
			this.DateStartButton.CanFocus = true;
			this.DateStartButton.Name = "DateStartButton";
			this.DateStartButton.UseUnderline = true;
			this.DateStartButton.Label = global::Mono.Unix.Catalog.GetString("Seç...");
			this.DateFrameTable.Add(this.DateStartButton);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.DateFrameTable[this.DateStartButton]));
			w6.LeftAttach = ((uint)(2));
			w6.RightAttach = ((uint)(3));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child DateFrameTable.Gtk.Table+TableChild
			this.DateStartEntry = new global::Gtk.Entry();
			this.DateStartEntry.WidthRequest = 140;
			this.DateStartEntry.Name = "DateStartEntry";
			this.DateStartEntry.Text = global::Mono.Unix.Catalog.GetString("-tarih seçin-");
			this.DateStartEntry.IsEditable = false;
			this.DateStartEntry.InvisibleChar = '•';
			this.DateFrameTable.Add(this.DateStartEntry);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.DateFrameTable[this.DateStartEntry]));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child DateFrameTable.Gtk.Table+TableChild
			this.DateStartLabel = new global::Gtk.Label();
			this.DateStartLabel.Name = "DateStartLabel";
			this.DateStartLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Başlangıç:");
			this.DateFrameTable.Add(this.DateStartLabel);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.DateFrameTable[this.DateStartLabel]));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			this.GtkAlignment.Add(this.DateFrameTable);
			this.DateFrame.Add(this.GtkAlignment);
			this.DateFrameLabel1 = new global::Gtk.Label();
			this.DateFrameLabel1.Name = "DateFrameLabel1";
			this.DateFrameLabel1.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Tarih Aralığı</b>");
			this.DateFrameLabel1.UseMarkup = true;
			this.DateFrame.LabelWidget = this.DateFrameLabel1;
			this.PropsVbox.Add(this.DateFrame);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.PropsVbox[this.DateFrame]));
			w11.Position = 0;
			w11.Expand = false;
			w11.Fill = false;
			// Container child PropsVbox.Gtk.Box+BoxChild
			this.CurrencyFrame = new global::Gtk.Frame();
			this.CurrencyFrame.Name = "CurrencyFrame";
			this.CurrencyFrame.ShadowType = ((global::Gtk.ShadowType)(2));
			// Container child CurrencyFrame.Gtk.Container+ContainerChild
			this.GtkAlignment1 = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.GtkAlignment1.Name = "GtkAlignment1";
			this.GtkAlignment1.LeftPadding = ((uint)(12));
			this.GtkAlignment1.TopPadding = ((uint)(6));
			this.GtkAlignment1.RightPadding = ((uint)(6));
			this.GtkAlignment1.BottomPadding = ((uint)(6));
			// Container child GtkAlignment1.Gtk.Container+ContainerChild
			this.CurrencyVbox = new global::Gtk.VBox();
			this.CurrencyVbox.Name = "CurrencyVbox";
			// Container child CurrencyVbox.Gtk.Box+BoxChild
			this.CurrencyHbox = new global::Gtk.HBox();
			this.CurrencyHbox.Name = "CurrencyHbox";
			this.CurrencyHbox.Spacing = 6;
			// Container child CurrencyHbox.Gtk.Box+BoxChild
			this.CurrencyBaseLabel = new global::Gtk.Label();
			this.CurrencyBaseLabel.Name = "CurrencyBaseLabel";
			this.CurrencyBaseLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Taban Kur:");
			this.CurrencyHbox.Add(this.CurrencyBaseLabel);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.CurrencyHbox[this.CurrencyBaseLabel]));
			w12.Position = 0;
			w12.Expand = false;
			w12.Fill = false;
			// Container child CurrencyHbox.Gtk.Box+BoxChild
			this.CurrencyBaseSelection = global::Gtk.ComboBox.NewText();
			this.CurrencyBaseSelection.Name = "CurrencyBaseSelection";
			this.CurrencyHbox.Add(this.CurrencyBaseSelection);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.CurrencyHbox[this.CurrencyBaseSelection]));
			w13.Position = 1;
			this.CurrencyVbox.Add(this.CurrencyHbox);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.CurrencyVbox[this.CurrencyHbox]));
			w14.Position = 0;
			w14.Expand = false;
			w14.Fill = false;
			// Container child CurrencyVbox.Gtk.Box+BoxChild
			this.CurrencyListButton = new global::Gtk.Button();
			this.CurrencyListButton.CanFocus = true;
			this.CurrencyListButton.Name = "CurrencyListButton";
			this.CurrencyListButton.UseUnderline = true;
			this.CurrencyListButton.Label = global::Mono.Unix.Catalog.GetString("Gösterilecek Kurlar");
			this.CurrencyVbox.Add(this.CurrencyListButton);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.CurrencyVbox[this.CurrencyListButton]));
			w15.Position = 1;
			w15.Expand = false;
			w15.Fill = false;
			this.GtkAlignment1.Add(this.CurrencyVbox);
			this.CurrencyFrame.Add(this.GtkAlignment1);
			this.CurrencyFrameLabel = new global::Gtk.Label();
			this.CurrencyFrameLabel.Name = "CurrencyFrameLabel";
			this.CurrencyFrameLabel.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Kur Tercihleri</b>");
			this.CurrencyFrameLabel.UseMarkup = true;
			this.CurrencyFrame.LabelWidget = this.CurrencyFrameLabel;
			this.PropsVbox.Add(this.CurrencyFrame);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.PropsVbox[this.CurrencyFrame]));
			w18.Position = 1;
			w18.Expand = false;
			w18.Fill = false;
			// Container child PropsVbox.Gtk.Box+BoxChild
			this.FetchButton = new global::Gtk.Button();
			this.FetchButton.CanFocus = true;
			this.FetchButton.Name = "FetchButton";
			this.FetchButton.UseUnderline = true;
			this.FetchButton.Label = global::Mono.Unix.Catalog.GetString("Verileri Getir");
			this.PropsVbox.Add(this.FetchButton);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.PropsVbox[this.FetchButton]));
			w19.Position = 2;
			w19.Expand = false;
			w19.Fill = false;
			this.MainVbox.Add(this.PropsVbox);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.MainVbox[this.PropsVbox]));
			w20.Position = 1;
			w20.Expand = false;
			w20.Fill = false;
			// Container child MainVbox.Gtk.Box+BoxChild
			this.MainPlotAlignment = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.MainPlotAlignment.Name = "MainPlotAlignment";
			this.MainVbox.Add(this.MainPlotAlignment);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.MainVbox[this.MainPlotAlignment]));
			w21.Position = 2;
			// Container child MainVbox.Gtk.Box+BoxChild
			this.MainStatusBar = new global::Gtk.Statusbar();
			this.MainStatusBar.Name = "MainStatusBar";
			this.MainStatusBar.Spacing = 6;
			this.MainStatusBar.BorderWidth = ((uint)(2));
			this.MainVbox.Add(this.MainStatusBar);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.MainVbox[this.MainStatusBar]));
			w22.PackType = ((global::Gtk.PackType)(1));
			w22.Position = 3;
			w22.Expand = false;
			w22.Fill = false;
			this.Add(this.MainVbox);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Show();
			this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
			this.PDFExportAction.Activated += new global::System.EventHandler(this.OnPDFExportActionActivated);
			this.PNGExportAction.Activated += new global::System.EventHandler(this.OnPNGExportActionActivated);
			this.SVGExportAction.Activated += new global::System.EventHandler(this.OnSVGExportActionActivated);
			this.CloseAction.Activated += new global::System.EventHandler(this.OnCloseActionActivated);
			this.DateStartButton.Clicked += new global::System.EventHandler(this.OnDateStartButtonClicked);
			this.DateEndButton.Clicked += new global::System.EventHandler(this.OnDateEndButtonClicked);
			this.CurrencyBaseSelection.Changed += new global::System.EventHandler(this.OnCurrencyBaseSelectionChanged);
			this.CurrencyListButton.Clicked += new global::System.EventHandler(this.OnCurrencyListButtonClicked);
			this.FetchButton.Clicked += new global::System.EventHandler(this.OnFetchButtonClicked);
		}
	}
}
