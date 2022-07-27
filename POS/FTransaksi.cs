using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using USB_Barcode_Scanner;

namespace POS
{
    public partial class FTransaksi : Form
    {
        int noFaktur = 1;
        double total, dibayar, kembali;
        readonly PrintPreviewDialog ppd = new PrintPreviewDialog();

        public FTransaksi()
        {
            InitializeComponent();
            BarcodeScanner barcodeScanner = new BarcodeScanner(tCariData);
            barcodeScanner.BarcodeScanned += BCScanner_BarcodeScanned;
        }

        #region Form
        void Notis()
        {
            Ly.QR("SELECT NoFaktur FROM Transaksi ORDER BY NoFaktur DESC");
            if (Ly.dr.HasRows) noFaktur = Convert.ToInt32(Ly.dr[0]) + 1;
        }

        void Clear()
        {
            Notis();

            total = 0;
            dibayar = 0;
            kembali = 0;

            tCariData.Clear();
            TampilDGVBarang();

            rows.Clear();
            tDibayar.Clear();

            currentPage = 1;
            currentPageBarang = 1;
            Paging();
            PagingBarang();

            Hitung();
            tCariData.Focus();
        }

        void FTransaksi_Load(object sender, EventArgs e)
        {
            Clear();
        }

        void InputAngka(object sender, KeyPressEventArgs e)
        {
            KryptonTextBox s = (KryptonTextBox)sender;
            if (s.Text?.Length == 0 && e.KeyChar == 48) e.Handled = true;
            Ly.Numbers(sender, e);
        }

        void Hitung()
        {
            total = 0;
            foreach (Transaksi x in rows)
            {
                total += x.Qty * x.Harga;
            }
            if (total >= 1000000000)
            {
                Ly.Pesan("Melampaui batas (1 Milyar)", Notifikasi.Jenis.Gagal);
                return;
            }
            tTotal.Text = total.ToString("n0");
            double.TryParse(tDibayar.Text, out dibayar);
            kembali = Math.Abs(dibayar - total);
            lblKembali.Text = dibayar - total < 0 ? "Kurang" : "Kembali";
            tKembali.Text = kembali.ToString("n0");
        }
        #endregion

        #region Validasi
        void Validasi()
        {
            double.TryParse(tDibayar.Text, out dibayar);
            btnSave.Enabled = total > 0 && dibayar > total && total < 1000000000;
        }
        private void Valid(object sender, EventArgs e)
        {
            Hitung();
            Validasi();
        }
        #endregion

        #region CRUD
        void BTNSave_Click(object sender, EventArgs e)
        {
            Ly.QN("INSERT INTO Transaksi VALUES(" + noFaktur + ",DATE()," + total + "," + dibayar + ")");
            foreach (Transaksi x in rows)
            {
                Ly.QN("INSERT INTO DetailTransaksi VALUES(" + noFaktur + "," + x.IdBarang + "," + x.Qty.ToString().Replace(",", ".") + "," + x.Harga + ")");
            }
            var konfirmasi = new Konfirmasi("Cetak Struk", "Transaksi berhasil, cetak struknya?", 0);
            if (konfirmasi.ShowDialog() == DialogResult.Yes)
            {
                ppd.Document = pd;
                //ppd.ShowDialog();
                pd.Print();
            }
            Ly.Pesan("Transaksi berhasil", Notifikasi.Jenis.Berhasil);
            Clear();
            Ly.conn.Dispose();
            Ly.Koneksi();
        }

        void BTNClear_Click(object sender, EventArgs e)
        {
            currentPageBarang = 1;
            currentPage = 1;
            Clear();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys koentji)
        {
            if (koentji == Keys.Space && tCariData.Focused && tCariData.Text.Length == 0 && dgv.Rows.Count > 0)
            {
                dgv.CurrentCell = dgv.Rows[dgv.Rows.Count - 1].Cells[5];
                dgv.BeginEdit(true);
                return true;
            }
            else if (!tCariData.Focused && (koentji == Keys.Enter || koentji == Keys.Space))
            {
                tCariData.Clear();
                tCariData.Focus();
                return true;
            }
            return default;
        }
        #endregion

