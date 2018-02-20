using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
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
          
            
            
            
           string query = "select * from " + TableName;
           SQLiteCommand command = Program.konekcija.CreateCommand();
                /* command.CommandText = query;
                 command.ExecuteNonQuery();*/
            adp = new SQLiteDataAdapter(query, Program.konekcija);
            DataTableMapping dataMapping = adp.TableMappings.Add(TableName, TableName);
            this.DataSet.Tables.Add(this);
            adp.Fill(this);
            //adp.Update(DataSet);
           
        }

        //sve crud metode da rade 
        //acceptchanges
        public void Update()
        {
            //ovo radi za apdate, insert i delete
            this.cmb = new SQLiteCommandBuilder(this.adp);
            adp.UpdateCommand = cmb.GetUpdateCommand();
            this.adp.Update(this);
            this.DataSet.AcceptChanges();

            MessageBox.Show("Updated");
            //messageBox ne sme ovde
        }
        public void Insert(string idPor, string tipMat, string idMat, string kolicina)
        {
            if(idPor=="" || tipMat=="" || idMat=="" || kolicina == "")
            {
                MessageBox.Show("Morate uneti sva polja!");
                return;
            }
            this.cmb = new SQLiteCommandBuilder(this.adp);
            /*adp.InsertCommand = cmb.GetInsertCommand();*/
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = Program.konekcija;//SQLite connection
            cmd = cmb.GetInsertCommand();
            SQLiteParameter p1 = new SQLiteParameter("@param1", idPor);
            SQLiteParameter p2 = new SQLiteParameter("@param2", tipMat);
            SQLiteParameter p3 = new SQLiteParameter("@param3", idMat);
            SQLiteParameter p4 = new SQLiteParameter("@param4", kolicina);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.ExecuteNonQuery();
            this.adp.Update(this);
            this.DataSet.AcceptChanges();
        }
        public void Delete(string id)
        {
            this.cmb = new SQLiteCommandBuilder(this.adp);
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = Program.konekcija;//SQLite connection
            cmd.CommandText = "delete from "+TableName+ " where id=" + id;
            cmd.ExecuteNonQuery();
            this.adp.Update(this);
            this.DataSet.AcceptChanges();
        }
        public string IzracunajCenu(string id)
        {
            string result = "";
            this.cmb = new SQLiteCommandBuilder(this.adp);
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = Program.konekcija;
            cmd.CommandText = "select cena from materijal where id=" + id;
            result = cmd.ExecuteScalar().ToString();
            return result;
        }
    }
}
