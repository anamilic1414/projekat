using iTextSharp.text;
using iTextSharp.text.pdf;
using projekatInfo.businesslayer;
using System;
using System.IO;
using System.Windows.Forms;

namespace projekatInfo.userlayer
{
    public partial class FrmStavkePorudzbine : Form
    {
        PorudzbinaBO porudzbinaBO;
        MaterijalBO materijalBO;
        DataGridViewRow dgr;
        string id;
        BindingSource bsMaster;
        BindingSource bsDetail;
        String datumIsporuke;
        String datum;
        String kupac;
        String primalac;
        public FrmStavkePorudzbine(DataGridViewRow dgr, BindingSource bsMaster)
        {
            InitializeComponent();
            this.dgr = dgr;
            this.bsMaster = bsMaster;
        }

        private void FrmStavkePorudzbine_Load(object sender, EventArgs e)
        {
            porudzbinaBO = new PorudzbinaBO();
            materijalBO = new MaterijalBO();
            if (!dgr.IsNewRow) {
                datePickerDatum.Visible = false;
                datePickerIsporuka.Visible = false;
                id = dgr.Cells[0].Value.ToString();
                txtPorudzbenica.Text = id;
                txtDatum.Text = dgr.Cells[1].Value.ToString();
                txtKupac.Text = dgr.Cells[2].Value.ToString();
                txtDatumIsporuke.Text = dgr.Cells[3].Value.ToString();
                txtPrimalac.Text = dgr.Cells[4].Value.ToString();

                bsDetail = new BindingSource();
                bsDetail.DataSource = bsMaster;
                bsDetail.DataMember = "VezaPorudzbineStavke";
                
                datum = txtDatum.Text;
                datumIsporuke = txtDatumIsporuke.Text;
            }
            else
            {
                txtDatum.Visible = false;
                txtDatumIsporuke.Visible = false;
                DateTime date = this.datePickerDatum.Value;
                datum = date.ToString("yyyy-mm-dd");
                DateTime date2 = this.datePickerDatum.Value;
                datumIsporuke = date2.ToString("yyyy-mm-dd");
            }
            dataGrid1p.DataSource = bsDetail;
            dataGrid1p.Columns[0].Visible = false;
            dataGrid1p.Columns[3].Visible = false;
            DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn();
            combo.Name = "materijal";
            combo.DataSource = materijalBO.PrimaryData;
            combo.ValueMember = "id";
            combo.DisplayMember = "naziv";

            dataGrid1p.Columns.Add(combo);
            dataGrid1p.Columns[5].HeaderText = "materijal";
            this.dataGrid1p.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataGridViewTextBoxColumn cena = new DataGridViewTextBoxColumn();
            cena.HeaderText = "cena";
            dataGrid1p.Columns.Add(cena);

            dataGrid1p.CellValueChanged +=
             new DataGridViewCellEventHandler(dataGrid1p_CellValueChanged);
            dataGrid1p.CurrentCellDirtyStateChanged +=
                 new EventHandler(dataGrid1p_CurrentCellDirtyStateChanged);

            
            foreach (DataGridViewRow item in dataGrid1p.Rows)
            {//ovo je na pocetku ovako kad ga prikazuje tek
                item.Cells[5].Value=item.Cells[3].Value;
                string jedCena = materijalBO.PrimaryData.IzracunajCenu(id);
                int uk = Convert.ToInt32(jedCena) * Convert.ToInt32(item.Cells[4].Value);
                item.Cells[6].Value = uk;

            }
        }
        // This event handler manually raises the CellValueChanged event 
        // by calling the CommitEdit method. 
        void dataGrid1p_CurrentCellDirtyStateChanged(object sender,EventArgs e)
        {
            if (this.dataGrid1p.IsCurrentCellDirty)
            {
                dataGrid1p.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dataGrid1p_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewComboBoxCell cb = (DataGridViewComboBoxCell) dataGrid1p.Rows[e.RowIndex].Cells[5];
            if (cb.Value != null)
            {
               dataGrid1p.Invalidate();
                if(dataGrid1p.CurrentRow!=null)
               dataGrid1p.CurrentRow.Cells[3].Value = cb.Value;
               
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGrid1p.CurrentRow;
            if (row.Cells[0].Value.ToString()!="") {
                MessageBox.Show("Ne možete dodati red koji već postoji");
            }else
            {
                string idPor = row.Cells[1].Value.ToString();
                string tipMat = row.Cells[2].Value.ToString();
                string idMat = row.Cells[3].Value.ToString();
                string kolicina = row.Cells[4].Value.ToString();
                porudzbinaBO.SecondaryData.Insert(idPor, tipMat, idMat, kolicina);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try { 
            PdfPTable pdfTable = new PdfPTable(dataGrid1p.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;
          
            iTextSharp.text.Font titleFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA
                                      , 15
                                      , iTextSharp.text.Font.BOLD
                                      , BaseColor.BLACK);
            
            iTextSharp.text.Font textFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA
                                     , 12
                                     , iTextSharp.text.Font.NORMAL
                                     , BaseColor.BLACK);

            foreach (DataGridViewColumn column in dataGrid1p.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (DataGridViewRow row in dataGrid1p.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        pdfTable.AddCell(cell.Value.ToString());
                    }
                }
            }
            string folderPath = "C:\\PDFs\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "PorudzbenicaBr"+ id +".pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                
                pdfDoc.AddAuthor("Ana");
                pdfDoc.Add(new Paragraph("Porudzbenica br: "+id, titleFont));
                pdfDoc.Add(new Paragraph("Datum: " + txtDatum.Text, titleFont));
                pdfDoc.Add(new Paragraph("Kupac: " + txtKupac.Text, titleFont));
                pdfDoc.Add(new Paragraph("Datum isporuke: " + txtDatumIsporuke.Text, titleFont));
                pdfDoc.Add(new Paragraph("Primalac: " + txtPrimalac.Text, titleFont));
                pdfDoc.Add(new Paragraph(" "));
                pdfDoc.Add(pdfTable);

                pdfDoc.Close();
                stream.Close();
            }
                MessageBox.Show("Uspesno se exportovali porudzbenicu!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void btnDodajPor_Click(object sender, EventArgs e)
        {
            kupac = txtKupac.Text;
            primalac = txtPrimalac.Text;
            if (id == "") { 
            porudzbinaBO.PrimaryData.Insert(datum, kupac, datumIsporuke, primalac);
            }
            else
            {
                MessageBox.Show("Porudzbenica vec postoji");
            }
        }
    }
}