        #region DGV Barang
        readonly List<DaftarBarang> rowsBarang = new List<DaftarBarang>();
        int currentPageBarang = 1;
        const int maxRowsBarang = 16;
        void PagingBarang()
        {
            dgvBarang.Rows.Clear();
            dgvBarangPageCounter.Text = currentPageBarang + " / " + (rowsBarang.Count <= maxRowsBarang ? 1 : Math.Ceiling(rowsBarang.Count / (double)maxRowsBarang));
            if (currentPageBarang == 1)
            {
                dgvBarangPrev.Enabled = false;
                dgvBarangFirst.Enabled = false;
            }
            else
            {
                dgvBarangPrev.Enabled = true;
                dgvBarangFirst.Enabled = true;
            }
            if (currentPageBarang >= Math.Ceiling(rowsBarang.Count / (double)maxRowsBarang))
            {
                dgvBarangNext.Enabled = false;
                dgvBarangLast.Enabled = false;
            }
            else
            {
                dgvBarangNext.Enabled = true;
                dgvBarangLast.Enabled = true;
            }
            if (rowsBarang.Count == 0) return;
            if (rowsBarang.Count % maxRowsBarang == 0 && currentPageBarang > 1 && currentPageBarang > Math.Ceiling(rowsBarang.Count / (double)maxRowsBarang)) dgvBarangPrev.PerformClick();
            foreach (DaftarBarang x in rowsBarang.Skip((currentPageBarang - 1) * maxRowsBarang).Take(maxRowsBarang)) dgvBarang.Rows.Add(x.IdBarang, x.Barcode, x.Nama, x.Satuan, x.Harga, x.Daftar);
        }

        void TampilDGVBarang()
        {
            rowsBarang.Clear();
            Ly.QRL("SELECT IdBarang, Barcode, Nama, Satuan, Harga FROM Barang WHERE Barcode LIKE '%" + tCariData.Text + "%' OR Nama LIKE '%" + tCariData.Text + "%' OR Satuan LIKE '%" + tCariData.Text + "%' ORDER BY Nama");
            while (Ly.dr.Read()) rowsBarang.Add(new DaftarBarang { IdBarang = (int)Ly.dr[0], Barcode = (string)Ly.dr[1], Nama = (string)Ly.dr[2], Satuan = (string)Ly.dr[3], Harga = (int)Ly.dr[4], Daftar = Ly.dr[2] + " " + Ly.dr[3] });
            PagingBarang();
        }

        void TCariData_TextChanged(object sender, EventArgs e)
        {
            currentPageBarang = 1;
            TampilDGVBarang();
        }

        private void DGVBarang_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            foreach (Transaksi x in rows)
            {
                if (x.IdBarang == (int)dgvBarang.Rows[e.RowIndex].Cells[0].Value)
                {
                    Ly.Pesan("Barang sudah dipilih", Notifikasi.Jenis.Gagal);
                    return;
                }
            }
            rows.Add(new Transaksi { IdBarang = Convert.ToInt32(dgvBarang.Rows[e.RowIndex].Cells[0].Value), Barcode = (string)dgvBarang.Rows[e.RowIndex].Cells[1].Value, Nama = (string)dgvBarang.Rows[e.RowIndex].Cells[2].Value, Satuan = (string)dgvBarang.Rows[e.RowIndex].Cells[3].Value, Qty = 1, Harga = Convert.ToDouble(dgvBarang.Rows[e.RowIndex].Cells[4].Value) });
            Hitung();
            Paging();
            if (currentPage < Math.Ceiling(rows.Count / (double)maxRows)) dgvLast.PerformClick();
            Validasi();
            dgv.CurrentCell = dgv.Rows[dgv.Rows.Count - 1].Cells[5];
            dgv.BeginEdit(true);
        }

