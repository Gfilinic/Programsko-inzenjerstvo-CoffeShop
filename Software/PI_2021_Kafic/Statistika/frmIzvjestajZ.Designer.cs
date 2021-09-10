
namespace PI_2021_Kafic.Statistika
{
    partial class frmIzvjestajZ
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetStatistika = new PI_2021_Kafic.Statistika.DataSetStatistika();
            this.DataTableZBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTableZTableAdapter = new PI_2021_Kafic.Statistika.DataSetStatistikaTableAdapters.DataTableZTableAdapter();
            this.ArtiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ArtiklTableAdapter = new PI_2021_Kafic.Statistika.DataSetStatistikaTableAdapters.ArtiklTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetStatistika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableZBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArtiklBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetZ";
            reportDataSource1.Value = this.DataTableZBindingSource;
            reportDataSource2.Name = "DataSetArtikl";
            reportDataSource2.Value = this.ArtiklBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PI_2021_Kafic.Reports.ZReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(786, 437);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetStatistika
            // 
            this.DataSetStatistika.DataSetName = "DataSetStatistika";
            this.DataSetStatistika.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTableZBindingSource
            // 
            this.DataTableZBindingSource.DataMember = "DataTableZ";
            this.DataTableZBindingSource.DataSource = this.DataSetStatistika;
            // 
            // DataTableZTableAdapter
            // 
            this.DataTableZTableAdapter.ClearBeforeFill = true;
            // 
            // ArtiklBindingSource
            // 
            this.ArtiklBindingSource.DataMember = "Artikl";
            this.ArtiklBindingSource.DataSource = this.DataSetStatistika;
            // 
            // ArtiklTableAdapter
            // 
            this.ArtiklTableAdapter.ClearBeforeFill = true;
            // 
            // frmIzvjestajZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmIzvjestajZ";
            this.Text = "Dnevni izvještaj";
            this.Load += new System.EventHandler(this.frmIzvjestajZ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetStatistika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableZBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArtiklBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTableZBindingSource;
        private DataSetStatistika DataSetStatistika;
        private System.Windows.Forms.BindingSource ArtiklBindingSource;
        private DataSetStatistikaTableAdapters.DataTableZTableAdapter DataTableZTableAdapter;
        private DataSetStatistikaTableAdapters.ArtiklTableAdapter ArtiklTableAdapter;
    }
}