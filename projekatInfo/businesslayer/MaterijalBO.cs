using projekatInfo.datalayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekatInfo.businesslayer
{
    class MaterijalBO:BaseBO
    {
        TipoviMaterijalaTable tipoviMaterijalaTable;
        public MaterijalBO():base()
        {
            tipoviMaterijalaTable = (TipoviMaterijalaTable)DataTableFactory.GetDataTable("TipoviMaterijalaTable","tipoviMaterijala");
            this.PrimaryData = DataTableFactory.GetDataTable("MaterijalTable", "materijal");
            this.SecondaryData = DataTableFactory.GetDataTable("SastavnicaTable", "sastavnica");
            
        }
    }
}
