using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekatInfo.datalayer
{
    class PorudzbinaTable:MyDataTable
    {
        public new static string TableName = "porudzbinaZg";
        public PorudzbinaTable(MyDataSet DataSet, string tableName):base(DataSet, tableName)
        {
        }

        public PorudzbinaTable(MyDataSet DataSet) : base(DataSet, "")
        {
        }

        public override string InitTable()
        {
            return TableName;
        }
    }
}
