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
        private Kafic kafic;
        public frmIzvjestajZ(Kafic odabraniKafic)
        {
            InitializeComponent();
            this.Text = "Dnevni izvještaj za datum " + DateTime.Today.Day+"."+DateTime.Today.Month + "."+ DateTime.Today.Year + ".";
            kafic = odabraniKafic;
        }

        private void frmIzvjestajZ_Load(object sender, EventArgs e)
        {
            this.DataSetStatistika.EnforceConstraints = false;
            DateTime P = DateExt.DanasPocetak(DateTime.Now);
            DateTime K = DateExt.DanasKraj(DateTime.Now);
            this.DataTableZTableAdapter.Fill(this.DataSetStatistika.DataTableZ, K, P,kafic.ID_Kafic);
            this.ArtiklTableAdapter.Fill(this.DataSetStatistika.Artikl, K, P,kafic.ID_Kafic);

            this.reportViewer1.RefreshReport();
        }
    }
}
