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
    public partial class frmIzvjestajZ : Form
    {
        public frmIzvjestajZ()
        {
            InitializeComponent();
            this.Text = "Dnevni izvještaj za datum " + DateTime.Today;
        }

        private void frmIzvjestajZ_Load(object sender, EventArgs e)
        {
            this.DataSetStatistika.EnforceConstraints = false;
            DateTime P = DateExt.DanasPocetak(DateTime.Now);
            DateTime K = DateExt.DanasKraj(DateTime.Now);
            this.DataTableZTableAdapter.Fill(this.DataSetStatistika.DataTableZ, K, P);
            this.ArtiklTableAdapter.Fill(this.DataSetStatistika.Artikl, K, P);

            this.reportViewer1.RefreshReport();
        }
    }
}
