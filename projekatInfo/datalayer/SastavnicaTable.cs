using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekatInfo.datalayer
{
    class SastavnicaTable:MyDataTable
    {
        public SastavnicaTable(MyDataSet DataSet) : base(DataSet, "sastavnica")
        {
        }

        public override void InitTable()
        {
            this.TableName = "sastavnica";
        }
    }
}
