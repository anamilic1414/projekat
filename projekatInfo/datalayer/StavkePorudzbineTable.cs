using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekatInfo.datalayer
{
    class StavkePorudzbineTable : MyDataTable
    {
        public new static string TableName = "porudzbinaSt";
        public StavkePorudzbineTable(MyDataSet DataSet, string tableName) : base(DataSet, tableName)
        {

        }
        public StavkePorudzbineTable(MyDataSet DataSet) : this(DataSet, "")
        {
        }
        public override string InitTable()
        {
            return TableName;
        }
    }
}
