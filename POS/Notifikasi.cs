using System;
using System.Drawing;
using System.Windows.Forms;

namespace POS
{
    public partial class Notifikasi : Form
    {
        private int x, y;

        public Notifikasi()
        {
            InitializeComponent();
        }

        public enum Jenis
        {
            Gagal,
            Berhasil
        }

        public void SetAlert(string msg, Jenis type)
        {
            Opacity = 0d;
            StartPosition = FormStartPosition.Manual;
            const string fname = "Peringatan";
            Notifikasi f = (Notifikasi)Application.OpenForms[fname];
            if (f is null)
            {
                Name = fname;
                x = Screen.PrimaryScreen.WorkingArea.Width - Width + 15;
                y = Screen.PrimaryScreen.WorkingArea.Height - Height - 5;
                Location = new Point(x, y);
            }
            x = Screen.PrimaryScreen.WorkingArea.Width - Width - 5;
            switch (type)
            {
                case Jenis.Berhasil:
                    {
                        notif.Values.Image = new Bitmap(Properties.Resources.berhasil_hijau);
                        notif.OverrideDefault.Border.Color1 = Color.FromArgb(108, 203, 120);
                        notif.StateCommon.Border.Color1 = Color.FromArgb(108, 203, 120);
                        notif.StateCommon.Content.ShortText.Color1 = Color.FromArgb(81, 152, 90);
                        break;
                    }
                case Jenis.Gagal:
                    {
                        notif.Values.Image = new Bitmap(Properties.Resources.gagal_merah);
                        notif.OverrideDefault.Border.Color1 = Color.FromArgb(254, 55, 83);
                        notif.StateCommon.Border.Color1 = Color.FromArgb(254, 55, 83);
                        notif.StateCommon.Content.ShortText.Color1 = Color.FromArgb(190, 41, 62);
                        break;
                    }
            }
            notif.Text = msg;
            TopMost = true;
            ShowIcon = false;
            ShowInTaskbar = false;
            Show();
            timer1.Interval = 1;
            timer1.Start();
        }

        public enum ActionEnum
        {
            Wait,
            Start,
            Close
        }

        private ActionEnum Action = ActionEnum.Start;

        private void Waktu(object sender, EventArgs e)
        {
            switch (Action)
            {
                case ActionEnum.Start:
                    {
                        timer1.Interval = 1;
                        Opacity += 0.1d;
                        if (x < Location.X)
                        {
                            Left--;
                        }
                        else if (Opacity == 1d)
                        {
                            Action = ActionEnum.Wait;
                        }
                        break;
                    }
                case ActionEnum.Wait:
                    {
                        timer1.Interval = 1300;
                        Action = ActionEnum.Close;
                        break;
                    }
                case ActionEnum.Close:
                    {
                        timer1.Interval = 1;
                        Opacity -= 0.1d;
                        Left -= 3;
                        if (Opacity == 0d) Close();
                        break;
                    }
            }
        }

        protected override bool ShowWithoutActivation
        {
            get { return true; }
        }
    }
}
