namespace PI_2021_Kafic
{
    partial class frmPotrosnja
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.NamirnicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbNamirnice = new System.Windows.Forms.ListBox();
            this.cmbPeriod = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reportNamirnice = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.NamirnicaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // NamirnicaBindingSource
            // 
            this.NamirnicaBindingSource.DataSource = typeof(PI_2021_Kafic.Namirnica);
            // 
            // lbNamirnice
            // 
            this.lbNamirnice.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNamirnice.FormattingEnabled = true;
            this.lbNamirnice.ItemHeight = 22;
            this.lbNamirnice.Location = new System.Drawing.Point(12, 46);
            this.lbNamirnice.Name = "lbNamirnice";
            this.lbNamirnice.Size = new System.Drawing.Size(800, 312);
            this.lbNamirnice.TabIndex = 0;
            this.lbNamirnice.SelectedIndexChanged += new System.EventHandler(this.lbNamirnice_SelectedIndexChanged);
            // 
            // cmbPeriod
            // 
            this.cmbPeriod.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPeriod.FormattingEnabled = true;
            this.cmbPeriod.Location = new System.Drawing.Point(100, 8);
            this.cmbPeriod.Name = "cmbPeriod";
            this.cmbPeriod.Size = new System.Drawing.Size(71, 28);
            this.cmbPeriod.TabIndex = 1;
            this.cmbPeriod.SelectedIndexChanged += new System.EventHandler(this.cmbPeriod_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Za period: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(178, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "dana";
            // 
            // reportNamirnice
            // 
            reportDataSource1.Name = "Namirnice";
            reportDataSource1.Value = this.NamirnicaBindingSource;
            this.reportNamirnice.LocalReport.DataSources.Add(reportDataSource1);
            this.reportNamirnice.LocalReport.ReportEmbeddedResource = "PI_2021_Kafic.Reports.ReportNamirnice.rdlc";
            this.reportNamirnice.Location = new System.Drawing.Point(12, 364);
            this.reportNamirnice.Name = "reportNamirnice";
            this.reportNamirnice.ServerReport.BearerToken = null;
            this.reportNamirnice.Size = new System.Drawing.Size(800, 311);
            this.reportNamirnice.TabIndex = 3;
            this.reportNamirnice.Load += new System.EventHandler(this.reportNamirnice_Load);
            // 
            // frmPotrosnja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 687);
            this.Controls.Add(this.reportNamirnice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPeriod);
            this.Controls.Add(this.lbNamirnice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPotrosnja";
            this.Text = "Predvidanje potrosnje";
            this.Load += new System.EventHandler(this.frmPotrosnja_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.frmPotrosnja_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.NamirnicaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbNamirnice;
        private System.Windows.Forms.ComboBox cmbPeriod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer reportNamirnice;
        private System.Windows.Forms.BindingSource NamirnicaBindingSource;
    }
}