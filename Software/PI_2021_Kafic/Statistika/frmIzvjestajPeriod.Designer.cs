
namespace PI_2021_Kafic.Statistika
{
    partial class frmIzvjestajPeriod
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTablePeriodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetStatistika = new PI_2021_Kafic.Statistika.DataSetStatistika();
            this.DataTablePeriodTableAdapter = new PI_2021_Kafic.Statistika.DataSetStatistikaTableAdapters.DataTablePeriodTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataTablePeriodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetStatistika)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetPeriod";
            reportDataSource1.Value = this.DataTablePeriodBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PI_2021_Kafic.Reports.ReportTime.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataTablePeriodBindingSource
            // 
            this.DataTablePeriodBindingSource.DataMember = "DataTablePeriod";
            this.DataTablePeriodBindingSource.DataSource = this.DataSetStatistika;
            // 
            // DataSetStatistika
            // 
            this.DataSetStatistika.DataSetName = "DataSetStatistika";
            this.DataSetStatistika.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTablePeriodTableAdapter
            // 
            this.DataTablePeriodTableAdapter.ClearBeforeFill = true;
            // 
            // frmIzvjestajPeriod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmIzvjestajPeriod";
            this.Text = "Izvjestaj perioda: ";
            this.Load += new System.EventHandler(this.frmIzvjestajPeriod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTablePeriodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetStatistika)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTablePeriodBindingSource;
        private DataSetStatistika DataSetStatistika;
        private DataSetStatistikaTableAdapters.DataTablePeriodTableAdapter DataTablePeriodTableAdapter;
    }
}