
namespace PI_2021_Kafic.Statistika
{
    partial class frmIzvjestaKonobarPeriod
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
            this.DataSetStatistika = new PI_2021_Kafic.Statistika.DataSetStatistika();
            this.DataTableKonobarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTableKonobarTableAdapter = new PI_2021_Kafic.Statistika.DataSetStatistikaTableAdapters.DataTableKonobarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetStatistika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableKonobarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetKonobarPeriod";
            reportDataSource1.Value = this.DataTableKonobarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PI_2021_Kafic.Reports.ReportKonobarPeriod.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetStatistika
            // 
            this.DataSetStatistika.DataSetName = "DataSetStatistika";
            this.DataSetStatistika.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTableKonobarBindingSource
            // 
            this.DataTableKonobarBindingSource.DataMember = "DataTableKonobar";
            this.DataTableKonobarBindingSource.DataSource = this.DataSetStatistika;
            // 
            // DataTableKonobarTableAdapter
            // 
            this.DataTableKonobarTableAdapter.ClearBeforeFill = true;
            // 
            // frmIzvjestaKonobarPeriod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmIzvjestaKonobarPeriod";
            this.Text = "Izvjestaj konobara u periodu ";
            this.Load += new System.EventHandler(this.frmIzvjestaKonobarPeriod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetStatistika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableKonobarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTableKonobarBindingSource;
        private DataSetStatistika DataSetStatistika;
        private DataSetStatistikaTableAdapters.DataTableKonobarTableAdapter DataTableKonobarTableAdapter;
    }
}