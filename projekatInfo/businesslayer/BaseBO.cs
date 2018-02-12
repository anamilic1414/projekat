using projekatInfo.datalayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekatInfo.businesslayer
{
    class BaseBO
    {
        private MyDataTable primaryData;
        public MyDataTable PrimaryData
        {
            get
            {
                return primaryData;
            }
            set
            {
                primaryData = value;
            }
        }
        protected MyDataTable secondaryData;
        public BaseBO()
        {
            
        }
        
    }
}
