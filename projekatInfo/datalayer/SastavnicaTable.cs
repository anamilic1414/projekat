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
        }

        public override string InitTable()
        {
            return TableName;
            //this.TableName = "sastavnica";
        }
    }
}
