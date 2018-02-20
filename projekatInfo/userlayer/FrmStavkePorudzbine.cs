using iTextSharp.text;
using iTextSharp.text.pdf;
using projekatInfo.businesslayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekatInfo.userlayer
{
    public partial class FrmStavkePorudzbine : Form
    {
        PorudzbinaBO porudzbinaBO;
        DataGridViewRow dgr;
        string id;
        BindingSource bsMaster;
        BindingSource bsDetail;
        public FrmStavkePorudzbine(DataGridViewRow dgr, BindingSource bsMaster)
        {
            InitializeComponent();
            this.dgr = dgr;
            this.bsMaster = bsMaster;
        }

        private void FrmStavkePorudzbine_Load(object sender, EventArgs e)
        {
            porudzbinaBO = new PorudzbinaBO();
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

            dataGrid1p.DataSource = bsDetail;
            }
            else
            {
                txtDatum.Visible = false;
                txtDatumIsporuke.Visible = false;
                DateTime date = this.datePickerDatum.Value;
                String datum = date.ToString("yyyy-mm-dd");
                DateTime date2 = this.datePickerDatum.Value;
                String datumIsporuke = date2.ToString("yyyy-mm-dd");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGrid1p.CurrentRow;
            if (row == null) { MessageBox.Show("Morate selektovati red koji zelite da dodate"); }
            else {
            string idPor = row.Cells[1].Value.ToString();
            string tipMat = row.Cells[2].Value.ToString();
            string idMat = row.Cells[3].Value.ToString();
            string kolicina = row.Cells[4].Value.ToString();
            porudzbinaBO.SecondaryData.Insert(idPor,tipMat,idMat, kolicina);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            PdfPTable pdfTable = new PdfPTable(dataGrid1p.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;
          
            iTextSharp.text.Font titleFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA
                                      , 15
                                      , iTextSharp.text.Font.BOLD
                                      , BaseColor.BLACK
                );
            
            iTextSharp.text.Font textFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA
                                     , 12
                                     , iTextSharp.text.Font.NORMAL
                                     , BaseColor.BLACK
                );

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
    }
}
