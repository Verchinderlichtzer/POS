namespace POS
{
    partial class FBarang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FBarang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tBarcode = new Krypton.Toolkit.KryptonTextBox();
            this.pPalette = new Krypton.Toolkit.KryptonPalette(this.components);
            this.btnClear = new Krypton.Toolkit.KryptonButton();
            this.btnDelete = new Krypton.Toolkit.KryptonButton();
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            this.dgvPageCounter = new Krypton.Toolkit.KryptonLabel();
            this.dgvPrev = new Krypton.Toolkit.KryptonButton();
            this.dgvFirst = new Krypton.Toolkit.KryptonButton();
            this.dgvNext = new Krypton.Toolkit.KryptonButton();
            this.dgvLast = new Krypton.Toolkit.KryptonButton();
            this.tCariData = new Krypton.Toolkit.KryptonTextBox();
            this.dgv = new Krypton.Toolkit.KryptonDataGridView();
            this.cNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSatuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tHarga = new Krypton.Toolkit.KryptonTextBox();
            this.tNama = new Krypton.Toolkit.KryptonTextBox();
            this.lblHarga = new Krypton.Toolkit.KryptonLabel();
            this.lblNama = new Krypton.Toolkit.KryptonLabel();
            this.tSatuan = new Krypton.Toolkit.KryptonTextBox();
            this.lblSatuan = new Krypton.Toolkit.KryptonLabel();
            this.tID = new Krypton.Toolkit.KryptonTextBox();
            this.lblId = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tBarcode
            // 
            this.tBarcode.AlwaysActive = false;
            this.tBarcode.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tBarcode.CueHint.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Italic);
            this.tBarcode.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tBarcode.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.tBarcode.Location = new System.Drawing.Point(125, 8);
            this.tBarcode.MaxLength = 50;
            this.tBarcode.Name = "tBarcode";
            this.tBarcode.Palette = this.pPalette;
            this.tBarcode.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.tBarcode.Size = new System.Drawing.Size(230, 29);
            this.tBarcode.StateActive.Border.Color1 = System.Drawing.Color.Silver;
            this.tBarcode.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tBarcode.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tBarcode.StateActive.Border.Rounding = 0F;
            this.tBarcode.StateActive.Border.Width = 1;
            this.tBarcode.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.tBarcode.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tBarcode.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.tBarcode.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tBarcode.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tBarcode.StateCommon.Border.Rounding = 0F;
            this.tBarcode.StateCommon.Border.Width = 1;
            this.tBarcode.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tBarcode.StateCommon.Content.Font = new System.Drawing.Font("Verdana", 13.75F);
            this.tBarcode.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tBarcode.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tBarcode.StateDisabled.Border.Rounding = 0F;
            this.tBarcode.StateDisabled.Border.Width = 0;
            this.tBarcode.TabIndex = 3;
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
            this.btnClear.TabIndex = 8;
            this.btnClear.Values.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.BTNClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(626, 535);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(109)))), ((int)(((byte)(84)))));
            this.btnDelete.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnDelete.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnDelete.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnDelete.Palette = this.pPalette;
            this.btnDelete.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnDelete.Size = new System.Drawing.Size(80, 27);
            this.btnDelete.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(146)))), ((int)(((byte)(113)))));
            this.btnDelete.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnDelete.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnDelete.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnDelete.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnDelete.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Gadugi", 12F);
            this.btnDelete.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.btnDelete.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.btnDelete.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnDelete.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(109)))), ((int)(((byte)(84)))));
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Values.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.BTNDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(540, 535);
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
            this.btnSave.TabIndex = 6;
            this.btnSave.Values.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.BTNSave_Click);
            // 
            // dgvPageCounter
            // 
            this.dgvPageCounter.AutoSize = false;
            this.dgvPageCounter.Cursor = System.Windows.Forms.Cursors.Help;
            this.dgvPageCounter.Location = new System.Drawing.Point(348, 507);
            this.dgvPageCounter.Name = "dgvPageCounter";
            this.dgvPageCounter.Palette = this.pPalette;
            this.dgvPageCounter.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.dgvPageCounter.Size = new System.Drawing.Size(104, 24);
            this.dgvPageCounter.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvPageCounter.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgvPageCounter.StateCommon.ShortText.Font = new System.Drawing.Font("Consolas", 12F);
            this.dgvPageCounter.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dgvPageCounter.TabIndex = 314;
            this.dgvPageCounter.Values.Text = "1 / 1";
            this.dgvPageCounter.Click += new System.EventHandler(this.DGVPageCounter_Click);
            // 
            // dgvPrev
            // 
            this.dgvPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvPrev.Enabled = false;
            this.dgvPrev.Location = new System.Drawing.Point(321, 507);
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
            this.dgvPrev.TabIndex = 310;
            this.dgvPrev.Values.Text = "‹";
            this.dgvPrev.Click += new System.EventHandler(this.DGVPrev_Click);
            // 
            // dgvFirst
            // 
            this.dgvFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvFirst.Enabled = false;
            this.dgvFirst.Location = new System.Drawing.Point(294, 507);
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
            this.dgvFirst.TabIndex = 311;
            this.dgvFirst.Values.Text = "«";
            this.dgvFirst.Click += new System.EventHandler(this.DGVFirst_Click);
            // 
            // dgvNext
            // 
            this.dgvNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvNext.Enabled = false;
            this.dgvNext.Location = new System.Drawing.Point(455, 507);
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
            this.dgvNext.TabIndex = 312;
            this.dgvNext.Values.Text = "›";
            this.dgvNext.Click += new System.EventHandler(this.DGVNext_Click);
            // 
            // dgvLast
            // 
            this.dgvLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvLast.Enabled = false;
            this.dgvLast.Location = new System.Drawing.Point(482, 507);
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
            this.dgvLast.TabIndex = 313;
            this.dgvLast.Values.Text = "»";
            this.dgvLast.Click += new System.EventHandler(this.DGVLast_Click);
            // 
            // tCariData
            // 
            this.tCariData.AlwaysActive = false;
            this.tCariData.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tCariData.CueHint.CueHintText = "Cari barang...";
            this.tCariData.CueHint.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Italic);
            this.tCariData.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tCariData.Location = new System.Drawing.Point(8, 535);
            this.tCariData.MaxLength = 100;
            this.tCariData.Name = "tCariData";
            this.tCariData.Palette = this.pPalette;
            this.tCariData.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.tCariData.Size = new System.Drawing.Size(526, 29);
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
            this.tCariData.TabIndex = 5;
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
            this.cNama,
            this.cSatuan,
            this.cHarga});
            this.dgv.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgv.HideOuterBorders = true;
            this.dgv.Location = new System.Drawing.Point(8, 72);
            this.dgv.Name = "dgv";
            this.dgv.Palette = this.pPalette;
            this.dgv.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 27;
            this.dgv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv.Size = new System.Drawing.Size(784, 432);
            this.dgv.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
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
            this.dgv.TabIndex = 4;
            this.dgv.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_CellMouseClick);
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
            this.cNo.Width = 71;
            // 
            // cIdBarang
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cIdBarang.DefaultCellStyle = dataGridViewCellStyle3;
            this.cIdBarang.HeaderText = "ID Barang";
            this.cIdBarang.Name = "cIdBarang";
            this.cIdBarang.ReadOnly = true;
            this.cIdBarang.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cIdBarang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cIdBarang.Visible = false;
            // 
            // cNama
            // 
            this.cNama.HeaderText = "Nama Barang";
            this.cNama.Name = "cNama";
            this.cNama.ReadOnly = true;
            this.cNama.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cNama.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cNama.Width = 487;
            // 
            // cSatuan
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cSatuan.DefaultCellStyle = dataGridViewCellStyle4;
            this.cSatuan.HeaderText = "Satuan";
            this.cSatuan.Name = "cSatuan";
            this.cSatuan.ReadOnly = true;
            this.cSatuan.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cSatuan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cSatuan.Width = 124;
            // 
            // cHarga
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "#,##0";
            this.cHarga.DefaultCellStyle = dataGridViewCellStyle5;
            this.cHarga.HeaderText = "Harga";
            this.cHarga.Name = "cHarga";
            this.cHarga.ReadOnly = true;
            this.cHarga.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cHarga.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cHarga.Width = 101;
            // 
            // tHarga
            // 
            this.tHarga.AlwaysActive = false;
            this.tHarga.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tHarga.CueHint.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Italic);
            this.tHarga.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tHarga.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.tHarga.Location = new System.Drawing.Point(648, 40);
            this.tHarga.MaxLength = 6;
            this.tHarga.Name = "tHarga";
            this.tHarga.Palette = this.pPalette;
            this.tHarga.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.tHarga.Size = new System.Drawing.Size(144, 29);
            this.tHarga.StateActive.Border.Color1 = System.Drawing.Color.Silver;
            this.tHarga.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tHarga.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tHarga.StateActive.Border.Rounding = 0F;
            this.tHarga.StateActive.Border.Width = 1;
            this.tHarga.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.tHarga.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tHarga.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.tHarga.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tHarga.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tHarga.StateCommon.Border.Rounding = 0F;
            this.tHarga.StateCommon.Border.Width = 1;
            this.tHarga.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tHarga.StateCommon.Content.Font = new System.Drawing.Font("Verdana", 13.75F);
            this.tHarga.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tHarga.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tHarga.StateDisabled.Border.Rounding = 0F;
            this.tHarga.StateDisabled.Border.Width = 0;
            this.tHarga.TabIndex = 2;
            this.tHarga.TextChanged += new System.EventHandler(this.Validasi);
            this.tHarga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputAngka);
            // 
            // tNama
            // 
            this.tNama.AlwaysActive = false;
            this.tNama.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tNama.CueHint.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Italic);
            this.tNama.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tNama.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.tNama.Location = new System.Drawing.Point(71, 40);
            this.tNama.MaxLength = 50;
            this.tNama.Name = "tNama";
            this.tNama.Palette = this.pPalette;
            this.tNama.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.tNama.Size = new System.Drawing.Size(499, 29);
            this.tNama.StateActive.Border.Color1 = System.Drawing.Color.Silver;
            this.tNama.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tNama.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tNama.StateActive.Border.Rounding = 0F;
            this.tNama.StateActive.Border.Width = 1;
            this.tNama.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.tNama.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tNama.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.tNama.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tNama.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tNama.StateCommon.Border.Rounding = 0F;
            this.tNama.StateCommon.Border.Width = 1;
            this.tNama.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tNama.StateCommon.Content.Font = new System.Drawing.Font("Verdana", 13.75F);
            this.tNama.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tNama.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tNama.StateDisabled.Border.Rounding = 0F;
            this.tNama.StateDisabled.Border.Width = 0;
            this.tNama.TabIndex = 0;
            this.tNama.TextChanged += new System.EventHandler(this.Validasi);
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = false;
            this.lblHarga.Location = new System.Drawing.Point(576, 40);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Palette = this.pPalette;
            this.lblHarga.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblHarga.Size = new System.Drawing.Size(66, 26);
            this.lblHarga.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHarga.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblHarga.StateCommon.ShortText.Font = new System.Drawing.Font("Trebuchet MS", 12.5F, System.Drawing.FontStyle.Bold);
            this.lblHarga.TabIndex = 308;
            this.lblHarga.Values.Text = "Harga";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = false;
            this.lblNama.Location = new System.Drawing.Point(8, 40);
            this.lblNama.Name = "lblNama";
            this.lblNama.Palette = this.pPalette;
            this.lblNama.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblNama.Size = new System.Drawing.Size(57, 26);
            this.lblNama.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNama.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblNama.StateCommon.ShortText.Font = new System.Drawing.Font("Trebuchet MS", 12.5F, System.Drawing.FontStyle.Bold);
            this.lblNama.TabIndex = 307;
            this.lblNama.Values.Text = "Nama";
            // 
            // tSatuan
            // 
            this.tSatuan.AlwaysActive = false;
            this.tSatuan.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tSatuan.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tSatuan.CueHint.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Italic);
            this.tSatuan.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tSatuan.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.tSatuan.Location = new System.Drawing.Point(648, 8);
            this.tSatuan.MaxLength = 8;
            this.tSatuan.Name = "tSatuan";
            this.tSatuan.Palette = this.pPalette;
            this.tSatuan.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.tSatuan.Size = new System.Drawing.Size(144, 29);
            this.tSatuan.StateActive.Border.Color1 = System.Drawing.Color.Silver;
            this.tSatuan.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tSatuan.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tSatuan.StateActive.Border.Rounding = 0F;
            this.tSatuan.StateActive.Border.Width = 1;
            this.tSatuan.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.tSatuan.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tSatuan.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.tSatuan.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tSatuan.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tSatuan.StateCommon.Border.Rounding = 0F;
            this.tSatuan.StateCommon.Border.Width = 1;
            this.tSatuan.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tSatuan.StateCommon.Content.Font = new System.Drawing.Font("Verdana", 13.75F);
            this.tSatuan.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tSatuan.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tSatuan.StateDisabled.Border.Rounding = 0F;
            this.tSatuan.StateDisabled.Border.Width = 0;
            this.tSatuan.TabIndex = 1;
            // 
            // lblSatuan
            // 
            this.lblSatuan.AutoSize = false;
            this.lblSatuan.Location = new System.Drawing.Point(576, 8);
            this.lblSatuan.Name = "lblSatuan";
            this.lblSatuan.Palette = this.pPalette;
            this.lblSatuan.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblSatuan.Size = new System.Drawing.Size(66, 26);
            this.lblSatuan.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSatuan.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblSatuan.StateCommon.ShortText.Font = new System.Drawing.Font("Trebuchet MS", 12.5F, System.Drawing.FontStyle.Bold);
            this.lblSatuan.TabIndex = 306;
            this.lblSatuan.Values.Text = "Satuan";
            // 
            // tID
            // 
            this.tID.AlwaysActive = false;
            this.tID.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tID.CueHint.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Italic);
            this.tID.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tID.Enabled = false;
            this.tID.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.tID.Location = new System.Drawing.Point(71, 8);
            this.tID.MaxLength = 100;
            this.tID.Name = "tID";
            this.tID.Palette = this.pPalette;
            this.tID.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.tID.Size = new System.Drawing.Size(48, 29);
            this.tID.StateActive.Border.Color1 = System.Drawing.Color.Silver;
            this.tID.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tID.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tID.StateActive.Border.Rounding = 0F;
            this.tID.StateActive.Border.Width = 1;
            this.tID.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.tID.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tID.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.tID.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.tID.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tID.StateCommon.Border.Rounding = 0F;
            this.tID.StateCommon.Border.Width = 1;
            this.tID.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tID.StateCommon.Content.Font = new System.Drawing.Font("Verdana", 13.75F);
            this.tID.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tID.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.tID.StateDisabled.Border.Rounding = 0F;
            this.tID.StateDisabled.Border.Width = 0;
            this.tID.TabIndex = 301;
            this.tID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblId
            // 
            this.lblId.AutoSize = false;
            this.lblId.Location = new System.Drawing.Point(8, 8);
            this.lblId.Name = "lblId";
            this.lblId.Palette = this.pPalette;
            this.lblId.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.lblId.Size = new System.Drawing.Size(57, 26);
            this.lblId.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblId.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblId.StateCommon.ShortText.Font = new System.Drawing.Font("Trebuchet MS", 12.5F, System.Drawing.FontStyle.Bold);
            this.lblId.TabIndex = 305;
            this.lblId.Values.Text = "ID";
            // 
            // FBarang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 570);
            this.Controls.Add(this.tBarcode);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvPageCounter);
            this.Controls.Add(this.dgvPrev);
            this.Controls.Add(this.dgvFirst);
            this.Controls.Add(this.dgvNext);
            this.Controls.Add(this.dgvLast);
            this.Controls.Add(this.tCariData);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.tHarga);
            this.Controls.Add(this.tNama);
            this.Controls.Add(this.lblHarga);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.tSatuan);
            this.Controls.Add(this.lblSatuan);
            this.Controls.Add(this.tID);
            this.Controls.Add(this.lblId);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FBarang";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "FBarang";
            this.Load += new System.EventHandler(this.FBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Krypton.Toolkit.KryptonTextBox tBarcode;
        internal Krypton.Toolkit.KryptonButton btnClear;
        internal Krypton.Toolkit.KryptonButton btnDelete;
        internal Krypton.Toolkit.KryptonButton btnSave;
        internal Krypton.Toolkit.KryptonPalette pPalette;
        internal Krypton.Toolkit.KryptonLabel dgvPageCounter;
        internal Krypton.Toolkit.KryptonButton dgvPrev;
        internal Krypton.Toolkit.KryptonButton dgvFirst;
        internal Krypton.Toolkit.KryptonButton dgvNext;
        internal Krypton.Toolkit.KryptonButton dgvLast;
        internal Krypton.Toolkit.KryptonTextBox tCariData;
        internal Krypton.Toolkit.KryptonDataGridView dgv;
        internal Krypton.Toolkit.KryptonTextBox tHarga;
        internal Krypton.Toolkit.KryptonTextBox tNama;
        internal Krypton.Toolkit.KryptonLabel lblHarga;
        internal Krypton.Toolkit.KryptonLabel lblNama;
        internal Krypton.Toolkit.KryptonTextBox tSatuan;
        internal Krypton.Toolkit.KryptonLabel lblSatuan;
        internal Krypton.Toolkit.KryptonTextBox tID;
        internal Krypton.Toolkit.KryptonLabel lblId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSatuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHarga;
    }
}