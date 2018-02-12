using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekatInfo.datalayer
{
    class MaterijalTable:MyDataTable
    {
        public MaterijalTable(MyDataSet DataSet) : base(DataSet, "materijal")
        {
            
        }

        public override void InitTable()
        {
            this.TableName = "materijal";
        }
    }
}
