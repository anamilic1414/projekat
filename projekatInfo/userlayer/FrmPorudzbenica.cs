using iTextSharp.text;
using iTextSharp.text.pdf;
using projekatInfo.businesslayer;
using projekatInfo.datalayer;
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
using iTextSharp.text.pdf.draw;

namespace projekatInfo.userlayer
{
    public partial class FrmPorudzbenica : Form
    {
        PorudzbinaBO porudzbenicaBO;

        public FrmPorudzbenica()
        {
            InitializeComponent();
        }

        private void FrmPorudzbenica_Load(object sender, EventArgs e)
        {
            porudzbenicaBO = new PorudzbinaBO();
            dataGrid1.DataSource = porudzbenicaBO.PrimaryData;
            dataGrid2.DataSource = porudzbenicaBO.SecondaryData;
            
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(dataGrid2.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 50;
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

            string ID;
            ID = dataGrid1.SelectedCells[0].Value.ToString();

            //Adding Header row
            foreach (DataGridViewColumn column in dataGrid2.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (DataGridViewRow row in dataGrid2.Rows)
            {
                if (row.Cells["idPorudzbine"].Value != null) // Need to check for null if new row is exposed
                {
                    if (row.Cells["idPorudzbine"].Value.ToString().Equals(ID))
                    {

                        foreach (DataGridViewCell cell in row.Cells)
                        {

                            if (cell.Value != null)
                            {
                                pdfTable.AddCell(cell.Value.ToString());
                            }
                        }
                    }
                }
            }

            //Exporting to PDF
            string folderPath = "C:\\PDFs\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            

            using (FileStream stream = new FileStream(folderPath + "PorudzbenicaBr"+ID+".pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                
                pdfDoc.AddAuthor("Ana");
                pdfDoc.Add(new Paragraph("Porudzbenica br: "+ID, titleFont));
                pdfDoc.Add(new Paragraph(" "));
                pdfDoc.Add(pdfTable);

                pdfDoc.Close();
                stream.Close();
            }
        
        //ExportToPdf(porudzbenicaBO.PrimaryData);
        }

        private void unosNovePorudzbineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUnosPorudzbine frm = new FrmUnosPorudzbine();
            frm.ShowDialog();
        }
    }
}
