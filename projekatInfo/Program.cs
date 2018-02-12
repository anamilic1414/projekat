using projekatInfo.datalayer;
using projekatInfo.userlayer;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekatInfo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static SQLiteConnection konekcija;
        public static MyDataSet DataSet;

        [STAThread]
        static void Main()
        {
           

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            konekcija = new SQLiteConnection("Data Source=projekat.db;Version=3;New=False;Compress=True;");
            DataSet = new MyDataSet(konekcija);
            konekcija.Open();
            Application.Run(new FrmMaterijalSastavnica());
        }
    }
}
