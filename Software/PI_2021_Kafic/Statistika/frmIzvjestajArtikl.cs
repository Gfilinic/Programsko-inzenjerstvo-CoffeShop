using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PI_2021_Kafic.Statistika;

namespace PI_2021_Kafic.Statistika
{
    public partial class frmIzvjestajArtikl : Form
    {
        DateTime pocetak, kraj;
        public frmIzvjestajArtikl(DateTime start, DateTime end)
        {
            InitializeComponent();
            pocetak = start;
            kraj = end;

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void frmIzvjestajArtikl_Load(object sender, EventArgs e)
        {
            this.DataSetStatistika.EnforceConstraints = false;
            this.DataTableArtiklTableAdapter.Fill(this.DataSetStatistika.DataTableArtikl,pocetak,kraj);
            reportViewer1.RefreshReport();
        }


    }
}
