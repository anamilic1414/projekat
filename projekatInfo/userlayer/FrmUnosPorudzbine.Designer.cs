namespace projekatInfo.userlayer
{
    partial class FrmUnosPorudzbine
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
            this.datePrijem = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKupac = new System.Windows.Forms.TextBox();
            this.txtPrimalac = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateIsporuka = new System.Windows.Forms.DateTimePicker();
            this.dataGrid1 = new System.Windows.Forms.DataGridView();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // datePrijem
            // 
            this.datePrijem.Location = new System.Drawing.Point(115, 21);
            this.datePrijem.Name = "datePrijem";
            this.datePrijem.Size = new System.Drawing.Size(100, 20);
            this.datePrijem.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "datum prijema:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "datum isporuke:";
            // 
            // txtKupac
            // 
            this.txtKupac.Location = new System.Drawing.Point(372, 21);
            this.txtKupac.Name = "txtKupac";
            this.txtKupac.Size = new System.Drawing.Size(100, 20);
            this.txtKupac.TabIndex = 4;
            // 
            // txtPrimalac
            // 
            this.txtPrimalac.Location = new System.Drawing.Point(372, 47);
            this.txtPrimalac.Name = "txtPrimalac";
            this.txtPrimalac.Size = new System.Drawing.Size(100, 20);
            this.txtPrimalac.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "kupac:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "primalac:";
            // 
            // dateIsporuka
            // 
            this.dateIsporuka.Location = new System.Drawing.Point(115, 47);
            this.dateIsporuka.Name = "dateIsporuka";
            this.dateIsporuka.Size = new System.Drawing.Size(100, 20);
            this.dateIsporuka.TabIndex = 8;
            // 
            // dataGrid1
            // 
            this.dataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid1.Location = new System.Drawing.Point(31, 101);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(416, 163);
            this.dataGrid1.TabIndex = 9;
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Location = new System.Drawing.Point(372, 281);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(75, 23);
            this.btnPotvrdi.TabIndex = 10;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // FrmUnosPorudzbine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 327);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.dateIsporuka);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrimalac);
            this.Controls.Add(this.txtKupac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datePrijem);
            this.Name = "FrmUnosPorudzbine";
            this.Text = "FrmUnosPorudzbine";
            this.Load += new System.EventHandler(this.FrmUnosPorudzbine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker datePrijem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKupac;
        private System.Windows.Forms.TextBox txtPrimalac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateIsporuka;
        private System.Windows.Forms.DataGridView dataGrid1;
        private System.Windows.Forms.Button btnPotvrdi;
    }
}