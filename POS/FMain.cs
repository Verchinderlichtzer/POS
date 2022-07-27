using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace POS
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }
        
        void FormTerpilih(Form ChildForm)
        {
            ChildForm.TopLevel = false;
            ChildForm.Dock = DockStyle.Fill;
            panelForm.Controls.Clear();
            panelForm.Controls.Add(ChildForm);
            panelForm.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        void Pilihan(object sender, EventArgs e)
        {
            foreach (KryptonCheckButton x in new object[] { btnBarang, btnTransaksi, btnRiwayat }) x.Checked = ReferenceEquals(x, sender);
            if (sender == btnBarang)
            {
                FormTerpilih(new FBarang());
            }
            else if (sender == btnTransaksi)
            {
                FormTerpilih(new FTransaksi());
            }
            else if (sender == btnRiwayat)
            {
                FormTerpilih(new FRiwayat());
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var CP = base.CreateParams;
                // CP.Style = &HA0000
                CP.ExStyle |= 0x2000000;
                return CP;
            }
        }

        void FMain_Load(object sender, EventArgs e)
        {
            btnBarang.PerformClick();
        }
    }
}