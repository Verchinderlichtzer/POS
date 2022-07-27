using System;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

namespace POS
{
    static class Ly
    {
        public static OleDbConnection conn;
        public static OleDbCommand cmd;
        public static OleDbDataReader dr;
        public static OleDbDataAdapter da;
        public static DataSet ds;

        public static int halamanTerpilih;

        public static void Koneksi()
        {
            try
            {
                conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\pos.accdb;");
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
        }

        public static void QR(string queryReader)
        {
            try
            {
                cmd = new OleDbCommand(queryReader, conn);
                dr = cmd.ExecuteReader();
                dr.Read();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // Application.Restart()
            }
        }

        public static void QRL(string queryReaderLooping)
        {
            try
            {
                cmd = new OleDbCommand(queryReaderLooping, conn);
                dr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // Application.Restart()
            }
        }

        public static void QN(string queryNonReader)
        {
            try
            {
                cmd = new OleDbCommand(queryNonReader, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // Application.Restart()
            }
        }

        public static void QDGV(string queryDGV, DataGridView dataGrid, int startRecord, int maxRecord, string srcTable)
        {
            da = new OleDbDataAdapter(queryDGV, conn);
            ds = new DataSet();
            da.Fill(ds, startRecord, maxRecord, srcTable);
            dataGrid.DataSource = ds.Tables[0];
        }

        public static void Numbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        public static void Decimals(object sender, KeyPressEventArgs e) // Input Desimal dengan koma
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',')) e.Handled = true;
            if ((e.KeyChar == ',') && ((sender as TextBox)?.Text.IndexOf(',') > -1)) e.Handled = true;
        }

        public static void Pesan(string msg, Notifikasi.Jenis type)
        {
            if (!Application.OpenForms.OfType<Notifikasi>().Any())
            {
                var f = new Notifikasi();
                f.SetAlert(msg, type);
            }
        }

        public static void GoToPageNumber(int tb, double jb, ref int cp) // TotalBaris, JumlahBaris, CurrentPage
        {
            var Confirm = new Konfirmasi("Pilih antara halaman 1 ~ " + Math.Ceiling(tb / jb), "-", 0, Konfirmasi.Jenis.Goto);
            if (Confirm.ShowDialog() == DialogResult.Yes && halamanTerpilih != 0) cp = halamanTerpilih;
        }

        public static void Ukur(Krypton.Toolkit.KryptonDataGridView dg) // For Development
        {
            int totalPanjang = 0;
            string z = null;
            foreach (DataGridViewTextBoxColumn x in dg.Columns)
            {
                if (!x.Visible) continue;
                z += x.HeaderText + " = " + x.Width + "\r";
                totalPanjang += x.Width;
            }
            z += "\rTotal = " + totalPanjang + " / " + dg.Width + "\rSisa = " + (dg.Width - totalPanjang);
            MessageBox.Show(z);
        }
    }

    class Barang
    {
        public int IdBarang { get; set; }
        public string Nama { get; set; }
        public string Satuan { get; set; }
        public int Harga { get; set; }
    }

    class Transaksi
    {
        public int IdBarang { get; set; }
        public string Nama { get; set; }
        public string Barcode { get; set; }
        public string Satuan { get; set; }
        public double Qty { get; set; }
        public double Harga { get; set; }
    }

    class DaftarBarang
    {
        public int IdBarang { get; set; }
        public string Nama { get; set; }
        public string Barcode { get; set; }
        public string Satuan { get; set; }
        public int Harga { get; set; }
        public string Daftar { get; set; }
    }

    class Riwayat
    {
        public int NoFaktur { get; set; }
        public DateTime Tanggal { get; set; }
        public int Total { get; set; }
        public int Dibayar { get; set; }
    }
}