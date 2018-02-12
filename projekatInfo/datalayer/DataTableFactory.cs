using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekatInfo.datalayer
{
    public static class DataTableFactory
    {
        private static MyDataSet _DataSet;
        public static MyDataSet DataSet {
            get {
                return DataTableFactory.GetDataSet();
            }
        private set {
                _DataSet = value;
            }
        }

        public static MyDataTable GetDataTable(string imeKlase, string imeTabele)
        {
            MyDataTable result = null;
            
            if(DataSet.Tables[imeTabele] != null)
            {
                result = (MyDataTable)DataSet.Tables[imeTabele];
            }
            else
            {
                result = CreateDataTable(imeKlase, imeTabele);
            }
            return result;
        }

        public static MyDataTable GetDataTable(string imeKlase)
        {
            return GetDataTable(imeKlase, "");
        }
       public static MyDataTable CreateDataTable(string imeKlase, string imeTabele)
        {
            MyDataTable result = null;
            switch (imeKlase) {
                case "TipoviMaterijalaTable":
                    result = new TipoviMaterijalaTable(DataSet, imeTabele);
                    break;
                case "SastavnicaTable":
                    result = new SastavnicaTable(DataSet, imeTabele);
                    break;
                case "MaterijalTable":
                    result = new MaterijalTable(DataSet, imeTabele);
                    break;
                default: throw new Exception("Ne poznajem ime tabele: "+imeKlase);
                        //ne instanciram ja data set nego i z 
                        //factoroa get data set i gde pravim tabele pravi ih g=factory
                    //kad god nesto dodajem od tabela ovde upisujem
            }
            return result;
        }
     

        public static MyDataSet GetDataSet()
        {
            if (_DataSet == null)
            {
                _DataSet = new MyDataSet(Program.konekcija);
            }
            return _DataSet;
        }
    }
}
