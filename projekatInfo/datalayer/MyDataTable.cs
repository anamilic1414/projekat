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
    abstract class MyDataTable:DataTable
    {
      
        public MyDataSet DataSet;
        SQLiteDataAdapter adp;
        SQLiteCommandBuilder cmb;

        public abstract void InitTable();

        public MyDataTable(MyDataSet DataSet, string tableName):base()
        {
            
            this.DataSet = DataSet;
            this.TableName = tableName;
            //this.DataSet.Tables.Add(this.TableName,this);
            string query = "select * from "+ this.TableName;
            SQLiteCommand command = Program.konekcija.CreateCommand();
           /* command.CommandText = query;
            command.ExecuteNonQuery();*/
            adp = new SQLiteDataAdapter(query, Program.konekcija);
            adp.Fill(this);
        }

        public void Update()
        {
           cmb = new SQLiteCommandBuilder(adp);
            adp.Update(this);
            MessageBox.Show("Updated");

        }
       

    }
}
