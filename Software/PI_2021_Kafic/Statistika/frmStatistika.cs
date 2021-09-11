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
    public partial class frmStatistika : Form
    {
        private Kafic kafic;
        private Konobar odabraniKonobar;
        public frmStatistika(Kafic odabraniKafic)
        {
            InitializeComponent();
            kafic = odabraniKafic;
            PopuniCMB();
        }

        private void PopuniCMB()
        {
            using (var context = new Entities())
            {
                var query = from k in context.Konobar
                            where k.Kafic_ID == kafic.ID_Kafic
                            orderby k.ID_Konobar
                            select k;
                cmbKonobar.DataSource = query.ToList();
            }
        }

        private void frmStatistika_Load(object sender, EventArgs e)
        {

        }

        private void btnX_Click(object sender, EventArgs e)
        {
            frmIzvjestajX frm = new frmIzvjestajX(odabraniKonobar);
            frm.ShowDialog();
        }

        private void cmbKonobar_SelectedIndexChanged(object sender, EventArgs e)
        {
            odabraniKonobar = cmbKonobar.SelectedItem as Konobar;
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            frmIzvjestajZ frm = new frmIzvjestajZ(kafic);
            frm.ShowDialog();
        }

        private void btnPeriod_Click(object sender, EventArgs e)
        {
            frmIzvjestajPeriod frm = new frmIzvjestajPeriod(dateTimePicker1.Value, dateTimePicker2.Value);
            frm.ShowDialog();
        }

        private void btnArtikl_Click(object sender, EventArgs e)
        {
            frmIzvjestajArtikl frm = new frmIzvjestajArtikl(dateTimePicker1.Value, dateTimePicker2.Value,kafic);
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmIzvjestaKonobarPeriod frm = new frmIzvjestaKonobarPeriod(dateTimePicker1.Value, dateTimePicker2.Value,kafic);
            frm.ShowDialog();
        }
    }
}
