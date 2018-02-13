using projekatInfo.datalayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekatInfo.businesslayer
{
    class PorudzbinaBO:BaseBO
    {
        public PorudzbinaBO():base()
        {
            this.PrimaryData = DataTableFactory.GetDataTable("PorudzbinaTable", "porudzbinaZg");
            this.SecondaryData = DataTableFactory.GetDataTable("StavkePorudzbineTable", "porudzbinaSt");
        }
    }
}
