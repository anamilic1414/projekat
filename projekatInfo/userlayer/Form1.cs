﻿using projekatInfo.businesslayer;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            TipoviMaterijalaBO tipoviMaterijalaBO = new TipoviMaterijalaBO();
            dataGrid1.DataSource = tipoviMaterijalaBO.PrimaryData;
        }
    }
}