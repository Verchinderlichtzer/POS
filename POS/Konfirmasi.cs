using System;
using System.Drawing;
using System.Windows.Forms;

namespace POS
{
    public partial class Konfirmasi : Form
    {
        public enum Jenis
        {
            Noticement,
            Goto
        }

        int t1Value;
        int maxPages;
        Jenis jns;

        public Konfirmasi(string judul, string deskripsi, int gambar, Jenis jenis = Jenis.Noticement)
        {
            InitializeComponent();
            jns = jenis;
            lblTitle.Text = judul;
            tDeskripsi.Text = deskripsi;
            if (gambar == 0)
            {
                pcIcon.Image = new Bitmap(Properties.Resources.question_biru);
            }
            else if (gambar == 1)
            {
                pcIcon.Image = new Bitmap(Properties.Resources.exclamation_biru);
            }
            if (jenis == Jenis.Goto) // Goto Page
            {
                t1.UseSystemPasswordChar = false;
                t1.PasswordChar = '\0';
                btnYa.Text = "Ok";
                btnTidak.Text = "Batal";
                t1.Visible = true;
                t1.Focus();
            }
        }

        private void InputAngka(object sender, KeyPressEventArgs e)
        {
            if (t1.SelectionStart == 0 && e.KeyChar == 48)
            {
                e.Handled = true;
                Ly.Numbers(sender, e);
            }
        }

        private void T1_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(t1.Text, out t1Value);
            int.TryParse(lblTitle.Text.Substring(lblTitle.Text.LastIndexOf(" ") + 1), out maxPages);
            if (jns == Jenis.Goto && t1Value > maxPages)
            {
                t1.Text = maxPages.ToString();
                t1.SelectionStart = t1.Text.Length;
            }
        }

        private void BTNYa_Click(object sender, EventArgs e)
        {
            int.TryParse(t1.Text, out int x);
            if (jns == Jenis.Goto) Ly.halamanTerpilih = x;
            DialogResult = DialogResult.Yes;
        }

        private void BTNTidak_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        protected override bool ProcessCmdKey(ref Message Msg, Keys Koentji)
        {
            if (Koentji == Keys.Enter)
            {
                btnYa.PerformClick();
                return true;
            }
            else if (Koentji == Keys.Escape)
            {
                btnTidak.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref Msg, Koentji);
        }
    }
}
