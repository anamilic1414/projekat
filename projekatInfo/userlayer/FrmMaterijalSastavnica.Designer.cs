namespace projekatInfo.userlayer
{
    partial class FrmMaterijalSastavnica
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
            this.dataGrid1 = new System.Windows.Forms.DataGridView();
            this.dataGrid2 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.datotekeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.šifrarnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoviMaterijalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.materijaliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid1
            // 
            this.dataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid1.Location = new System.Drawing.Point(12, 44);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(286, 128);
            this.dataGrid1.TabIndex = 0;
            // 
            // dataGrid2
            // 
            this.dataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid2.Location = new System.Drawing.Point(12, 193);
            this.dataGrid2.Name = "dataGrid2";
            this.dataGrid2.Size = new System.Drawing.Size(286, 121);
            this.dataGrid2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datotekeToolStripMenuItem,
            this.šifrarnikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(400, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // datotekeToolStripMenuItem
            // 
            this.datotekeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.materijaliToolStripMenuItem});
            this.datotekeToolStripMenuItem.Name = "datotekeToolStripMenuItem";
            this.datotekeToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.datotekeToolStripMenuItem.Text = "&Dokumenti";
            // 
            // šifrarnikToolStripMenuItem
            // 
            this.šifrarnikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoviMaterijalaToolStripMenuItem});
            this.šifrarnikToolStripMenuItem.Name = "šifrarnikToolStripMenuItem";
            this.šifrarnikToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.šifrarnikToolStripMenuItem.Text = "Ši&frarnici";
            // 
            // tipoviMaterijalaToolStripMenuItem
            // 
            this.tipoviMaterijalaToolStripMenuItem.Name = "tipoviMaterijalaToolStripMenuItem";
            this.tipoviMaterijalaToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.tipoviMaterijalaToolStripMenuItem.Text = "Tipovi materijala";
            this.tipoviMaterijalaToolStripMenuItem.Click += new System.EventHandler(this.tipoviMaterijalaToolStripMenuItem_Click);
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(313, 53);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 3;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // materijaliToolStripMenuItem
            // 
            this.materijaliToolStripMenuItem.Name = "materijaliToolStripMenuItem";
            this.materijaliToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.materijaliToolStripMenuItem.Text = "&Materijali";
            this.materijaliToolStripMenuItem.Click += new System.EventHandler(this.materijaliToolStripMenuItem_Click);
            // 
            // FrmMaterijalSastavnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 326);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.dataGrid2);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMaterijalSastavnica";
            this.Text = "FrmMaterijalSastavnica";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid1;
        private System.Windows.Forms.DataGridView dataGrid2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datotekeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem šifrarnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoviMaterijalaToolStripMenuItem;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.ToolStripMenuItem materijaliToolStripMenuItem;
    }
}