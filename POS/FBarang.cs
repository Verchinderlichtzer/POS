using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace POS
{
    public partial class FBarang : Form
    {
        bool dataBaru;
        string namaBarang;
        int harga;

        public FBarang()
        {
            InitializeComponent();
        }

        #region Form
        void Notis()
        {
            dataBaru = true;
            tID.Text = 1.ToString();
            int x = 0;
            Ly.QRL("SELECT IdBarang FROM Barang ORDER BY IdBarang");
            while (Ly.dr.Read())
            {
                x++;
                if (Ly.dr.HasRows)
                {
                    if ((int)Ly.dr[0] == x)
                    {
                        tID.Text = (x + 1).ToString();
                    }
                    else
                    {
                        tID.Text = x.ToString();
                        return;
                    }
                }
            }
        }

        void Clear()
        {
            Notis();
            tNama.Clear();
            tSatuan.Clear();
            tHarga.Clear();
            tBarcode.Clear();
            TampilDGV();
            tCariData.Clear();
            tNama.Focus();
        }

        void FBarang_Load(object sender, EventArgs e)
        {
            Clear();
        }

        void InputAngka(object sender, KeyPressEventArgs e)
        {
            KryptonTextBox s = (KryptonTextBox)sender;
            if (s.Text?.Length == 0 && e.KeyChar == 48) e.Handled = true;
            Ly.Numbers(sender, e);
        }

        void Validasi(object sender, EventArgs e)
        {
            if (tHarga.Text.Length == 1 && Convert.ToInt32(tHarga.Text) == 0) { tHarga.Text = String.Empty; }
            int.TryParse(tHarga.Text, out harga);
            btnSave.Enabled = !string.IsNullOrEmpty(tNama.Text) && harga > 0;
        }

        void CariID()
        {
            Ly.QR("SELECT * FROM Barang WHERE IdBarang = " + Convert.ToInt32(tID.Text));
        }
        #endregion

        #region CRUD
        void BTNSave_Click(object sender, EventArgs e)
        {
            Ly.QR("SELECT Barcode FROM Barang WHERE Barcode = '" + tBarcode.Text + "' AND NOT IdBarang = " + Convert.ToInt32(tID.Text));
            if (dataBaru && !(!string.IsNullOrEmpty(tBarcode.Text) && Ly.dr.HasRows))
            {
                Ly.QN("INSERT INTO Barang VALUES(" + Convert.ToInt32(tID.Text) + ",'" + tBarcode.Text + "','" + tNama.Text + "','" + tSatuan.Text + "'," + harga + ")");
                Ly.Pesan("Barang berhasil ditambah", Notifikasi.Jenis.Berhasil);
            }
            else if (!(!string.IsNullOrEmpty(tBarcode.Text) && Ly.dr.HasRows))
            {
                Ly.QN("UPDATE Barang SET Barcode = '" + tBarcode.Text + "', Nama = '" + tNama.Text + "', Satuan = '" + tSatuan.Text + "', Harga = " + harga + " WHERE IdBarang = " + Convert.ToInt32(tID.Text));
                Ly.Pesan("Barang berhasil diubah", Notifikasi.Jenis.Berhasil);
            }
            else
            {
                Ly.Pesan("Barcode sudah terdaftar", Notifikasi.Jenis.Gagal);
                return;
            }
            Clear();
        }

        void BTNDelete_Click(object sender, EventArgs e)
        {
            Ly.QR("SELECT IdBarang FROM DetailTransaksi WHERE IdBarang = " + Convert.ToInt32(tID.Text));
            if (Ly.dr.HasRows)
            {
                Ly.Pesan("Barang pernah terlibat dalam transaksi", Notifikasi.Jenis.Gagal);
                return;
            }
            if (dataBaru)
            {
                Ly.Pesan("ID Barang tidak valid", Notifikasi.Jenis.Gagal);
            }
            else
            {
                var konfirmasi = new Konfirmasi("Konfirmasi Hapus", "Hapus " + namaBarang + "?", 0);
                if (konfirmasi.ShowDialog() == DialogResult.Yes)
                {
                    Ly.QN("DELETE FROM Barang WHERE IdBarang = " + Convert.ToInt32(tID.Text));
                    Ly.Pesan("Barang berhasil dihapus", Notifikasi.Jenis.Berhasil);
                    Clear();
                }
            }
        }

        void BTNClear_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            Clear();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys koentji)
        {
            if (koentji == Keys.Enter)
            {
                btnSave.PerformClick();
                return true;
            }
            else if (koentji == Keys.Escape)
            {
                btnDelete.PerformClick();
                return true;
            }
            else if (koentji == Keys.Oemtilde)
            {
                btnClear.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, koentji);
        }
        #endregion

        #region DGV
        readonly List<Barang> rows = new List<Barang>();
        int currentPage = 1;
        const int maxRows = 15;
        void Paging()
        {
            dgv.Rows.Clear();
            dgvPageCounter.Text = currentPage + " / " + (rows.Count <= maxRows ? 1 : Math.Ceiling(rows.Count / (double)maxRows));
            if (currentPage == 1)
            {
                dgvPrev.Enabled = false;
                dgvFirst.Enabled = false;
            }
            else
            {
                dgvPrev.Enabled = true;
                dgvFirst.Enabled = true;
            }
            if (currentPage >= Math.Ceiling(rows.Count / (double)maxRows))
            {
                dgvNext.Enabled = false;
                dgvLast.Enabled = false;
            }
            else
            {
                dgvNext.Enabled = true;
                dgvLast.Enabled = true;
            }
            if (rows.Count == 0) return;
            if (rows.Count % maxRows == 0 && currentPage > 1 && currentPage > Math.Ceiling(rows.Count / (double)maxRows)) dgvPrev.PerformClick();
            int i = 0;
            i += (currentPage - 1) * maxRows;
            foreach (Barang x in rows.Skip((currentPage - 1) * maxRows).Take(maxRows)) dgv.Rows.Add(++i, x.IdBarang, x.Nama, x.Satuan, x.Harga);
        }

        void TampilDGV()
        {
            rows.Clear();
            Ly.QRL("SELECT IdBarang, Nama, Satuan, Harga FROM Barang WHERE Barcode LIKE '%" + tCariData.Text + "%' OR Nama LIKE '%" + tCariData.Text + "%' OR Satuan LIKE '%" + tCariData.Text + "%' ORDER BY Nama");
            while (Ly.dr.Read()) rows.Add(new Barang { IdBarang = (int)Ly.dr[0], Nama = (string)Ly.dr[1], Satuan = (string)Ly.dr[2], Harga = (int)Ly.dr[3] });
            Paging();
        }

        void TCariData_TextChanged(object sender, EventArgs e)
        {
            currentPage = 1;
            TampilDGV();
        }

        void DGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            dataBaru = false;
            tID.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            CariID();
            tBarcode.Text = Ly.dr[1].ToString();
            namaBarang = Ly.dr[2].ToString();
            tNama.Text = Ly.dr[2].ToString();
            tSatuan.Text = Ly.dr[3].ToString();
            tHarga.Text = Ly.dr[4].ToString();
        }

        void DGVFirst_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            Paging();
        }

        void DGVPrev_Click(object sender, EventArgs e)
        {
            currentPage--;
            Paging();
        }

        void DGVPageCounter_Click(object sender, EventArgs e)
        {
            if (Math.Ceiling(rows.Count / (double)maxRows) <= 1d) return;
            Ly.GoToPageNumber(rows.Count, maxRows, ref currentPage);
            Paging();
        }

        void DGVNext_Click(object sender, EventArgs e)
        {
            currentPage++;
            Paging();
        }

        void DGVLast_Click(object sender, EventArgs e)
        {
            currentPage = (int)Math.Ceiling(rows.Count / (double)maxRows);
            Paging();
        }
        #endregion
    }
}
