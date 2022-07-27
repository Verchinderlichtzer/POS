namespace POS
{
    partial class FRiwayat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRiwayat));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPageCounter = new Krypton.Toolkit.KryptonLabel();
            this.pPalette = new Krypton.Toolkit.KryptonPalette(this.components);
            this.dgvPrev = new Krypton.Toolkit.KryptonButton();
            this.dgvFirst = new Krypton.Toolkit.KryptonButton();
            this.dgvNext = new Krypton.Toolkit.KryptonButton();
            this.dgvLast = new Krypton.Toolkit.KryptonButton();
            this.dgvRiwayat = new Krypton.Toolkit.KryptonDataGridView();
            this.cNoFaktur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDibayar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv = new Krypton.Toolkit.KryptonDataGridView();
            this.cNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSatuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRiwayatLast = new Krypton.Toolkit.KryptonButton();
            this.dgvRiwayatNext = new Krypton.Toolkit.KryptonButton();
            this.dgvRiwayatFirst = new Krypton.Toolkit.KryptonButton();
            this.dgvRiwayatPrev = new Krypton.Toolkit.KryptonButton();
            this.dgvRiwayatPageCounter = new Krypton.Toolkit.KryptonLabel();
            this.btnAuthor = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRiwayat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPageCounter
            // 
            this.dgvPageCounter.AutoSize = false;
            this.dgvPageCounter.Cursor = System.Windows.Forms.Cursors.Help;
            this.dgvPageCounter.Location = new System.Drawing.Point(518, 524);
            this.dgvPageCounter.Name = "dgvPageCounter";
            this.dgvPageCounter.Palette = this.pPalette;
            this.dgvPageCounter.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.dgvPageCounter.Size = new System.Drawing.Size(104, 24);
            this.dgvPageCounter.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvPageCounter.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgvPageCounter.StateCommon.ShortText.Font = new System.Drawing.Font("Consolas", 12F);
            this.dgvPageCounter.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dgvPageCounter.TabIndex = 333;
            this.dgvPageCounter.Values.Text = "1 / 1";
            this.dgvPageCounter.Click += new System.EventHandler(this.DGVPageCounter_Click);
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
            // dgvPrev
            // 
            this.dgvPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvPrev.Enabled = false;
            this.dgvPrev.Location = new System.Drawing.Point(491, 524);
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
            this.dgvPrev.TabIndex = 329;
            this.dgvPrev.Values.Text = "‹";
            this.dgvPrev.Click += new System.EventHandler(this.DGVPrev_Click);
            // 
            // dgvFirst
            // 
            this.dgvFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvFirst.Enabled = false;
            this.dgvFirst.Location = new System.Drawing.Point(464, 524);
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
            this.dgvFirst.TabIndex = 330;
            this.dgvFirst.Values.Text = "«";
            this.dgvFirst.Click += new System.EventHandler(this.DGVFirst_Click);
            // 
            // dgvNext
            // 
            this.dgvNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvNext.Enabled = false;
            this.dgvNext.Location = new System.Drawing.Point(625, 524);
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
            this.dgvNext.TabIndex = 331;
            this.dgvNext.Values.Text = "›";
            this.dgvNext.Click += new System.EventHandler(this.DGVNext_Click);
            // 
            // dgvLast
            // 
            this.dgvLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvLast.Enabled = false;
            this.dgvLast.Location = new System.Drawing.Point(652, 524);
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
            this.dgvLast.TabIndex = 332;
            this.dgvLast.Values.Text = "»";
            this.dgvLast.Click += new System.EventHandler(this.DGVLast_Click);
            // 
            // dgvRiwayat
            // 
            this.dgvRiwayat.AllowUserToAddRows = false;
            this.dgvRiwayat.AllowUserToDeleteRows = false;
            this.dgvRiwayat.AllowUserToResizeColumns = false;
            this.dgvRiwayat.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvRiwayat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRiwayat.ColumnHeadersHeight = 27;
            this.dgvRiwayat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRiwayat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNoFaktur,
            this.cTanggal,
            this.cTotal,
            this.cDibayar});
            this.dgvRiwayat.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvRiwayat.HideOuterBorders = true;
            this.dgvRiwayat.Location = new System.Drawing.Point(8, 8);
            this.dgvRiwayat.Name = "dgvRiwayat";
            this.dgvRiwayat.Palette = this.pPalette;
            this.dgvRiwayat.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.dgvRiwayat.ReadOnly = true;
            this.dgvRiwayat.RowHeadersVisible = false;
            this.dgvRiwayat.RowTemplate.Height = 27;
            this.dgvRiwayat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvRiwayat.Size = new System.Drawing.Size(334, 513);
            this.dgvRiwayat.StateCommon.Background.Color1 = System.Drawing.SystemColors.Control;
            this.dgvRiwayat.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvRiwayat.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvRiwayat.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvRiwayat.StateCommon.DataCell.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgvRiwayat.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvRiwayat.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRiwayat.StateCommon.HeaderColumn.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgvRiwayat.StateCommon.HeaderColumn.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.dgvRiwayat.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.dgvRiwayat.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRiwayat.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dgvRiwayat.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dgvRiwayat.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvRiwayat.StateSelected.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.dgvRiwayat.StateSelected.DataCell.Content.Color1 = System.Drawing.Color.Black;
            this.dgvRiwayat.TabIndex = 319;
            this.dgvRiwayat.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVRiwayat_CellMouseClick);
            // 
            // cNoFaktur
            // 
            this.cNoFaktur.HeaderText = "No Faktur";
            this.cNoFaktur.Name = "cNoFaktur";
            this.cNoFaktur.ReadOnly = true;
            this.cNoFaktur.Visible = false;
            // 
            // cTanggal
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "dd-MM-yyyy";
            this.cTanggal.DefaultCellStyle = dataGridViewCellStyle2;
            this.cTanggal.HeaderText = "Tanggal";
            this.cTanggal.Name = "cTanggal";
            this.cTanggal.ReadOnly = true;
            this.cTanggal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cTanggal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cTanggal.Width = 107;
            // 
            // cTotal
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "n0";
            this.cTotal.DefaultCellStyle = dataGridViewCellStyle3;
            this.cTotal.HeaderText = "Total";
            this.cTotal.Name = "cTotal";
            this.cTotal.ReadOnly = true;
            this.cTotal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cTotal.Width = 113;
            // 
            // cDibayar
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "n0";
            this.cDibayar.DefaultCellStyle = dataGridViewCellStyle4;
            this.cDibayar.HeaderText = "Dibayar";
            this.cDibayar.Name = "cDibayar";
            this.cDibayar.ReadOnly = true;
            this.cDibayar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cDibayar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cDibayar.Width = 113;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv.ColumnHeadersHeight = 27;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNo,
            this.cNama,
            this.cSatuan,
            this.cQty,
            this.cHarga});
            this.dgv.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgv.HideOuterBorders = true;
            this.dgv.Location = new System.Drawing.Point(348, 8);
            this.dgv.Name = "dgv";
            this.dgv.Palette = this.pPalette;
            this.dgv.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 27;
            this.dgv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv.Size = new System.Drawing.Size(444, 513);
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
            this.dgv.TabIndex = 336;
            // 
            // cNo
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cNo.DefaultCellStyle = dataGridViewCellStyle6;
            this.cNo.HeaderText = "No";
            this.cNo.Name = "cNo";
            this.cNo.ReadOnly = true;
            this.cNo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cNo.Width = 33;
            // 
            // cNama
            // 
            this.cNama.HeaderText = "Nama Barang";
            this.cNama.Name = "cNama";
            this.cNama.ReadOnly = true;
            this.cNama.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cNama.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cNama.Width = 185;
            // 
            // cSatuan
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cSatuan.DefaultCellStyle = dataGridViewCellStyle7;
            this.cSatuan.HeaderText = "Satuan";
            this.cSatuan.Name = "cSatuan";
            this.cSatuan.ReadOnly = true;
            this.cSatuan.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cSatuan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cSatuan.Width = 86;
            // 
            // cQty
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cQty.DefaultCellStyle = dataGridViewCellStyle8;
            this.cQty.HeaderText = "Qty";
            this.cQty.Name = "cQty";
            this.cQty.ReadOnly = true;
            this.cQty.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cQty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cQty.Width = 57;
            // 
            // cHarga
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            dataGridViewCellStyle9.Format = "n0";
            this.cHarga.DefaultCellStyle = dataGridViewCellStyle9;
            this.cHarga.HeaderText = "Harga";
            this.cHarga.Name = "cHarga";
            this.cHarga.ReadOnly = true;
            this.cHarga.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cHarga.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cHarga.Width = 82;
            // 
            // dgvRiwayatLast
            // 
            this.dgvRiwayatLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvRiwayatLast.Enabled = false;
            this.dgvRiwayatLast.Location = new System.Drawing.Point(257, 524);
            this.dgvRiwayatLast.Name = "dgvRiwayatLast";
            this.dgvRiwayatLast.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.dgvRiwayatLast.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgvRiwayatLast.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.dgvRiwayatLast.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.dgvRiwayatLast.Palette = this.pPalette;
            this.dgvRiwayatLast.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.dgvRiwayatLast.Size = new System.Drawing.Size(24, 24);
            this.dgvRiwayatLast.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.dgvRiwayatLast.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgvRiwayatLast.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.dgvRiwayatLast.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.dgvRiwayatLast.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4, -1, -1, -1);
            this.dgvRiwayatLast.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(146)))), ((int)(((byte)(113)))));
            this.dgvRiwayatLast.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRiwayatLast.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Gray;
            this.dgvRiwayatLast.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(109)))), ((int)(((byte)(84)))));
            this.dgvRiwayatLast.TabIndex = 332;
            this.dgvRiwayatLast.Values.Text = "»";
            this.dgvRiwayatLast.Click += new System.EventHandler(this.DGVRiwayatLast_Click);
            // 
            // dgvRiwayatNext
            // 
            this.dgvRiwayatNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvRiwayatNext.Enabled = false;
            this.dgvRiwayatNext.Location = new System.Drawing.Point(230, 524);
            this.dgvRiwayatNext.Name = "dgvRiwayatNext";
            this.dgvRiwayatNext.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.dgvRiwayatNext.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgvRiwayatNext.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.dgvRiwayatNext.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.dgvRiwayatNext.Palette = this.pPalette;
            this.dgvRiwayatNext.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.dgvRiwayatNext.Size = new System.Drawing.Size(24, 24);
            this.dgvRiwayatNext.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.dgvRiwayatNext.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgvRiwayatNext.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.dgvRiwayatNext.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.dgvRiwayatNext.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4, -1, -1, -1);
            this.dgvRiwayatNext.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(146)))), ((int)(((byte)(113)))));
            this.dgvRiwayatNext.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRiwayatNext.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Gray;
            this.dgvRiwayatNext.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(109)))), ((int)(((byte)(84)))));
            this.dgvRiwayatNext.TabIndex = 331;
            this.dgvRiwayatNext.Values.Text = "›";
            this.dgvRiwayatNext.Click += new System.EventHandler(this.DGVRiwayatNext_Click);
            // 
            // dgvRiwayatFirst
            // 
            this.dgvRiwayatFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvRiwayatFirst.Enabled = false;
            this.dgvRiwayatFirst.Location = new System.Drawing.Point(69, 524);
            this.dgvRiwayatFirst.Name = "dgvRiwayatFirst";
            this.dgvRiwayatFirst.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.dgvRiwayatFirst.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgvRiwayatFirst.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.dgvRiwayatFirst.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.dgvRiwayatFirst.Palette = this.pPalette;
            this.dgvRiwayatFirst.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.dgvRiwayatFirst.Size = new System.Drawing.Size(24, 24);
            this.dgvRiwayatFirst.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.dgvRiwayatFirst.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgvRiwayatFirst.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.dgvRiwayatFirst.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.dgvRiwayatFirst.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4, -1, -1, -1);
            this.dgvRiwayatFirst.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(146)))), ((int)(((byte)(113)))));
            this.dgvRiwayatFirst.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRiwayatFirst.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Gray;
            this.dgvRiwayatFirst.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(109)))), ((int)(((byte)(84)))));
            this.dgvRiwayatFirst.TabIndex = 330;
            this.dgvRiwayatFirst.Values.Text = "«";
            this.dgvRiwayatFirst.Click += new System.EventHandler(this.DGVRiwayatFirst_Click);
            // 
            // dgvRiwayatPrev
            // 
            this.dgvRiwayatPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvRiwayatPrev.Enabled = false;
            this.dgvRiwayatPrev.Location = new System.Drawing.Point(96, 524);
            this.dgvRiwayatPrev.Name = "dgvRiwayatPrev";
            this.dgvRiwayatPrev.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.dgvRiwayatPrev.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgvRiwayatPrev.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.dgvRiwayatPrev.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.dgvRiwayatPrev.Palette = this.pPalette;
            this.dgvRiwayatPrev.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.dgvRiwayatPrev.Size = new System.Drawing.Size(24, 24);
            this.dgvRiwayatPrev.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.dgvRiwayatPrev.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgvRiwayatPrev.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.dgvRiwayatPrev.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.dgvRiwayatPrev.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4, -1, -1, -1);
            this.dgvRiwayatPrev.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(146)))), ((int)(((byte)(113)))));
            this.dgvRiwayatPrev.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRiwayatPrev.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Gray;
            this.dgvRiwayatPrev.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(109)))), ((int)(((byte)(84)))));
            this.dgvRiwayatPrev.TabIndex = 329;
            this.dgvRiwayatPrev.Values.Text = "‹";
            this.dgvRiwayatPrev.Click += new System.EventHandler(this.DGVRiwayatPrev_Click);
            // 
            // dgvRiwayatPageCounter
            // 
            this.dgvRiwayatPageCounter.AutoSize = false;
            this.dgvRiwayatPageCounter.Cursor = System.Windows.Forms.Cursors.Help;
            this.dgvRiwayatPageCounter.Location = new System.Drawing.Point(123, 524);
            this.dgvRiwayatPageCounter.Name = "dgvRiwayatPageCounter";
            this.dgvRiwayatPageCounter.Palette = this.pPalette;
            this.dgvRiwayatPageCounter.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.dgvRiwayatPageCounter.Size = new System.Drawing.Size(104, 24);
            this.dgvRiwayatPageCounter.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvRiwayatPageCounter.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgvRiwayatPageCounter.StateCommon.ShortText.Font = new System.Drawing.Font("Consolas", 12F);
            this.dgvRiwayatPageCounter.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dgvRiwayatPageCounter.TabIndex = 333;
            this.dgvRiwayatPageCounter.Values.Text = "1 / 1";
            this.dgvRiwayatPageCounter.Click += new System.EventHandler(this.DGVRiwayatPageCounter_Click);
            // 
            // btnAuthor
            // 
            this.btnAuthor.Location = new System.Drawing.Point(765, 535);
            this.btnAuthor.Name = "btnAuthor";
            this.btnAuthor.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(109)))), ((int)(((byte)(84)))));
            this.btnAuthor.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnAuthor.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnAuthor.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnAuthor.Palette = this.pPalette;
            this.btnAuthor.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnAuthor.Size = new System.Drawing.Size(27, 27);
            this.btnAuthor.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(146)))), ((int)(((byte)(113)))));
            this.btnAuthor.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnAuthor.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnAuthor.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnAuthor.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnAuthor.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuthor.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.btnAuthor.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.btnAuthor.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAuthor.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(109)))), ((int)(((byte)(84)))));
            this.btnAuthor.TabIndex = 337;
            this.btnAuthor.Values.Text = "?";
            this.btnAuthor.Click += new System.EventHandler(this.BTNAuthor_Click);
            // 
            // FRiwayat
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 570);
            this.Controls.Add(this.btnAuthor);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.dgvRiwayatPageCounter);
            this.Controls.Add(this.dgvRiwayatPrev);
            this.Controls.Add(this.dgvPageCounter);
            this.Controls.Add(this.dgvRiwayatFirst);
            this.Controls.Add(this.dgvPrev);
            this.Controls.Add(this.dgvRiwayatNext);
            this.Controls.Add(this.dgvFirst);
            this.Controls.Add(this.dgvRiwayatLast);
            this.Controls.Add(this.dgvNext);
            this.Controls.Add(this.dgvLast);
            this.Controls.Add(this.dgvRiwayat);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRiwayat";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "FRiwayat";
            this.Load += new System.EventHandler(this.FRiwayat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRiwayat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal Krypton.Toolkit.KryptonLabel dgvPageCounter;
        internal Krypton.Toolkit.KryptonButton dgvPrev;
        internal Krypton.Toolkit.KryptonButton dgvFirst;
        internal Krypton.Toolkit.KryptonButton dgvNext;
        internal Krypton.Toolkit.KryptonButton dgvLast;
        internal Krypton.Toolkit.KryptonDataGridView dgvRiwayat;
        internal Krypton.Toolkit.KryptonDataGridView dgv;
        internal Krypton.Toolkit.KryptonButton dgvRiwayatLast;
        internal Krypton.Toolkit.KryptonButton dgvRiwayatNext;
        internal Krypton.Toolkit.KryptonButton dgvRiwayatFirst;
        internal Krypton.Toolkit.KryptonButton dgvRiwayatPrev;
        internal Krypton.Toolkit.KryptonLabel dgvRiwayatPageCounter;
        internal Krypton.Toolkit.KryptonPalette pPalette;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNoFaktur;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDibayar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSatuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn cQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHarga;
        internal Krypton.Toolkit.KryptonButton btnAuthor;
    }
}