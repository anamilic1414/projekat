using projekatInfo.businesslayer;
using projekatInfo.datalayer;
using System;
using System.Drawing;
using System.Windows.Forms;



namespace projekatInfo.userlayer
{
    public partial class FrmPorudzbenica : Form
    {
        MaterijalBO materijalBO;
        PorudzbinaBO porudzbenicaBO;
        BindingSource bsMaster;

        public FrmPorudzbenica()
        {
            InitializeComponent();
           try
            {
                porudzbenicaBO = new PorudzbinaBO();
                //materijalBO = new MaterijalBO();
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void FrmPorudzbenica_Load(object sender, EventArgs e)
        {
            bsMaster = new BindingSource();
            bsMaster.DataSource = porudzbenicaBO.PrimaryData;

            dataGrid2.DataSource = bsMaster;

        }

        private void dataGrid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {/*
            // If any cell is clicked on the Second column which is our date Column  
            if (e.ColumnIndex == 1)
            {
                //Initialized a new DateTimePicker Control  
                oDateTimePicker = new DateTimePicker();

                //Adding DateTimePicker control into DataGridView   
                dataGrid2.Controls.Add(oDateTimePicker);

                // Setting the format (i.e. 2014-10-10)  
                oDateTimePicker.Format = DateTimePickerFormat.Short;

                // It returns the retangular area that represents the Display area for a cell  
                Rectangle oRectangle = dataGrid2.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                //Setting area for DateTimePicker Control  
                oDateTimePicker.Size = new Size(oRectangle.Width, oRectangle.Height);

                // Setting Location  
                oDateTimePicker.Location = new Point(oRectangle.X, oRectangle.Y);

                // An event attached to dateTimePicker Control which is fired when DateTimeControl is closed  
                oDateTimePicker.CloseUp += new EventHandler(oDateTimePicker_CloseUp);

                // An event attached to dateTimePicker Control which is fired when any date is selected  
                oDateTimePicker.TextChanged += new EventHandler(dateTimePicker_OnTextChange);

                // Now make it visible  
                oDateTimePicker.Visible = true;
            }
            */
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGrid2.CurrentRow;
            FrmStavkePorudzbine frm = new FrmStavkePorudzbine(row, bsMaster);
            frm.ShowDialog();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            zatvori();
        }
        private void zatvori()
        {
            DialogResult res = MessageBox.Show("Da li želite da zatvorite?", "Potvrdi", MessageBoxButtons.YesNo
            );
            if (res == System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            else
            {
                this.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGrid2.CurrentRow;
            porudzbenicaBO.PrimaryData.Delete(row.Cells[0].Value.ToString());
        }
    }
}
