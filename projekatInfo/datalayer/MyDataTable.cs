using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekatInfo.datalayer
{
    public abstract class MyDataTable:DataTable
    {
      
        public MyDataSet DataSet;
        SQLiteDataAdapter adp;
        SQLiteCommandBuilder cmb;
        public static string TableName;
        public static string GetTableName()
        {
            return TableName;
        }
        public abstract string InitTable();

        public MyDataTable(MyDataSet DataSet) : this(DataSet, "")
        {
        }

        public MyDataTable(MyDataSet DataSet, string tableName):base()
        {
            if(tableName == "")
            {
                TableName = InitTable();
            }
            else
            {
                TableName = tableName;
            }
            this.DataSet = DataSet;
           
            if(TableName == string.Empty)
            {
                throw new Exception("Naziv tabele ne moze biti prazan");
            }
            //factory patern sadrzi sve ostale klase i daje ti odredjenu
            //kod filtriranja mora da se menja ime, jer svaka je karakteristicna

                this.DataSet.Tables.Add(this);
            
                string query = "select * from " + TableName;
                SQLiteCommand command = Program.konekcija.CreateCommand();
                /* command.CommandText = query;
                 command.ExecuteNonQuery();*/
                adp = new SQLiteDataAdapter(query, Program.konekcija);
                adp.Fill(this);
        }
    
        /// <summary>
        /// metod gettable koji vraca iz dataset
        /// </summary>
        
            public static void getTable()
        {

        }

        public void Update()
        {
           cmb = new SQLiteCommandBuilder(adp);
            adp.Update(this);
            MessageBox.Show("Updated");

        }
       

    }
}
