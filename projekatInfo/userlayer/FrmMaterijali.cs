using projekatInfo.businesslayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekatInfo.userlayer
{
    public partial class FrmMaterijali : Form
    {
        MaterijalBO materijalBO;
        public FrmMaterijali()
        {
            InitializeComponent();
        }

        private void FrmMaterijali_Load(object sender, EventArgs e)
        {
            materijalBO = new MaterijalBO();
            dataGrid1.DataSource = materijalBO.PrimaryData;
            dataGrid1.AutoResizeColumns();
           
            //dataGrid1.AutoResizeColumnHeadersHeight();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                materijalBO.PrimaryData.Update();
                //BO ima update a ne tabeli da se pristupa
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
