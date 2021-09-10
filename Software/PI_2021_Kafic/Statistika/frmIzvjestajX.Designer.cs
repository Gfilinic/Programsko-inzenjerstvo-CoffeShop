
namespace PI_2021_Kafic.Statistika
{
    partial class frmIzvjestajX
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetStatistika = new PI_2021_Kafic.Statistika.DataSetStatistika();
            this.DataTableRacuniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTableRacuniTableAdapter = new PI_2021_Kafic.Statistika.DataSetStatistikaTableAdapters.DataTableRacuniTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetStatistika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableRacuniBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSetRacun";
            reportDataSource2.Value = this.DataTableRacuniBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PI_2021_Kafic.Reports.ReportKonobar.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(48, 30);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(699, 336);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetStatistika
            // 
            this.DataSetStatistika.DataSetName = "DataSetStatistika";
            this.DataSetStatistika.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTableRacuniBindingSource
            // 
            this.DataTableRacuniBindingSource.DataMember = "DataTableRacuni";
            this.DataTableRacuniBindingSource.DataSource = this.DataSetStatistika;
            // 
            // DataTableRacuniTableAdapter
            // 
            this.DataTableRacuniTableAdapter.ClearBeforeFill = true;
            // 
            // frmIzvjestajX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmIzvjestajX";
            this.Text = "X izvještaj konobara";
            this.Load += new System.EventHandler(this.frmIzvjestajX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetStatistika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableRacuniBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSetStatistika DataSetStatistika;
        private System.Windows.Forms.BindingSource DataTableRacuniBindingSource;
        private DataSetStatistikaTableAdapters.DataTableRacuniTableAdapter DataTableRacuniTableAdapter;
    }
}