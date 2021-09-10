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
    public partial class frmIzvjestajX : Form
    {
        Konobar odabraniKonobar;
        public frmIzvjestajX(Konobar konobar)
        {
            InitializeComponent();
            this.Text = "X izvještaj konobara "+konobar.Ime + " " + konobar.Prezime;
            odabraniKonobar = konobar;
        }


        private void frmIzvjestajX_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetStatistika.DataTableRacuni' table. You can move, or remove it, as needed.
            this.DataSetStatistika.EnforceConstraints = false;
            DateTime P = DateExt.DanasPocetak(DateTime.Now);
            DateTime K = DateExt.DanasKraj(DateTime.Now);
            this.DataTableRacuniTableAdapter.Fill(this.DataSetStatistika.DataTableRacuni,odabraniKonobar.ID_Konobar, K, P);
           // this.ArtiklTableAdapter.Fill(this.DataSetStatistika.Artikl, K, P);
            this.reportViewer1.RefreshReport();
        }
    }
}
