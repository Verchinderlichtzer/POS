namespace POS
{
    partial class FMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.btnBarang = new Krypton.Toolkit.KryptonCheckButton();
            this.panelForm = new System.Windows.Forms.Panel();
            this.pPalette = new Krypton.Toolkit.KryptonPalette(this.components);
            this.btnRiwayat = new Krypton.Toolkit.KryptonCheckButton();
            this.btnTransaksi = new Krypton.Toolkit.KryptonCheckButton();
            this.panelTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopBar
            // 
            this.panelTopBar.Controls.Add(this.btnTransaksi);
            this.panelTopBar.Controls.Add(this.btnRiwayat);
            this.panelTopBar.Controls.Add(this.btnBarang);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(800, 30);
            this.panelTopBar.TabIndex = 0;
            // 
            // btnBarang
            // 
            this.btnBarang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBarang.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBarang.Location = new System.Drawing.Point(0, 0);
            this.btnBarang.Name = "btnBarang";
            this.btnBarang.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnBarang.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnBarang.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnBarang.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnBarang.Size = new System.Drawing.Size(266, 30);
            this.btnBarang.StateCommon.Back.Color1 = System.Drawing.SystemColors.Control;
            this.btnBarang.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnBarang.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnBarang.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnBarang.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnBarang.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnBarang.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Gadugi", 12F);
            this.btnBarang.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnBarang.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.btnBarang.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnBarang.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.btnBarang.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left;
            this.btnBarang.StateDisabled.Border.Rounding = 0F;
            this.btnBarang.StateDisabled.Border.Width = 2;
            this.btnBarang.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(143)))), ((int)(((byte)(150)))));
            this.btnBarang.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.btnBarang.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnBarang.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnBarang.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnBarang.StatePressed.Back.Color1 = System.Drawing.SystemColors.Control;
            this.btnBarang.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnBarang.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnBarang.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnBarang.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnBarang.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnBarang.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnBarang.TabIndex = 0;
            this.btnBarang.Values.Text = "Barang";
            this.btnBarang.Click += new System.EventHandler(this.Pilihan);
            // 
            // panelForm
            // 
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(0, 30);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(800, 570);
            this.panelForm.TabIndex = 1;
            // 
            // pPalette
            // 
            this.pPalette.BasePaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.pPalette.ButtonStyles.ButtonCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pPalette.ButtonStyles.ButtonCommon.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.pPalette.GridStyles.GridCommon.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.pPalette.GridStyles.GridCommon.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.pPalette.GridStyles.GridCommon.StateTracking.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(41)))), ((int)(((byte)(62)))));
            this.pPalette.Images.CheckBox.CheckedDisabled = ((System.Drawing.Image)(resources.GetObject("resource.CheckedDisabled")));
            this.pPalette.Images.CheckBox.Common = ((System.Drawing.Image)(resources.GetObject("resource.Common")));
            this.pPalette.Images.CheckBox.UncheckedDisabled = ((System.Drawing.Image)(resources.GetObject("resource.UncheckedDisabled")));
            this.pPalette.Images.RadioButton.CheckedDisabled = ((System.Drawing.Image)(resources.GetObject("resource.CheckedDisabled1")));
            this.pPalette.Images.RadioButton.Common = ((System.Drawing.Image)(resources.GetObject("resource.Common1")));
            this.pPalette.Images.RadioButton.UncheckedDisabled = ((System.Drawing.Image)(resources.GetObject("resource.UncheckedDisabled1")));
            this.pPalette.InputControlStyles.InputControlCustom3.StateActive.Border.Color1 = System.Drawing.Color.Silver;
            this.pPalette.InputControlStyles.InputControlCustom3.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.pPalette.InputControlStyles.InputControlCustom3.StateActive.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.pPalette.InputControlStyles.InputControlCustom3.StateActive.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.pPalette.InputControlStyles.InputControlCustom3.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pPalette.InputControlStyles.InputControlCustom3.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.pPalette.InputControlStyles.InputControlCustom3.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.pPalette.InputControlStyles.InputControlCustom3.StateCommon.Border.Rounding = 0F;
            this.pPalette.InputControlStyles.InputControlCustom3.StateCommon.Border.Width = 1;
            this.pPalette.InputControlStyles.InputControlCustom3.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.pPalette.InputControlStyles.InputControlCustom3.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pPalette.InputControlStyles.InputControlCustom3.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
            this.pPalette.InputControlStyles.InputControlCustom3.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pPalette.InputControlStyles.InputControlCustom3.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.pPalette.InputControlStyles.InputControlCustom3.StateDisabled.Border.Rounding = 0F;
            this.pPalette.InputControlStyles.InputControlCustom3.StateDisabled.Border.Width = 1;
            // 
            // btnRiwayat
            // 
            this.btnRiwayat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRiwayat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRiwayat.Location = new System.Drawing.Point(534, 0);
            this.btnRiwayat.Name = "btnRiwayat";
            this.btnRiwayat.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnRiwayat.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnRiwayat.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnRiwayat.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnRiwayat.Size = new System.Drawing.Size(266, 30);
            this.btnRiwayat.StateCommon.Back.Color1 = System.Drawing.SystemColors.Control;
            this.btnRiwayat.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnRiwayat.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnRiwayat.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnRiwayat.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnRiwayat.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnRiwayat.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Gadugi", 12F);
            this.btnRiwayat.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnRiwayat.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.btnRiwayat.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnRiwayat.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.btnRiwayat.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left;
            this.btnRiwayat.StateDisabled.Border.Rounding = 0F;
            this.btnRiwayat.StateDisabled.Border.Width = 2;
            this.btnRiwayat.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(143)))), ((int)(((byte)(150)))));
            this.btnRiwayat.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.btnRiwayat.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnRiwayat.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnRiwayat.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnRiwayat.StatePressed.Back.Color1 = System.Drawing.SystemColors.Control;
            this.btnRiwayat.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnRiwayat.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnRiwayat.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnRiwayat.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnRiwayat.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnRiwayat.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnRiwayat.TabIndex = 2;
            this.btnRiwayat.Values.Text = "Riwayat";
            this.btnRiwayat.Click += new System.EventHandler(this.Pilihan);
            // 
            // btnTransaksi
            // 
            this.btnTransaksi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransaksi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTransaksi.Location = new System.Drawing.Point(266, 0);
            this.btnTransaksi.Name = "btnTransaksi";
            this.btnTransaksi.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnTransaksi.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnTransaksi.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnTransaksi.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnTransaksi.Size = new System.Drawing.Size(268, 30);
            this.btnTransaksi.StateCommon.Back.Color1 = System.Drawing.SystemColors.Control;
            this.btnTransaksi.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnTransaksi.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnTransaksi.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnTransaksi.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnTransaksi.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnTransaksi.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Gadugi", 12F);
            this.btnTransaksi.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnTransaksi.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.btnTransaksi.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnTransaksi.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.btnTransaksi.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left;
            this.btnTransaksi.StateDisabled.Border.Rounding = 0F;
            this.btnTransaksi.StateDisabled.Border.Width = 2;
            this.btnTransaksi.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(143)))), ((int)(((byte)(150)))));
            this.btnTransaksi.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.btnTransaksi.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnTransaksi.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnTransaksi.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnTransaksi.StatePressed.Back.Color1 = System.Drawing.SystemColors.Control;
            this.btnTransaksi.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnTransaksi.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnTransaksi.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnTransaksi.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnTransaksi.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnTransaksi.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnTransaksi.TabIndex = 1;
            this.btnTransaksi.Values.Text = "Transaksi";
            this.btnTransaksi.Click += new System.EventHandler(this.Pilihan);
            // 
            // FMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelTopBar);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 639);
            this.MinimumSize = new System.Drawing.Size(816, 639);
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Point of Sale (by Sujudi Hanif)";
            this.Load += new System.EventHandler(this.FMain_Load);
            this.panelTopBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.Panel panelForm;
        internal Krypton.Toolkit.KryptonCheckButton btnBarang;
        internal Krypton.Toolkit.KryptonPalette pPalette;
        internal Krypton.Toolkit.KryptonCheckButton btnRiwayat;
        internal Krypton.Toolkit.KryptonCheckButton btnTransaksi;
    }
}