        private void BCScanner_BarcodeScanned(object sender, BarcodeScannerEventArgs e)
        {
            tCariData.Clear();
            foreach (Transaksi x in rows)
            {
                if (x.Barcode == e.Barcode)
                {
                    Ly.Pesan("Barang sudah terdaftar", Notifikasi.Jenis.Gagal);
                    return;
                }
            }
            Ly.QR("SELECT IdBarang, Barcode, Nama, Satuan, Harga FROM Barang WHERE Barcode = '" + e.Barcode + "'");
            if (!Ly.dr.HasRows)
            {
                Ly.Pesan("Barcode tidak terdaftar", Notifikasi.Jenis.Gagal);
                return;
            }
            rows.Add(new Transaksi { IdBarang = (int)Ly.dr[0], Barcode = (string)Ly.dr[1], Nama = (string)Ly.dr[2], Satuan = (string)Ly.dr[3], Qty = 1, Harga = Convert.ToDouble(Ly.dr[4]) });
            Hitung();
            Paging();
            if (currentPage < Math.Ceiling(rows.Count / (double)maxRowsBarang)) dgvLast.PerformClick();
            Validasi();
        }

        void DGVBarangFirst_Click(object sender, EventArgs e)
        {
            currentPageBarang = 1;
            PagingBarang();
        }

        void DGVBarangPrev_Click(object sender, EventArgs e)
        {
            currentPageBarang--;
            PagingBarang();
        }

        void DGVBarangPageCounter_Click(object sender, EventArgs e)
        {
            if (Math.Ceiling(rowsBarang.Count / (double)maxRowsBarang) <= 1) return;
            Ly.GoToPageNumber(rowsBarang.Count, maxRowsBarang, ref currentPageBarang);
            PagingBarang();
        }

        void DGVBarangNext_Click(object sender, EventArgs e)
        {
            currentPageBarang++;
            PagingBarang();
        }

        void DGVBarangLast_Click(object sender, EventArgs e)
        {
            currentPageBarang = (int)Math.Ceiling(rowsBarang.Count / (double)maxRowsBarang);
            PagingBarang();
        }
        #endregion

