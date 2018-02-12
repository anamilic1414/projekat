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
            

            DataSet.Relations.Add("VezaMaterijalTipovi", tipoviMaterijalaTable.Columns["id"], this.Columns["idTipMaterijala"]);
            this.Columns.Add("nazivTipaMaterijala", typeof(string));
            
            this.Columns["nazivTipaMaterijala"].Expression = "parent.naziv";
            
        }
        public MaterijalTable(MyDataSet DataSet) : this(DataSet,"")
        {

        }

        

        public override void InitTable()
        {
                //this.TableName = "materijal";   
        }
    }
}
