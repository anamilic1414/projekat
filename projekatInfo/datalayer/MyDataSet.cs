using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekatInfo.datalayer
{
    public class MyDataSet:DataSet
    {
        MaterijalTable materijalTable;
        SastavnicaTable sastavnicaTable;
        TipoviMaterijalaTable tipoviMaterijalaTable;
        public SQLiteConnection konekcija;
        public MyDataSet(SQLiteConnection konekcija) :base()
        {
            this.konekcija = konekcija;

           /* tipoviMaterijalaTable = new TipoviMaterijalaTable(this);
            sastavnicaTable = new SastavnicaTable(this);
            materijalTable = new MaterijalTable(this,"");*/
            
            /*this.Tables.Add(tipoviMaterijalaTable);
            this.Tables.Add(materijalTable);
            this.Tables.Add(sastavnicaTable);*/

            
           //this.Relations.Add("VezaMaterijalTipovi",materijalTable.Columns["idTipMaterijala"], tipoviMaterijalaTable.Columns["id"]);
            //materijalTable.Columns["nazivPodTipa"].Expression = "child.naziv";

            // Create Relation 
            /*this.Relations.Add("VezaMaterijalSastavnica",
                materijalTable.Columns["id"], sastavnicaTable.Columns["parentId"]);
            */
            //this.Tables(materijalTable.TableName).Columns.Add("Total", GetType(string), "child.naziv");
            //materijalTable.Columns["nazivPodTipa"].Expression = "parent(VezaMaterijalSastavnica).naziv";
            
        }
    }
}
