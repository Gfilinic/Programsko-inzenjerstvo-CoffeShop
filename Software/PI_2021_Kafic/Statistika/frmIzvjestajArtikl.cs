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
        private DateTime pocetak, kraj;
        private Kafic kafic;
        public frmIzvjestajArtikl(DateTime start, DateTime end,Kafic odabraniKafic)
        {
            InitializeComponent();
            pocetak = start;
            kraj = end;
            this.Text += "." + pocetak.Day + "." + pocetak.Month + "." + pocetak.Year + " - "
                + kraj.Day + "." + kraj.Month + "." + kraj.Year;
            kafic = odabraniKafic;
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void frmIzvjestajArtikl_Load(object sender, EventArgs e)
        {
            this.DataSetStatistika.EnforceConstraints = false;
            this.DataTableArtiklTableAdapter.Fill(this.DataSetStatistika.DataTableArtikl,pocetak,kraj,kafic.ID_Kafic);
            reportViewer1.RefreshReport();
        }


    }
}