        #region DGV
        readonly List<Transaksi> rows = new List<Transaksi>();
        int currentPage = 1;
        const int maxRows = 17;
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
            foreach (Transaksi x in rows.Skip((currentPage - 1) * maxRows).Take(maxRows)) dgv.Rows.Add(++i, x.IdBarang, x.Barcode, x.Nama, x.Satuan, x.Qty, x.Harga);
        }

        private void DGV_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = (TextBox)e.Control;
            tb.KeyPress -= Ly.Decimals;
            tb.KeyPress -= Ly.Numbers;
            if (dgv.CurrentCell.ColumnIndex == 5) { tb.KeyPress += Ly.Decimals; } else { tb.KeyPress += Ly.Numbers; }
        }

        private void DGV_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.CurrentCell.Value is null || !double.TryParse(Convert.ToString(dgv.CurrentCell.Value.ToString().Replace(",", "")), out _) || Convert.ToInt32(dgv.CurrentCell.Value.ToString().Replace(",", "")) == 0) dgv.CurrentCell.Value = 1;
            double.TryParse(dgv.CurrentCell.Value.ToString(), out double hasil);
            if (e.ColumnIndex == 5)
            {
                rows[((currentPage - 1) * maxRows) + dgv.CurrentCellAddress.Y].Qty = hasil;
            }
            else if (e.ColumnIndex == 6)
            {
                dgv.Rows[e.RowIndex].Cells[6].Value = hasil.ToString("n0");
                rows[((currentPage - 1) * maxRows) + dgv.CurrentCellAddress.Y].Harga = hasil;
            }
            Hitung();
            Validasi();
        }

        private void DGV_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            dgv.CurrentCell.Value = dgv.CurrentCell.Value.ToString().Replace(".", "");
        }

        private void DGV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27) rows.RemoveAt(((currentPage - 1) * maxRows) + dgv.CurrentRow.Index);
            Hitung();
            Validasi();
            Paging();
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
            if (Math.Ceiling(rows.Count / (double)maxRows) <= 1) return;
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

        #region Struk
        private void PD_BeginPrint(object sender, PrintEventArgs e)
        {
            pd.DefaultPageSettings = new PageSettings
            {
                PaperSize = new PaperSize("Custom", 188, (rows.Count * 30) + 200)
            };
        }

        private void PD_PrintPage(object sender, PrintPageEventArgs e)
        {
            var f10 = new Font("Courier New", 8f, FontStyle.Regular);
            var f10b = new Font("Courier New", 8f, FontStyle.Bold);
            var f14b = new Font("Courier New", 10f, FontStyle.Bold);

            int centerMargin = (int)Math.Round(pd.DefaultPageSettings.PaperSize.Width / 2d);
            int rightMargin = pd.DefaultPageSettings.PaperSize.Width;

            var tengah = new StringFormat();
            var kanan = new StringFormat();
            tengah.Alignment = StringAlignment.Center;
            kanan.Alignment = StringAlignment.Far;

            const string garis = "------------------------------------";
            e.Graphics.DrawString("Nama Toko", f14b, Brushes.Black, centerMargin, 5f, tengah);
            e.Graphics.DrawString("Bumi Anggrek K 80", f10, Brushes.Black, centerMargin, 25f, tengah);
            e.Graphics.DrawString("HP : 085739194810", f10, Brushes.Black, centerMargin, 40f, tengah);

            e.Graphics.DrawString(DateTime.Now.ToString("dd/MM/yyyy HH:mm tt"), f10, Brushes.Black, 0f, 60f);
            e.Graphics.DrawString(garis, f10, Brushes.Black, centerMargin, 70f, tengah);

            int tinggi = 70;
            foreach (var x in rows)
            {
                tinggi += 15;
                e.Graphics.DrawString(x.Nama + " " + x.Satuan.Replace(" ", string.Empty), f10, Brushes.Black, 0f, tinggi);
                tinggi += 15;
                e.Graphics.DrawString(x.Qty.ToString(), f10, Brushes.Black, 8f, tinggi);
                e.Graphics.DrawString("x " + x.Harga.ToString("n0"), f10, Brushes.Black, 40f, tinggi);
                e.Graphics.DrawString((x.Qty * x.Harga).ToString("n0"), f10, Brushes.Black, rightMargin, tinggi, kanan);
            }
            tinggi += 15;
            e.Graphics.DrawString(garis, f10, Brushes.Black, centerMargin, tinggi, tengah);
            tinggi += 10;
            e.Graphics.DrawString("Total", f10b, Brushes.Black, 60f, tinggi);
            e.Graphics.DrawString(":", f10b, Brushes.Black, 110f, tinggi);
            e.Graphics.DrawString(total.ToString("n0"), f10b, Brushes.Black, rightMargin, tinggi, kanan);
            tinggi += 15;
            e.Graphics.DrawString("Dibayar", f10b, Brushes.Black, 60f, tinggi);
            e.Graphics.DrawString(":", f10b, Brushes.Black, 110f, tinggi);
            e.Graphics.DrawString(Convert.ToInt32(dibayar).ToString("n0"), f10b, Brushes.Black, rightMargin, tinggi, kanan);
            tinggi += 15;
            e.Graphics.DrawString("Kembali", f10b, Brushes.Black, 60f, tinggi);
            e.Graphics.DrawString(":", f10b, Brushes.Black, 110f, tinggi);
            e.Graphics.DrawString(Convert.ToInt32(kembali).ToString("n0"), f10b, Brushes.Black, rightMargin, tinggi, kanan);

            e.Graphics.DrawString("Terima kasih sudah", f10, Brushes.Black, centerMargin, tinggi + 20, tengah);
            e.Graphics.DrawString("berbelanja di toko kami", f10, Brushes.Black, centerMargin, tinggi + 35, tengah);
        }
        #endregion
    }
}
