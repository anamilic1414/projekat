using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekatInfo.datalayer
{
    class MyDataSet:DataSet
    {
        MaterijalTable materijalTable;
        SastavnicaTable sastavnicaTable;
        public SQLiteConnection konekcija;
        public MyDataSet(SQLiteConnection konekcija) :base()
        {
            this.konekcija = konekcija;
            materijalTable = new MaterijalTable(this);
            sastavnicaTable = new SastavnicaTable(this);
            this.Tables.Add(materijalTable);
            this.Tables.Add(sastavnicaTable);

            // Create Relation 
            this.Relations.Add("VezaMaterijalSastavnica",
                materijalTable.Columns["id"], sastavnicaTable.Columns["parentId"]);
            //materijalTable.Columns["nazivPodTipa"].Expression = "sastavnica.parentId";
        }
    }
}
