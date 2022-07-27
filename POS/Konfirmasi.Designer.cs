namespace POS
{
    partial class Konfirmasi
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
            this.panelKonfirmasi = new Krypton.Toolkit.KryptonGroup();
            this.t1 = new Krypton.Toolkit.KryptonTextBox();
            this.pcIcon = new System.Windows.Forms.PictureBox();
            this.tDeskripsi = new Krypton.Toolkit.KryptonTextBox();
            this.btnYa = new Krypton.Toolkit.KryptonButton();
            this.lblTitle = new Krypton.Toolkit.KryptonLabel();
            this.btnTidak = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelKonfirmasi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelKonfirmasi.Panel)).BeginInit();
            this.panelKonfirmasi.Panel.SuspendLayout();
            this.panelKonfirmasi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelKonfirmasi
            // 
            this.panelKonfirmasi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelKonfirmasi.Location = new System.Drawing.Point(0, 0);
            this.panelKonfirmasi.Name = "panelKonfirmasi";
            // 
            // panelKonfirmasi.Panel
            // 
            this.panelKonfirmasi.Panel.Controls.Add(this.t1);
            this.panelKonfirmasi.Panel.Controls.Add(this.pcIcon);
            this.panelKonfirmasi.Panel.Controls.Add(this.tDeskripsi);
            this.panelKonfirmasi.Panel.Controls.Add(this.btnYa);
            this.panelKonfirmasi.Panel.Controls.Add(this.lblTitle);
            this.panelKonfirmasi.Panel.Controls.Add(this.btnTidak);
            this.panelKonfirmasi.Size = new System.Drawing.Size(450, 160);
            this.panelKonfirmasi.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.panelKonfirmasi.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.panelKonfirmasi.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(175)))), ((int)(((byte)(193)))));
            this.panelKonfirmasi.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.panelKonfirmasi.StateCommon.Border.Width = 3;
            this.panelKonfirmasi.TabIndex = 136;
            // 
            // t1
            // 
            this.t1.AlwaysActive = false;
            this.t1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.t1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.t1.CueHint.Color1 = System.Drawing.Color.Gray;
            this.t1.CueHint.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Italic);
            this.t1.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.t1.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.t1.Location = new System.Drawing.Point(65, 38);
            this.t1.MaxLength = 100;
            this.t1.Name = "t1";
            this.t1.PasswordChar = '●';
            this.t1.Size = new System.Drawing.Size(373, 29);
            this.t1.StateActive.Border.Color1 = System.Drawing.Color.Silver;
            this.t1.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.t1.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.t1.StateActive.Border.Rounding = 0F;
            this.t1.StateActive.Border.Width = 1;
            this.t1.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.t1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.t1.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.t1.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.t1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.t1.StateCommon.Border.Rounding = 0F;
            this.t1.StateCommon.Border.Width = 1;
            this.t1.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.t1.StateCommon.Content.Font = new System.Drawing.Font("Verdana", 13.75F);
            this.t1.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.t1.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.t1.StateDisabled.Border.Rounding = 0F;
            this.t1.StateDisabled.Border.Width = 0;
            this.t1.TabIndex = 0;
            this.t1.UseSystemPasswordChar = true;
            this.t1.Visible = false;
            this.t1.TextChanged += new System.EventHandler(this.T1_TextChanged);
            this.t1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputAngka);
            // 
            // pcIcon
            // 
            this.pcIcon.BackColor = System.Drawing.Color.White;
            this.pcIcon.Location = new System.Drawing.Point(10, 10);
            this.pcIcon.Name = "pcIcon";
            this.pcIcon.Size = new System.Drawing.Size(48, 48);
            this.pcIcon.TabIndex = 128;
            this.pcIcon.TabStop = false;
            // 
            // tDeskripsi
            // 
            this.tDeskripsi.AlwaysActive = false;
            this.tDeskripsi.Enabled = false;
            this.tDeskripsi.Location = new System.Drawing.Point(65, 38);
            this.tDeskripsi.MaxLength = 255;
            this.tDeskripsi.Multiline = true;
            this.tDeskripsi.Name = "tDeskripsi";
            this.tDeskripsi.Size = new System.Drawing.Size(376, 72);
            this.tDeskripsi.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tDeskripsi.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.tDeskripsi.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(145)))));
            this.tDeskripsi.StateCommon.Content.Font = new System.Drawing.Font("Trebuchet MS", 12.5F, System.Drawing.FontStyle.Bold);
            this.tDeskripsi.TabIndex = 4;
            this.tDeskripsi.Text = ".";
            // 
            // btnYa
            // 
            this.btnYa.Location = new System.Drawing.Point(194, 121);
            this.btnYa.Name = "btnYa";
            this.btnYa.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(175)))), ((int)(((byte)(193)))));
            this.btnYa.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnYa.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnYa.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnYa.Size = new System.Drawing.Size(119, 27);
            this.btnYa.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(195)))), ((int)(((byte)(209)))));
            this.btnYa.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnYa.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnYa.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnYa.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnYa.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Gadugi", 12F);
            this.btnYa.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.btnYa.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.btnYa.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnYa.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(175)))), ((int)(((byte)(193)))));
            this.btnYa.TabIndex = 2;
            this.btnYa.Values.Text = "Ya";
            this.btnYa.Click += new System.EventHandler(this.BTNYa_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(62, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(18, 24);
            this.lblTitle.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            this.lblTitle.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblTitle.StateCommon.ShortText.Font = new System.Drawing.Font("Trebuchet MS", 12.5F, System.Drawing.FontStyle.Bold);
            this.lblTitle.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Values.Text = "-";
            // 
            // btnTidak
            // 
            this.btnTidak.Location = new System.Drawing.Point(319, 121);
            this.btnTidak.Name = "btnTidak";
            this.btnTidak.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(175)))), ((int)(((byte)(193)))));
            this.btnTidak.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnTidak.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnTidak.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnTidak.Size = new System.Drawing.Size(119, 27);
            this.btnTidak.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(195)))), ((int)(((byte)(209)))));
            this.btnTidak.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnTidak.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnTidak.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.btnTidak.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnTidak.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Gadugi", 12F);
            this.btnTidak.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.btnTidak.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.btnTidak.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnTidak.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(175)))), ((int)(((byte)(193)))));
            this.btnTidak.TabIndex = 3;
            this.btnTidak.Values.Text = "Tidak";
            this.btnTidak.Click += new System.EventHandler(this.BTNTidak_Click);
            // 
            // Konfirmasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 160);
            this.Controls.Add(this.panelKonfirmasi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Konfirmasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Konfirmasi";
            ((System.ComponentModel.ISupportInitialize)(this.panelKonfirmasi.Panel)).EndInit();
            this.panelKonfirmasi.Panel.ResumeLayout(false);
            this.panelKonfirmasi.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelKonfirmasi)).EndInit();
            this.panelKonfirmasi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal Krypton.Toolkit.KryptonGroup panelKonfirmasi;
        internal Krypton.Toolkit.KryptonTextBox t1;
        internal System.Windows.Forms.PictureBox pcIcon;
        internal Krypton.Toolkit.KryptonTextBox tDeskripsi;
        internal Krypton.Toolkit.KryptonButton btnYa;
        internal Krypton.Toolkit.KryptonLabel lblTitle;
        internal Krypton.Toolkit.KryptonButton btnTidak;
    }
}