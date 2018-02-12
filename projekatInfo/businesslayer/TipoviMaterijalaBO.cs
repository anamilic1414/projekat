using projekatInfo.datalayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekatInfo.businesslayer
{
    class TipoviMaterijalaBO:BaseBO
    {
        public TipoviMaterijalaBO():base()
        {
            this.PrimaryData = new TipoviMaterijalaTable(Program.DataSet); 
        }
    }
}
