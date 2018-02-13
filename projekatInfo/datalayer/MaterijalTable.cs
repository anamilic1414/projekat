using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekatInfo.datalayer
{
    class MaterijalTable:MyDataTable
    {
        public new static string TableName = "materijal";

        public MaterijalTable(MyDataSet DataSet, string tableName) : base(DataSet, tableName)
        {
            MyDataTable tipoviMaterijalaTable = DataTableFactory.GetDataTable("TipoviMaterijalaTable", "tipoviMaterijala");
            if (!DataSet.Relations.Contains("VezaMaterijalTipovi")) { 
                DataSet.Relations.Add("VezaMaterijalTipovi", tipoviMaterijalaTable.Columns["id"], this.Columns["idTipMaterijala"]);
            
            this.Columns.Add("nazivTipaMaterijala", typeof(string));
            this.Columns["nazivTipaMaterijala"].Expression = "parent.naziv";
            }
            /* MyDataTable sastavnicaTable = DataTableFactory.GetDataTable("SastavnicaTable", "sastavnica");
             DataSet.Relations.Add("VezaMaterijalSastavnica", this.Columns["id"], sastavnicaTable.Columns["parentId"]);
             sastavnicaTable.Columns.Add("nazivNadTipa", typeof(string));
             sastavnicaTable.Columns["nazivNadTipa"].Expression = "parent.naziv";*/

        }
        public MaterijalTable(MyDataSet DataSet) : this(DataSet,"")
        {

        }

        

        public override string InitTable()
        {
            return TableName;   
        }
    }
}
