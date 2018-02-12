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
        public MaterijalBO():base()
        {
            this.PrimaryData = new MaterijalTable(Program.DataSet);
            this.SecondaryData = new SastavnicaTable(Program.DataSet);
        }
    }
}
