namespace projekatInfo.userlayer
{
    partial class FrmStavkePorudzbine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGrid1p = new System.Windows.Forms.DataGridView();
            this.txtPorudzbenica = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.txtKupac = new System.Windows.Forms.TextBox();
            this.txtPrimalac = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDatumIsporuke = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.datePickerDatum = new System.Windows.Forms.DateTimePicker();
            this.datePickerIsporuka = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1p)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid1p
            // 
            this.dataGrid1p.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGrid1p.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid1p.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid1p.Location = new System.Drawing.Point(0, 141);
            this.dataGrid1p.Name = "dataGrid1p";
            this.dataGrid1p.Size = new System.Drawing.Size(528, 141);
            this.dataGrid1p.TabIndex = 0;
            // 
            // txtPorudzbenica
            // 
            this.txtPorudzbenica.Location = new System.Drawing.Point(109, 33);
            this.txtPorudzbenica.Name = "txtPorudzbenica";
            this.txtPorudzbenica.Size = new System.Drawing.Size(135, 20);
            this.txtPorudzbenica.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Porudžbenica:";
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(109, 76);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(135, 20);
            this.txtDatum.TabIndex = 3;
            // 
            // txtKupac
            // 
            this.txtKupac.Location = new System.Drawing.Point(335, 33);
            this.txtKupac.Name = "txtKupac";
            this.txtKupac.Size = new System.Drawing.Size(137, 20);
            this.txtKupac.TabIndex = 4;
            // 
            // txtPrimalac
            // 
            this.txtPrimalac.Location = new System.Drawing.Point(335, 80);
            this.txtPrimalac.Name = "txtPrimalac";
            this.txtPrimalac.Size = new System.Drawing.Size(137, 20);
            this.txtPrimalac.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kupac:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Primalac:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Datum:";
            // 
            // txtDatumIsporuke
            // 
            this.txtDatumIsporuke.Location = new System.Drawing.Point(109, 115);
            this.txtDatumIsporuke.Name = "txtDatumIsporuke";
            this.txtDatumIsporuke.Size = new System.Drawing.Size(135, 20);
            this.txtDatumIsporuke.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Datum isporuke:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.datePickerIsporuka);
            this.panel1.Controls.Add(this.datePickerDatum);
            this.panel1.Controls.Add(this.txtDatum);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 141);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExport);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 282);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(528, 36);
            this.panel2.TabIndex = 12;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(45, 6);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(414, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(235, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // datePickerDatum
            // 
            this.datePickerDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerDatum.Location = new System.Drawing.Point(109, 77);
            this.datePickerDatum.Name = "datePickerDatum";
            this.datePickerDatum.Size = new System.Drawing.Size(135, 20);
            this.datePickerDatum.TabIndex = 0;
            // 
            // datePickerIsporuka
            // 
            this.datePickerIsporuka.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerIsporuka.Location = new System.Drawing.Point(109, 115);
            this.datePickerIsporuka.Name = "datePickerIsporuka";
            this.datePickerIsporuka.Size = new System.Drawing.Size(135, 20);
            this.datePickerIsporuka.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(335, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "vrednost";
            // 
            // FrmStavkePorudzbine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 318);
            this.Controls.Add(this.dataGrid1p);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDatumIsporuke);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrimalac);
            this.Controls.Add(this.txtKupac);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPorudzbenica);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(544, 357);
            this.Name = "FrmStavkePorudzbine";
            this.Text = "FrmStavkePorudzbine";
            this.Load += new System.EventHandler(this.FrmStavkePorudzbine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1p)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid1p;
        private System.Windows.Forms.TextBox txtPorudzbenica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.TextBox txtKupac;
        private System.Windows.Forms.TextBox txtPrimalac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDatumIsporuke;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DateTimePicker datePickerIsporuka;
        private System.Windows.Forms.DateTimePicker datePickerDatum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
    }
}