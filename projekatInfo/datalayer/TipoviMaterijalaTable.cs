using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekatInfo.datalayer
{
    class TipoviMaterijalaTable:MyDataTable
    {

        public TipoviMaterijalaTable(MyDataSet DataSet) : base(DataSet, "tipoviMaterijala")
        {
            
        }

        /*public override void InitTable()
        {
            this.TableName = "tipoviMaterijala";
        }*/
    }
}
