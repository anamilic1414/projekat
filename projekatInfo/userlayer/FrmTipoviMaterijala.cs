using projekatInfo.businesslayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekatInfo
{
    public partial class FrmTipoviMaterijala : Form
    {

        TipoviMaterijalaBO tipoviMaterijalaBO;
        public FrmTipoviMaterijala()
        {
            InitializeComponent();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            tipoviMaterijalaBO = new TipoviMaterijalaBO();
            dataGrid1.DataSource = tipoviMaterijalaBO.PrimaryData;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                tipoviMaterijalaBO.PrimaryData.Update();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }

        }
    }
}
