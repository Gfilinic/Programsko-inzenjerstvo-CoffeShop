
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
            this.DataTableZBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetStatistika = new PI_2021_Kafic.Statistika.DataSetStatistika();
            this.ArtiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTableZTableAdapter = new PI_2021_Kafic.Statistika.DataSetStatistikaTableAdapters.DataTableZTableAdapter();
            this.ArtiklTableAdapter = new PI_2021_Kafic.Statistika.DataSetStatistikaTableAdapters.ArtiklTableAdapter();
            this.artiklTableAdapter1 = new PI_2021_Kafic.Statistika.DataSetStatistikaTableAdapters.ArtiklTableAdapter();
            this.dataTablePeriodTableAdapter1 = new PI_2021_Kafic.Statistika.DataSetStatistikaTableAdapters.DataTablePeriodTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableZBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetStatistika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArtiklBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTableZBindingSource
            // 
            this.DataTableZBindingSource.DataMember = "DataTableZ";
            this.DataTableZBindingSource.DataSource = this.DataSetStatistika;
            // 
            // DataSetStatistika
            // 
            this.DataSetStatistika.DataSetName = "DataSetStatistika";
            this.DataSetStatistika.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ArtiklBindingSource
            // 
            this.ArtiklBindingSource.DataMember = "Artikl";
            this.ArtiklBindingSource.DataSource = this.DataSetStatistika;
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PI_2021_Kafic.Reports.ReportPeriod.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(27, 33);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(729, 376);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataTableZTableAdapter
            // 
            this.DataTableZTableAdapter.ClearBeforeFill = true;
            // 
            // ArtiklTableAdapter
            // 
            this.ArtiklTableAdapter.ClearBeforeFill = true;
            // 
            // artiklTableAdapter1
            // 
            this.artiklTableAdapter1.ClearBeforeFill = true;
            // 
            // dataTablePeriodTableAdapter1
            // 
            this.dataTablePeriodTableAdapter1.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.DataTableZBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetStatistika)).EndInit();
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
        private DataSetStatistikaTableAdapters.ArtiklTableAdapter artiklTableAdapter1;
        private DataSetStatistikaTableAdapters.DataTablePeriodTableAdapter dataTablePeriodTableAdapter1;
    }
}