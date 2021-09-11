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
    public partial class frmIzvjestaKonobarPeriod : Form
    {
        private DateTime pocetak, kraj;
        private Kafic kafic;
        public frmIzvjestaKonobarPeriod(DateTime start,DateTime end,Kafic odabraniKafic)
        {
            InitializeComponent();
            pocetak = start;
            kraj = end;
            this.Text += "." + pocetak.Day + "." + pocetak.Month + "." + pocetak.Year + " - "
                + kraj.Day + "." + kraj.Month + "." + kraj.Year;
            kafic = odabraniKafic;
        }

        private void frmIzvjestaKonobarPeriod_Load(object sender, EventArgs e)
        {
            this.DataSetStatistika.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'DataSetStatistika.DataTableKonobar' table. You can move, or remove it, as needed.
            this.DataTableKonobarTableAdapter.Fill(this.DataSetStatistika.DataTableKonobar,pocetak,kraj,kafic.ID_Kafic);

            this.reportViewer1.RefreshReport();
        }
    }
}
