using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekatInfo.datalayer
{
    class SastavnicaTable:MyDataTable
    {
        public new static string TableName = "sastavnica";
        public SastavnicaTable(MyDataSet DataSet) : this(DataSet,"")
        {
        }

        public SastavnicaTable(MyDataSet DataSet, string tableName) : base(DataSet, tableName)
        {
            MyDataTable materijalTable = DataTableFactory.GetDataTable("MaterijalTable", "materijal");
            DataSet.Relations.Add("VezaMaterijalSastavnica", materijalTable.Columns["id"], this.Columns["parentId"]);
            this.Columns.Add("nazivNadTipa", typeof(string));
            this.Columns["nazivNadTipa"].Expression = "parent.naziv";

            DataSet.Relations.Add("DrugaVezaMaterijalSastavnica", materijalTable.Columns["id"], this.Columns["idMat"]);
            this.Columns.Add("nazivMat", typeof(string));
            this.Columns["nazivMat"].Expression = "parent(DrugaVezaMaterijalSastavnica).naziv";
        }

        public override string InitTable()
        {
            return TableName;
            //this.TableName = "sastavnica";
        }
    }
}
