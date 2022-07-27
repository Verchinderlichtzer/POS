namespace POS
{
    partial class FTransaksi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FTransaksi));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pPalette = new Krypton.Toolkit.KryptonPalette(this.components);
            this.btnClear = new Krypton.Toolkit.KryptonButton();
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            this.dgvBarangPageCounter = new Krypton.Toolkit.KryptonLabel();
            this.dgvBarangPrev = new Krypton.Toolkit.KryptonButton();
            this.dgvBarangFirst = new Krypton.Toolkit.KryptonButton();
            this.dgvBarangNext = new Krypton.Toolkit.KryptonButton();
            this.dgvBarangLast = new Krypton.Toolkit.KryptonButton();
            this.tCariData = new Krypton.Toolkit.KryptonTextBox();
            this.dgv = new Krypton.Toolkit.KryptonDataGridView();
            this.tTotal = new Krypton.Toolkit.KryptonTextBox();
            this.lblTotal = new Krypton.Toolkit.KryptonLabel();
            this.tDibayar = new Krypton.Toolkit.KryptonTextBox();
            this.lblDibayar = new Krypton.Toolkit.KryptonLabel();
            this.dgvBarang = new Krypton.Toolkit.KryptonDataGridView();
            this.c2IdBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2Satuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2Harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2Daftar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPageCounter = new Krypton.Toolkit.KryptonLabel();
            this.dgvPrev = new Krypton.Toolkit.KryptonButton();
            this.dgvFirst = new Krypton.Toolkit.KryptonButton();
            this.dgvNext = new Krypton.Toolkit.KryptonButton();
            this.dgvLast = new Krypton.Toolkit.KryptonButton();
            this.tKembali = new Krypton.Toolkit.KryptonTextBox();
            this.lblKembali = new Krypton.Toolkit.KryptonLabel();
            this.pd = new System.Drawing.Printing.PrintDocument();
            this.cNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNamaBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSatuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // pPalette
            // 
            this.pPalette.BasePaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.pPalette.ButtonStyles.ButtonCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pPalette.ButtonStyles.ButtonCommon.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.pPalette.GridStyles.GridCommon.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.pPalette.GridStyles.GridCommon.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(73)))), ((int)(((byte)(56)))));
            this.pPalette.GridStyles.GridCommon.StateTracking.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(109)))), ((int)(((byte)(84)))));
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
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(712, 535);
            this.btnClear.Name = "btnClear";
            this.btnClear.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(109)))), ((int)(((byte)(84)))));
            this.btnClear.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnClear.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnClear.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnClear.Palette = this.pPalette;
            this.btnClear.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnClear.Size = new System.Drawing.Size(80, 27);
            this.btnClear.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(146)))), ((int)(((byte)(113)))));
            this.btnClear.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnClear.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnClear.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnClear.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnClear.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Gadugi", 12F);
            this.btnClear.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.btnClear.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.btnClear.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnClear.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(109)))), ((int)(((byte)(84)))));
            this.btnClear.TabIndex = 5;
            this.btnClear.Values.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.BTNClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(626, 535);
            this.btnSave.Name = "btnSave";
            this.btnSave.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(109)))), ((int)(((byte)(84)))));
            this.btnSave.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnSave.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnSave.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnSave.Palette = this.pPalette;
            this.btnSave.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnSave.Size = new System.Drawing.Size(80, 27);
            this.btnSave.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(146)))), ((int)(((byte)(113)))));
            this.btnSave.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnSave.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnSave.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnSave.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnSave.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Gadugi", 12F);
            this.btnSave.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.btnSave.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.btnSave.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSave.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(109)))), ((int)(((byte)(84)))));
            this.btnSave.TabIndex = 4;
            this.btnSave.Values.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.BTNSave_Click);
            // 
            // dgvBarangPageCounter
            // 
            this.dgvBarangPageCounter.AutoSize = false;
            this.dgvBarangPageCounter.Cursor = System.Windows.Forms.Cursors.Help;
            this.dgvBarangPageCounter.Location = new System.Drawing.Point(632, 502);
            this.dgvBarangPageCounter.Name = "dgvBarangPageCounter";
            this.dgvBarangPageCounter.Palette = this.pPalette;
            this.dgvBarangPageCounter.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.dgvBarangPageCounter.Size = new System.Drawing.Size(104, 24);
            this.dgvBarangPageCounter.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvBarangPageCounter.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgvBarangPageCounter.StateCommon.ShortText.Font = new System.Drawing.Font("Consolas", 12F);
            this.dgvBarangPageCounter.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dgvBarangPageCounter.TabIndex = 333;
            this.dgvBarangPageCounter.Values.Text = "1 / 1";
            this.dgvBarangPageCounter.Click += new System.EventHandler(this.DGVBarangPageCounter_Click);
            // 
            // dgvBarangPrev
            // 
            this.dgvBarangPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvBarangPrev.Enabled = false;
            this.dgvBarangPrev.Location = new System.Drawing.Point(605, 502);
            this.dgvBarangPrev.Name = "dgvBarangPrev";
            this.dgvBarangPrev.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.dgvBarangPrev.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgvBarangPrev.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.dgvBarangPrev.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.dgvBarangPrev.Palette = this.pPalette;
            this.dgvBarangPrev.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.dgvBarangPrev.Size = new System.Drawing.Size(24, 24);
            this.dgvBarangPrev.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.dgvBarangPrev.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgvBarangPrev.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.dgvBarangPrev.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.dgvBarangPrev.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4, -1, -1, -1);
            this.dgvBarangPrev.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(146)))), ((int)(((byte)(113)))));
            this.dgvBarangPrev.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBarangPrev.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Gray;
            this.dgvBarangPrev.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(109)))), ((int)(((byte)(84)))));
            this.dgvBarangPrev.TabIndex = 329;
            this.dgvBarangPrev.Values.Text = "‹";
            this.dgvBarangPrev.Click += new System.EventHandler(this.DGVBarangPrev_Click);
            // 
            // dgvBarangFirst
            // 
            this.dgvBarangFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvBarangFirst.Enabled = false;
            this.dgvBarangFirst.Location = new System.Drawing.Point(578, 502);
            this.dgvBarangFirst.Name = "dgvBarangFirst";
            this.dgvBarangFirst.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.dgvBarangFirst.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgvBarangFirst.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.dgvBarangFirst.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.dgvBarangFirst.Palette = this.pPalette;
            this.dgvBarangFirst.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.dgvBarangFirst.Size = new System.Drawing.Size(24, 24);
            this.dgvBarangFirst.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.dgvBarangFirst.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgvBarangFirst.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.dgvBarangFirst.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.dgvBarangFirst.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4, -1, -1, -1);
            this.dgvBarangFirst.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(146)))), ((int)(((byte)(113)))));
            this.dgvBarangFirst.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBarangFirst.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Gray;
            this.dgvBarangFirst.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(109)))), ((int)(((byte)(84)))));
            this.dgvBarangFirst.TabIndex = 330;
            this.dgvBarangFirst.Values.Text = "«";
            this.dgvBarangFirst.Click += new System.EventHandler(this.DGVBarangFirst_Click);
            // 
            // dgvBarangNext
            // 
            this.dgvBarangNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvBarangNext.Enabled = false;
            this.dgvBarangNext.Location = new System.Drawing.Point(739, 502);
            this.dgvBarangNext.Name = "dgvBarangNext";
            this.dgvBarangNext.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.dgvBarangNext.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgvBarangNext.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.dgvBarangNext.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.dgvBarangNext.Palette = this.pPalette;
            this.dgvBarangNext.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.dgvBarangNext.Size = new System.Drawing.Size(24, 24);
            this.dgvBarangNext.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.dgvBarangNext.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgvBarangNext.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.dgvBarangNext.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.dgvBarangNext.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4, -1, -1, -1);
            this.dgvBarangNext.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(146)))), ((int)(((byte)(113)))));
            this.dgvBarangNext.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBarangNext.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Gray;
            this.dgvBarangNext.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(109)))), ((int)(((byte)(84)))));
            this.dgvBarangNext.TabIndex = 331;
            this.dgvBarangNext.Values.Text = "›";
            this.dgvBarangNext.Click += new System.EventHandler(this.DGVBarangNext_Click);
            // 
            // dgvBarangLast
            // 
            this.dgvBarangLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvBarangLast.Enabled = false;
            this.dgvBarangLast.Location = new System.Drawing.Point(766, 502);
            this.dgvBarangLast.Name = "dgvBarangLast";
            this.dgvBarangLast.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.dgvBarangLast.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgvBarangLast.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.dgvBarangLast.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.dgvBarangLast.Palette = this.pPalette;
            this.dgvBarangLast.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.dgvBarangLast.Size = new System.Drawing.Size(24, 24);
            this.dgvBarangLast.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.dgvBarangLast.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgvBarangLast.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.dgvBarangLast.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.dgvBarangLast.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4, -1, -1, -1);
            this.dgvBarangLast.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(146)))), ((int)(((byte)(113)))));
            this.dgvBarangLast.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBarangLast.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Gray;
            this.dgvBarangLast.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(109)))), ((int)(((byte)(84)))));
            this.dgvBarangLast.TabIndex = 332;
            this.dgvBarangLast.Values.Text = "»";
            this.dgvBarangLast.Click += new System.EventHandler(this.DGVBarangLast_Click);
            // 
            // tCariData
            // 
            this.tCariData.AlwaysActive = false;
            this.tCariData.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tCariData.CueHint.CueHintText = "Cari barang...";
            this.tCariData.CueHint.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Italic);
            this.tCariData.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tCariData.Location = new System.Drawing.Point(576, 8);
            this.tCariData.MaxLength = 100;
            this.tCariData.Name = "tCariData";
            this.tCariData.Palette = this.pPalette;
            this.tCariData.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.tCariData.Size = new System.Drawing.Size(216, 29);
            this.tCariData.StateActive.Border.Color1 = System.Drawing.Color.Gray;
            this.tCariData.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tCariData.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tCariData.StateActive.Border.Rounding = 0F;
            this.tCariData.StateActive.Border.Width = 1;
            this.tCariData.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.tCariData.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tCariData.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.tCariData.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tCariData.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tCariData.StateCommon.Border.Rounding = 0F;
            this.tCariData.StateCommon.Border.Width = 1;
            this.tCariData.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tCariData.StateCommon.Content.Font = new System.Drawing.Font("Verdana", 13.75F);
            this.tCariData.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tCariData.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tCariData.StateDisabled.Border.Rounding = 0F;
            this.tCariData.StateDisabled.Border.Width = 0;
            this.tCariData.TabIndex = 0;
            this.tCariData.TextChanged += new System.EventHandler(this.TCariData_TextChanged);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeight = 27;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNo,
            this.cIdBarang,
            this.cBarcode,
            this.cNamaBarang,
            this.cSatuan,
            this.cQty,
            this.cHarga});
            this.dgv.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgv.HideOuterBorders = true;
            this.dgv.Location = new System.Drawing.Point(8, 13);
            this.dgv.Name = "dgv";
            this.dgv.Palette = this.pPalette;
            this.dgv.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 27;
            this.dgv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv.Size = new System.Drawing.Size(562, 486);
            this.dgv.StateCommon.Background.Color1 = System.Drawing.SystemColors.Control;
            this.dgv.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgv.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgv.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgv.StateCommon.DataCell.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgv.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.StateCommon.HeaderColumn.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgv.StateCommon.HeaderColumn.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.dgv.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.dgv.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dgv.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dgv.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgv.StateSelected.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.dgv.StateSelected.DataCell.Content.Color1 = System.Drawing.Color.Black;
            this.dgv.TabIndex = 2;
            this.dgv.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DGV_CellBeginEdit);
            this.dgv.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellEndEdit);
            this.dgv.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DGV_EditingControlShowing);
            this.dgv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DGV_KeyPress);
            // 
            // tTotal
            // 
            this.tTotal.AlwaysActive = false;
            this.tTotal.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tTotal.CueHint.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Italic);
            this.tTotal.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tTotal.Enabled = false;
            this.tTotal.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.tTotal.Location = new System.Drawing.Point(67, 535);
            this.tTotal.MaxLength = 100;
            this.tTotal.Name = "tTotal";
            this.tTotal.Palette = this.pPalette;
            this.tTotal.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.tTotal.Size = new System.Drawing.Size(117, 29);
            this.tTotal.StateActive.Border.Color1 = System.Drawing.Color.Silver;
            this.tTotal.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tTotal.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tTotal.StateActive.Border.Rounding = 0F;
            this.tTotal.StateActive.Border.Width = 1;
            this.tTotal.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.tTotal.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tTotal.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.tTotal.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tTotal.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tTotal.StateCommon.Border.Rounding = 0F;
            this.tTotal.StateCommon.Border.Width = 1;
            this.tTotal.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tTotal.StateCommon.Content.Font = new System.Drawing.Font("Verdana", 13.75F);
            this.tTotal.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tTotal.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tTotal.StateDisabled.Border.Rounding = 0F;
            this.tTotal.StateDisabled.Border.Width = 0;
            this.tTotal.TabIndex = 317;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = false;
            this.lblTotal.Location = new System.Drawing.Point(8, 535);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Palette = this.pPalette;
            this.lblTotal.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblTotal.Size = new System.Drawing.Size(53, 26);
            this.lblTotal.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotal.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblTotal.StateCommon.ShortText.Font = new System.Drawing.Font("Trebuchet MS", 12.5F, System.Drawing.FontStyle.Bold);
            this.lblTotal.TabIndex = 328;
            this.lblTotal.Values.Text = "Total";
            // 
            // tDibayar
            // 
            this.tDibayar.AlwaysActive = false;
            this.tDibayar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tDibayar.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tDibayar.CueHint.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Italic);
            this.tDibayar.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tDibayar.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.tDibayar.Location = new System.Drawing.Point(274, 535);
            this.tDibayar.MaxLength = 9;
            this.tDibayar.Name = "tDibayar";
            this.tDibayar.Palette = this.pPalette;
            this.tDibayar.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.tDibayar.Size = new System.Drawing.Size(117, 29);
            this.tDibayar.StateActive.Border.Color1 = System.Drawing.Color.Silver;
            this.tDibayar.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tDibayar.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tDibayar.StateActive.Border.Rounding = 0F;
            this.tDibayar.StateActive.Border.Width = 1;
            this.tDibayar.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.tDibayar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tDibayar.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.tDibayar.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tDibayar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tDibayar.StateCommon.Border.Rounding = 0F;
            this.tDibayar.StateCommon.Border.Width = 1;
            this.tDibayar.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tDibayar.StateCommon.Content.Font = new System.Drawing.Font("Verdana", 13.75F);
            this.tDibayar.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tDibayar.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tDibayar.StateDisabled.Border.Rounding = 0F;
            this.tDibayar.StateDisabled.Border.Width = 0;
            this.tDibayar.TabIndex = 3;
            this.tDibayar.TextChanged += new System.EventHandler(this.Valid);
            this.tDibayar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputAngka);
            // 
            // lblDibayar
            // 
            this.lblDibayar.AutoSize = false;
            this.lblDibayar.Location = new System.Drawing.Point(195, 535);
            this.lblDibayar.Name = "lblDibayar";
            this.lblDibayar.Palette = this.pPalette;
            this.lblDibayar.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblDibayar.Size = new System.Drawing.Size(73, 26);
            this.lblDibayar.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDibayar.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblDibayar.StateCommon.ShortText.Font = new System.Drawing.Font("Trebuchet MS", 12.5F, System.Drawing.FontStyle.Bold);
            this.lblDibayar.TabIndex = 326;
            this.lblDibayar.Values.Text = "Dibayar";
            // 
            // dgvBarang
            // 
            this.dgvBarang.AllowUserToAddRows = false;
            this.dgvBarang.AllowUserToDeleteRows = false;
            this.dgvBarang.AllowUserToResizeColumns = false;
            this.dgvBarang.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvBarang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBarang.ColumnHeadersHeight = 27;
            this.dgvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBarang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c2IdBarang,
            this.c2Barcode,
            this.c2Nama,
            this.c2Satuan,
            this.c2Harga,
            this.c2Daftar});
            this.dgvBarang.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvBarang.HideOuterBorders = true;
            this.dgvBarang.Location = new System.Drawing.Point(576, 40);
            this.dgvBarang.Name = "dgvBarang";
            this.dgvBarang.Palette = this.pPalette;
            this.dgvBarang.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.dgvBarang.ReadOnly = true;
            this.dgvBarang.RowHeadersVisible = false;
            this.dgvBarang.RowTemplate.Height = 27;
            this.dgvBarang.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvBarang.Size = new System.Drawing.Size(216, 459);
            this.dgvBarang.StateCommon.Background.Color1 = System.Drawing.SystemColors.Control;
            this.dgvBarang.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvBarang.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvBarang.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvBarang.StateCommon.DataCell.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgvBarang.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvBarang.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBarang.StateCommon.HeaderColumn.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgvBarang.StateCommon.HeaderColumn.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.dgvBarang.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.dgvBarang.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBarang.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dgvBarang.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dgvBarang.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvBarang.StateSelected.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.dgvBarang.StateSelected.DataCell.Content.Color1 = System.Drawing.Color.Black;
            this.dgvBarang.TabIndex = 1;
            this.dgvBarang.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVBarang_CellMouseClick);
            // 
            // c2IdBarang
            // 
            this.c2IdBarang.HeaderText = "ID Barang";
            this.c2IdBarang.Name = "c2IdBarang";
            this.c2IdBarang.ReadOnly = true;
            this.c2IdBarang.Visible = false;
            // 
            // c2Barcode
            // 
            this.c2Barcode.HeaderText = "Barcode";
            this.c2Barcode.Name = "c2Barcode";
            this.c2Barcode.ReadOnly = true;
            this.c2Barcode.Visible = false;
            // 
            // c2Nama
            // 
            this.c2Nama.HeaderText = "Nama Barang";
            this.c2Nama.Name = "c2Nama";
            this.c2Nama.ReadOnly = true;
            this.c2Nama.Visible = false;
            // 
            // c2Satuan
            // 
            this.c2Satuan.HeaderText = "Satuan";
            this.c2Satuan.Name = "c2Satuan";
            this.c2Satuan.ReadOnly = true;
            this.c2Satuan.Visible = false;
            // 
            // c2Harga
            // 
            this.c2Harga.HeaderText = "Harga";
            this.c2Harga.Name = "c2Harga";
            this.c2Harga.ReadOnly = true;
            this.c2Harga.Visible = false;
            // 
            // c2Daftar
            // 
            this.c2Daftar.HeaderText = "Daftar Barang";
            this.c2Daftar.Name = "c2Daftar";
            this.c2Daftar.ReadOnly = true;
            this.c2Daftar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.c2Daftar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvPageCounter
            // 
            this.dgvPageCounter.AutoSize = false;
            this.dgvPageCounter.Cursor = System.Windows.Forms.Cursors.Help;
            this.dgvPageCounter.Location = new System.Drawing.Point(237, 502);
            this.dgvPageCounter.Name = "dgvPageCounter";
            this.dgvPageCounter.Palette = this.pPalette;
            this.dgvPageCounter.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.dgvPageCounter.Size = new System.Drawing.Size(104, 24);
            this.dgvPageCounter.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvPageCounter.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgvPageCounter.StateCommon.ShortText.Font = new System.Drawing.Font("Consolas", 12F);
            this.dgvPageCounter.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dgvPageCounter.TabIndex = 341;
            this.dgvPageCounter.Values.Text = "1 / 1";
            this.dgvPageCounter.Click += new System.EventHandler(this.DGVPageCounter_Click);
            // 
            // dgvPrev
            // 
            this.dgvPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvPrev.Enabled = false;
            this.dgvPrev.Location = new System.Drawing.Point(210, 502);
            this.dgvPrev.Name = "dgvPrev";
            this.dgvPrev.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.dgvPrev.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgvPrev.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.dgvPrev.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.dgvPrev.Palette = this.pPalette;
            this.dgvPrev.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.dgvPrev.Size = new System.Drawing.Size(24, 24);
            this.dgvPrev.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.dgvPrev.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgvPrev.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.dgvPrev.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.dgvPrev.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4, -1, -1, -1);
            this.dgvPrev.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(146)))), ((int)(((byte)(113)))));
            this.dgvPrev.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPrev.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Gray;
            this.dgvPrev.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(109)))), ((int)(((byte)(84)))));
            this.dgvPrev.TabIndex = 337;
            this.dgvPrev.Values.Text = "‹";
            this.dgvPrev.Click += new System.EventHandler(this.DGVPrev_Click);
            // 
            // dgvFirst
            // 
            this.dgvFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvFirst.Enabled = false;
            this.dgvFirst.Location = new System.Drawing.Point(183, 502);
            this.dgvFirst.Name = "dgvFirst";
            this.dgvFirst.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.dgvFirst.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgvFirst.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.dgvFirst.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.dgvFirst.Palette = this.pPalette;
            this.dgvFirst.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.dgvFirst.Size = new System.Drawing.Size(24, 24);
            this.dgvFirst.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.dgvFirst.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgvFirst.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.dgvFirst.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.dgvFirst.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4, -1, -1, -1);
            this.dgvFirst.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(146)))), ((int)(((byte)(113)))));
            this.dgvFirst.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFirst.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Gray;
            this.dgvFirst.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(109)))), ((int)(((byte)(84)))));
            this.dgvFirst.TabIndex = 338;
            this.dgvFirst.Values.Text = "«";
            this.dgvFirst.Click += new System.EventHandler(this.DGVFirst_Click);
            // 
            // dgvNext
            // 
            this.dgvNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvNext.Enabled = false;
            this.dgvNext.Location = new System.Drawing.Point(344, 502);
            this.dgvNext.Name = "dgvNext";
            this.dgvNext.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.dgvNext.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgvNext.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.dgvNext.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.dgvNext.Palette = this.pPalette;
            this.dgvNext.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.dgvNext.Size = new System.Drawing.Size(24, 24);
            this.dgvNext.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.dgvNext.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgvNext.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.dgvNext.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.dgvNext.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4, -1, -1, -1);
            this.dgvNext.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(146)))), ((int)(((byte)(113)))));
            this.dgvNext.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvNext.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Gray;
            this.dgvNext.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(109)))), ((int)(((byte)(84)))));
            this.dgvNext.TabIndex = 339;
            this.dgvNext.Values.Text = "›";
            this.dgvNext.Click += new System.EventHandler(this.DGVNext_Click);
            // 
            // dgvLast
            // 
            this.dgvLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvLast.Enabled = false;
            this.dgvLast.Location = new System.Drawing.Point(371, 502);
            this.dgvLast.Name = "dgvLast";
            this.dgvLast.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.dgvLast.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgvLast.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.dgvLast.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.dgvLast.Palette = this.pPalette;
            this.dgvLast.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.dgvLast.Size = new System.Drawing.Size(24, 24);
            this.dgvLast.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.dgvLast.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgvLast.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.dgvLast.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.dgvLast.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4, -1, -1, -1);
            this.dgvLast.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(146)))), ((int)(((byte)(113)))));
            this.dgvLast.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLast.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Gray;
            this.dgvLast.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(109)))), ((int)(((byte)(84)))));
            this.dgvLast.TabIndex = 340;
            this.dgvLast.Values.Text = "»";
            this.dgvLast.Click += new System.EventHandler(this.DGVLast_Click);
            // 
            // tKembali
            // 
            this.tKembali.AlwaysActive = false;
            this.tKembali.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tKembali.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tKembali.CueHint.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Italic);
            this.tKembali.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tKembali.Enabled = false;
            this.tKembali.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.tKembali.Location = new System.Drawing.Point(485, 535);
            this.tKembali.MaxLength = 100;
            this.tKembali.Name = "tKembali";
            this.tKembali.Palette = this.pPalette;
            this.tKembali.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.tKembali.Size = new System.Drawing.Size(125, 29);
            this.tKembali.StateActive.Border.Color1 = System.Drawing.Color.Silver;
            this.tKembali.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tKembali.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tKembali.StateActive.Border.Rounding = 0F;
            this.tKembali.StateActive.Border.Width = 1;
            this.tKembali.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.tKembali.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tKembali.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.tKembali.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tKembali.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tKembali.StateCommon.Border.Rounding = 0F;
            this.tKembali.StateCommon.Border.Width = 1;
            this.tKembali.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tKembali.StateCommon.Content.Font = new System.Drawing.Font("Verdana", 13.75F);
            this.tKembali.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tKembali.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tKembali.StateDisabled.Border.Rounding = 0F;
            this.tKembali.StateDisabled.Border.Width = 0;
            this.tKembali.TabIndex = 342;
            // 
            // lblKembali
            // 
            this.lblKembali.AutoSize = false;
            this.lblKembali.Location = new System.Drawing.Point(402, 535);
            this.lblKembali.Name = "lblKembali";
            this.lblKembali.Palette = this.pPalette;
            this.lblKembali.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblKembali.Size = new System.Drawing.Size(77, 26);
            this.lblKembali.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblKembali.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblKembali.StateCommon.ShortText.Font = new System.Drawing.Font("Trebuchet MS", 12.5F, System.Drawing.FontStyle.Bold);
            this.lblKembali.TabIndex = 343;
            this.lblKembali.Values.Text = "Kembali";
            // 
            // pd
            // 
            this.pd.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.PD_BeginPrint);
            this.pd.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PD_PrintPage);
            // 
            // cNo
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cNo.DefaultCellStyle = dataGridViewCellStyle2;
            this.cNo.HeaderText = "No";
            this.cNo.Name = "cNo";
            this.cNo.ReadOnly = true;
            this.cNo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cNo.Width = 42;
            // 
            // cIdBarang
            // 
            this.cIdBarang.HeaderText = "ID Barang";
            this.cIdBarang.Name = "cIdBarang";
            this.cIdBarang.ReadOnly = true;
            this.cIdBarang.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cIdBarang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cIdBarang.Visible = false;
            // 
            // cBarcode
            // 
            this.cBarcode.HeaderText = "Barcode";
            this.cBarcode.Name = "cBarcode";
            this.cBarcode.ReadOnly = true;
            this.cBarcode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cBarcode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cBarcode.Visible = false;
            // 
            // cNamaBarang
            // 
            this.cNamaBarang.HeaderText = "Nama Barang";
            this.cNamaBarang.Name = "cNamaBarang";
            this.cNamaBarang.ReadOnly = true;
            this.cNamaBarang.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cNamaBarang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cNamaBarang.Width = 270;
            // 
            // cSatuan
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cSatuan.DefaultCellStyle = dataGridViewCellStyle3;
            this.cSatuan.HeaderText = "Satuan";
            this.cSatuan.Name = "cSatuan";
            this.cSatuan.ReadOnly = true;
            this.cSatuan.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cSatuan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cSatuan.Width = 85;
            // 
            // cQty
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cQty.DefaultCellStyle = dataGridViewCellStyle4;
            this.cQty.HeaderText = "Qty";
            this.cQty.MaxInputLength = 4;
            this.cQty.Name = "cQty";
            this.cQty.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cQty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cQty.Width = 55;
            // 
            // cHarga
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "n0";
            this.cHarga.DefaultCellStyle = dataGridViewCellStyle5;
            this.cHarga.HeaderText = "Harga";
            this.cHarga.MaxInputLength = 6;
            this.cHarga.Name = "cHarga";
            this.cHarga.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cHarga.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cHarga.Width = 109;
            // 
            // FTransaksi
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 570);
            this.Controls.Add(this.tKembali);
            this.Controls.Add(this.lblKembali);
            this.Controls.Add(this.dgvPageCounter);
            this.Controls.Add(this.dgvPrev);
            this.Controls.Add(this.dgvFirst);
            this.Controls.Add(this.dgvNext);
            this.Controls.Add(this.dgvLast);
            this.Controls.Add(this.dgvBarang);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvBarangPageCounter);
            this.Controls.Add(this.dgvBarangPrev);
            this.Controls.Add(this.dgvBarangFirst);
            this.Controls.Add(this.dgvBarangNext);
            this.Controls.Add(this.dgvBarangLast);
            this.Controls.Add(this.tCariData);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.tTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.tDibayar);
            this.Controls.Add(this.lblDibayar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FTransaksi";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "FTransaksi";
            this.Load += new System.EventHandler(this.FTransaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal Krypton.Toolkit.KryptonPalette pPalette;
        internal Krypton.Toolkit.KryptonButton btnClear;
        internal Krypton.Toolkit.KryptonButton btnSave;
        internal Krypton.Toolkit.KryptonLabel dgvBarangPageCounter;
        internal Krypton.Toolkit.KryptonButton dgvBarangPrev;
        internal Krypton.Toolkit.KryptonButton dgvBarangFirst;
        internal Krypton.Toolkit.KryptonButton dgvBarangNext;
        internal Krypton.Toolkit.KryptonButton dgvBarangLast;
        internal Krypton.Toolkit.KryptonTextBox tCariData;
        internal Krypton.Toolkit.KryptonDataGridView dgv;
        internal Krypton.Toolkit.KryptonTextBox tTotal;
        internal Krypton.Toolkit.KryptonLabel lblTotal;
        internal Krypton.Toolkit.KryptonTextBox tDibayar;
        internal Krypton.Toolkit.KryptonLabel lblDibayar;
        internal Krypton.Toolkit.KryptonDataGridView dgvBarang;
        internal Krypton.Toolkit.KryptonLabel dgvPageCounter;
        internal Krypton.Toolkit.KryptonButton dgvPrev;
        internal Krypton.Toolkit.KryptonButton dgvFirst;
        internal Krypton.Toolkit.KryptonButton dgvNext;
        internal Krypton.Toolkit.KryptonButton dgvLast;
        internal Krypton.Toolkit.KryptonTextBox tKembali;
        internal Krypton.Toolkit.KryptonLabel lblKembali;
        private System.Drawing.Printing.PrintDocument pd;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2IdBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2Satuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2Harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2Daftar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNamaBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSatuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn cQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHarga;
    }
}