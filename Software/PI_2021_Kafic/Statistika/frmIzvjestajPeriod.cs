using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_2021_Kafic.Statistika
{
    public partial class frmIzvjestajPeriod : Form
    {
        DateTime start, end;
        public frmIzvjestajPeriod(DateTime pocetak, DateTime kraj)
        {
            InitializeComponent();
            start = pocetak;
            end = kraj;
            this.Text = "Izvještaj perioda" + start.ToString() + " " + end.ToString();
        }

        private void frmIzvjestajPeriod_Load(object sender, EventArgs e)
        {
// TODO: This line of code loads data into the 'DataSetStatistika.DataTableZ' table. You can move, or remove it, as needed.
//this.DataTableZTableAdapter.Fill(this.DataSetStatistika.DataTableZ);
// TODO: This line of code loads data into the 'DataSetStatistika.Artikl' table. You can move, or remove it, as needed.
//this.ArtiklTableAdapter.Fill(this.DataSetStatistika.Artikl);
            this.DataSetStatistika.EnforceConstraints = false;
            DateTime P = DateExt.DanasPocetak(DateTime.Now);
            DateTime K = DateExt.DanasKraj(DateTime.Now);
            this.dataTablePeriodTableAdapter1.Fill(this.DataSetStatistika.DataTablePeriod, start, end);
            this.reportViewer1.RefreshReport();
        }
    }
}
