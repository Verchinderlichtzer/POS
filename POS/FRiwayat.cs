using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace POS
{
    public partial class FRiwayat : Form
    {
        public FRiwayat()
        {
            InitializeComponent();
        }

        #region Form
        void FRiwayat_Load(object sender, EventArgs e)
        {
            TampilDGVRiwayat();
        }
        #endregion

        #region DGV Riwayat
        readonly List<Riwayat> rowsRiwayat = new List<Riwayat>();
        int currentPageRiwayat = 1;
        const int maxRowsRiwayat = 18;
        void PagingRiwayat()
        {
            dgvRiwayat.Rows.Clear();
            dgvRiwayatPageCounter.Text = currentPageRiwayat + " / " + (rowsRiwayat.Count <= maxRowsRiwayat ? 1 : Math.Ceiling(rowsRiwayat.Count / (double)maxRowsRiwayat));
            if (currentPageRiwayat == 1)
            {
                dgvRiwayatPrev.Enabled = false;
                dgvRiwayatFirst.Enabled = false;
            }
            else
            {
                dgvRiwayatPrev.Enabled = true;
                dgvRiwayatFirst.Enabled = true;
            }
            if (currentPageRiwayat >= Math.Ceiling(rowsRiwayat.Count / (double)maxRowsRiwayat))
            {
                dgvRiwayatNext.Enabled = false;
                dgvRiwayatLast.Enabled = false;
            }
            else
            {
                dgvRiwayatNext.Enabled = true;
                dgvRiwayatLast.Enabled = true;
            }
            if (rowsRiwayat.Count == 0) return;
            if (rowsRiwayat.Count % maxRowsRiwayat == 0 && currentPageRiwayat > 1 && currentPageRiwayat > Math.Ceiling(rowsRiwayat.Count / (double)maxRowsRiwayat)) dgvRiwayatPrev.PerformClick();
            foreach (Riwayat x in rowsRiwayat.Skip((currentPageRiwayat - 1) * maxRowsRiwayat).Take(maxRowsRiwayat)) dgvRiwayat.Rows.Add(x.NoFaktur, x.Tanggal, x.Total, x.Dibayar);
        }

        void TampilDGVRiwayat()
        {
            rowsRiwayat.Clear();
            Ly.QRL("SELECT * FROM Transaksi ORDER BY NoFaktur DESC");
            while (Ly.dr.Read()) rowsRiwayat.Add(new Riwayat { NoFaktur = (int)Ly.dr[0], Tanggal = (DateTime)Ly.dr[1], Total = (int)Ly.dr[2], Dibayar = (int)Ly.dr[3] });
            PagingRiwayat();
        }

        private void DGVRiwayat_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            rows.Clear();
            Ly.QRL("SELECT DetailTransaksi.IdBarang, Nama, Satuan, Qty, DetailTransaksi.Harga FROM Barang INNER JOIN DetailTransaksi ON Barang.IdBarang = DetailTransaksi.IdBarang WHERE NoFaktur = " + Convert.ToInt32(dgvRiwayat.Rows[e.RowIndex].Cells[0].Value));
            while (Ly.dr.Read()) rows.Add(new Transaksi { IdBarang = (int)Ly.dr[0], Nama = (string)Ly.dr[1], Satuan = (string)Ly.dr[2], Qty = Convert.ToDouble(Ly.dr[3]), Harga = Convert.ToDouble(Ly.dr[4]) });
            Paging();
        }

        void DGVRiwayatFirst_Click(object sender, EventArgs e)
        {
            currentPageRiwayat = 1;
            PagingRiwayat();
        }

        void DGVRiwayatPrev_Click(object sender, EventArgs e)
        {
            currentPageRiwayat--;
            PagingRiwayat();
        }

        void DGVRiwayatPageCounter_Click(object sender, EventArgs e)
        {
            if (Math.Ceiling(rowsRiwayat.Count / (double)maxRowsRiwayat) <= 1) return;
            Ly.GoToPageNumber(rowsRiwayat.Count, maxRowsRiwayat, ref currentPageRiwayat);
            PagingRiwayat();
        }

        void DGVRiwayatNext_Click(object sender, EventArgs e)
        {
            currentPageRiwayat++;
            PagingRiwayat();
        }

        void DGVRiwayatLast_Click(object sender, EventArgs e)
        {
            currentPageRiwayat = (int)Math.Ceiling(rowsRiwayat.Count / (double)maxRowsRiwayat);
            PagingRiwayat();
        }
        #endregion

        #region DGV
        readonly List<Transaksi> rows = new List<Transaksi>();
        int currentPage = 1;
        const int maxRows = 18;
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
            foreach (Transaksi x in rows.Skip((currentPage - 1) * maxRows).Take(maxRows)) dgv.Rows.Add(++i, x.Nama, x.Satuan, x.Qty, x.Harga);
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

        private void BTNAuthor_Click(object sender, EventArgs e)
        {
            Process.Start("https://api.whatsapp.com/send?phone=6285739194810");
        }
    }
}
