﻿using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekatInfo.datalayer
{
    class TipoviMaterijalaTable:MyDataTable
    {
        public new static string TableName = "tipoviMaterijala";
        public TipoviMaterijalaTable(MyDataSet DataSet) : this(DataSet,"")
        {
        }
        public TipoviMaterijalaTable(MyDataSet DataSet,string tableName) : base(DataSet, tableName)
        {
        }

        public override void InitTable()
        {
            //this.TableName = "tipoviMaterijala";
        }
        
    }
}
