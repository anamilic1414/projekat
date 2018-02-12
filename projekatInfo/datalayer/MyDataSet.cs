using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekatInfo.datalayer
{
    class MyDataSet:DataSet
    {
        public SQLiteConnection konekcija;
        public MyDataSet(SQLiteConnection konekcija) :base()
        {
            this.konekcija = konekcija;
        }
    }
}
