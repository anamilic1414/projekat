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
            dataGrid1.Columns["id"].Visible = false;
            dataGrid1.Columns["idTipMaterijala"].Visible = false;
            dataGrid2.DataSource = materijalBO.SecondaryData;
            dataGrid2.Columns["id"].Visible = false;
            dataGrid2.Columns["parentId"].Visible = false;
            dataGrid2.Columns["idMat"].Visible = false;  
        }

        

        private void materijaliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMaterijali frm = new FrmMaterijali();
            frm.ShowDialog();
        }

        private void porudžbenicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPorudzbenica frm = new FrmPorudzbenica();
            frm.Show();
        }

        
    }
}
