namespace csv2vtodo
{
    partial class MainForm
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
            this.BtnBrowseCsv = new System.Windows.Forms.Button();
            this.BtnExportTo = new System.Windows.Forms.Button();
            this.BtnConvert = new System.Windows.Forms.Button();
            this.TxtCSVFile = new System.Windows.Forms.TextBox();
            this.TxtExportPath = new System.Windows.Forms.TextBox();
            this.BrowseExport = new System.Windows.Forms.FolderBrowserDialog();
            this.BrowseCSV = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // BtnBrowseCsv
            // 
            this.BtnBrowseCsv.Location = new System.Drawing.Point(12, 12);
            this.BtnBrowseCsv.Name = "BtnBrowseCsv";
            this.BtnBrowseCsv.Size = new System.Drawing.Size(75, 23);
            this.BtnBrowseCsv.TabIndex = 0;
            this.BtnBrowseCsv.Text = "Select CSV";
            this.BtnBrowseCsv.UseVisualStyleBackColor = true;
            this.BtnBrowseCsv.Click += new System.EventHandler(this.BtnBrowseCsv_Click);
            // 
            // BtnExportTo
            // 
            this.BtnExportTo.Location = new System.Drawing.Point(12, 41);
            this.BtnExportTo.Name = "BtnExportTo";
            this.BtnExportTo.Size = new System.Drawing.Size(75, 23);
            this.BtnExportTo.TabIndex = 1;
            this.BtnExportTo.Text = "Export To";
            this.BtnExportTo.UseVisualStyleBackColor = true;
            this.BtnExportTo.Click += new System.EventHandler(this.BtnExportTo_Click);
            // 
            // BtnConvert
            // 
            this.BtnConvert.Location = new System.Drawing.Point(84, 84);
            this.BtnConvert.Name = "BtnConvert";
            this.BtnConvert.Size = new System.Drawing.Size(291, 29);
            this.BtnConvert.TabIndex = 2;
            this.BtnConvert.Text = "Convert!";
            this.BtnConvert.UseVisualStyleBackColor = true;
            this.BtnConvert.Click += new System.EventHandler(this.BtnConvert_Click);
            // 
            // TxtCSVFile
            // 
            this.TxtCSVFile.Location = new System.Drawing.Point(93, 14);
            this.TxtCSVFile.Name = "TxtCSVFile";
            this.TxtCSVFile.Size = new System.Drawing.Size(343, 20);
            this.TxtCSVFile.TabIndex = 3;
            // 
            // TxtExportPath
            // 
            this.TxtExportPath.Location = new System.Drawing.Point(93, 43);
            this.TxtExportPath.Name = "TxtExportPath";
            this.TxtExportPath.Size = new System.Drawing.Size(343, 20);
            this.TxtExportPath.TabIndex = 4;
            // 
            // BrowseExport
            // 
            this.BrowseExport.SelectedPath = "System.Environment.GetEnvironmentVariable(\"USERPROFILE\");";
            // 
            // BrowseCSV
            // 
            this.BrowseCSV.Filter = "CSV Files (csv)|*.csv";
            this.BrowseCSV.InitialDirectory = "System.Environment.GetEnvironmentVariable(\"USERPROFILE\");";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 136);
            this.Controls.Add(this.TxtExportPath);
            this.Controls.Add(this.TxtCSVFile);
            this.Controls.Add(this.BtnConvert);
            this.Controls.Add(this.BtnExportTo);
            this.Controls.Add(this.BtnBrowseCsv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "csv2vtodo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBrowseCsv;
        private System.Windows.Forms.Button BtnExportTo;
        private System.Windows.Forms.Button BtnConvert;
        private System.Windows.Forms.TextBox TxtCSVFile;
        private System.Windows.Forms.TextBox TxtExportPath;
        private System.Windows.Forms.FolderBrowserDialog BrowseExport;
        private System.Windows.Forms.OpenFileDialog BrowseCSV;
    }
}

