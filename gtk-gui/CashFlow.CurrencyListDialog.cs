
// This file has been generated by the GUI designer. Do not modify.
namespace CashFlow
{
	public partial class CurrencyListDialog
	{
		private global::Gtk.Table MainTable;

		private global::Gtk.Button buttonCancel;

		private global::Gtk.Button buttonOk;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget CashFlow.CurrencyListDialog
			this.Name = "CashFlow.CurrencyListDialog";
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child CashFlow.CurrencyListDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.MainTable = new global::Gtk.Table(((uint)(1)), ((uint)(1)), false);
			this.MainTable.Name = "MainTable";
			this.MainTable.RowSpacing = ((uint)(6));
			this.MainTable.ColumnSpacing = ((uint)(6));
			w1.Add(this.MainTable);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(w1[this.MainTable]));
			w2.Position = 0;
			// Internal child CashFlow.CurrencyListDialog.ActionArea
			global::Gtk.HButtonBox w3 = this.ActionArea;
			w3.Name = "dialog1_ActionArea";
			w3.Spacing = 10;
			w3.BorderWidth = ((uint)(5));
			w3.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget(this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w4 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w3[this.buttonCancel]));
			w4.Expand = false;
			w4.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget(this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w5 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w3[this.buttonOk]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 300;
			this.Show();
			this.Response += new global::Gtk.ResponseHandler(this.OnResponse);
		}
	}
}
