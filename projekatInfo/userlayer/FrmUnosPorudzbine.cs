using projekatInfo.businesslayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekatInfo.userlayer
{
    public partial class FrmUnosPorudzbine : Form
    {
        PorudzbinaBO porudzbinaBO;
        public FrmUnosPorudzbine()
        {
            InitializeComponent();
        }

        private void FrmUnosPorudzbine_Load(object sender, EventArgs e)
        {
            porudzbinaBO = new PorudzbinaBO();
            
            dataGrid1.DataSource = porudzbinaBO.SecondaryData;
            porudzbinaBO.SecondaryData.Clear(); //da mi prikaze praznu tabelu
            //mogu da smanjim broj kolona koje se prikazuju
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {

            SQLiteCommand insertSQL = new SQLiteCommand("INSERT INTO porudzbinaZg (datum, kupac, datumIsporuke, primalacPorudzbine) VALUES (@datumPrijema,@kupac,@datumIsporuke,@primalac)", Program.konekcija);
            insertSQL.Parameters.Add(new SQLiteParameter("@datumPrijema", DbType.Date, datePrijem.Text));
            insertSQL.Parameters.Add(new SQLiteParameter("@kupac",txtKupac.Text));
            insertSQL.Parameters.Add(new SQLiteParameter("@datumIsporuke", DbType.Date, dateIsporuka.Text));
            insertSQL.Parameters.Add(new SQLiteParameter("@primalac", txtPrimalac.Text));
           
            try
            {
                insertSQL.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            try
            {
                porudzbinaBO.SecondaryData.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }
    }
}
