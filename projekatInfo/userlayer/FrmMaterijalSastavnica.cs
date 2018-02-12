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

namespace projekatInfo.userlayer
{
    public partial class FrmMaterijalSastavnica : Form
    {
        MaterijalBO materijalBO;
        public FrmMaterijalSastavnica()
        {
            InitializeComponent();
        }

        private void tipoviMaterijalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTipoviMaterijala frm = new FrmTipoviMaterijala();
            frm.ShowDialog();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            materijalBO = new MaterijalBO();
            dataGrid1.DataSource = materijalBO.PrimaryData;
            dataGrid2.DataSource = materijalBO.SecondaryData;
            
        }
    }
}
