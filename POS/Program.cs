using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace POS
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Ly.Koneksi();
            var id = new CultureInfo("id-ID");
            CultureInfo.DefaultThreadCurrentCulture = id;
            CultureInfo.DefaultThreadCurrentUICulture = id;
            Application.Run(new FMain());
        }
    }
}
