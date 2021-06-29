using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_2021_Kafic
{
    public partial class frmArtiklMain : Form
    {
        private Kafic kafic;
        

        public frmArtiklMain(Kafic odabraniKafic)
        {
            InitializeComponent();
            kafic = odabraniKafic;
        }

        private void frmArtiklMain_Load(object sender, EventArgs e)
        {
            
            PopuniKategorije();
            OsvjeziListu();
        }

        private void PopuniKategorije()
        {
            cmbKategorija.DataSource = DohvatiKategorije();
        }

        private List<Kategorija> DohvatiKategorije()
        {
            using (var context = new Entities())
            {
                var query = from k in context.Kategorija
                            select k;
                return query.ToList();
            }
        }

        private void OsvjeziListu()
        {
            lbArtikli.DataSource = DohvatiArtikl();
        }

        private List<Artikl> DohvatiArtikl()
        {
            using (var context = new Entities())
            {
                var query = from a in context.Artikl.Include("Kategorija")
                            where a.Kafic_ID == kafic.ID_Kafic 
                            select a;
                return query.ToList();
            }
        }

        private List<Artikl> DohvatiArtikle(Kategorija kategorija)
        {
            using (var context = new Entities())
            {
                var query = from a in context.Artikl.Include("Kategorija")
                            where a.Kafic_ID == kafic.ID_Kafic &&
                            a.Kategorija.Naziv == kategorija.Naziv
                            select a;
                return query.ToList();
            }
        }

        private void cmbKategorija_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKategorija.SelectedItem != null)
                
            OsvjeziListu(cmbKategorija.SelectedItem as Kategorija);
        }

        private void OsvjeziListu(Kategorija kategorija)
        {
            lbArtikli.DataSource= DohvatiArtikle(cmbKategorija.SelectedItem as Kategorija);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            OsvjeziListu();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmArtiklManager frmArtikl = new frmArtiklManager(kafic);
            frmArtikl.ShowDialog();
            OsvjeziListu();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Artikl odabraniArtikl = DohvatiOdabraniArtikl();
            if (
                odabraniArtikl!=null &&
                MessageBox.Show("Jeste li sigurni da želite obrisati " + odabraniArtikl.Naziv + "?", "Potvrdite brisanje", MessageBoxButtons.OKCancel)==DialogResult.OK
                )
            {
                using (var context = new Entities())
                {
                    context.Artikl.Attach(DohvatiOdabraniArtikl());
                    context.Artikl.Remove(DohvatiOdabraniArtikl());

                    context.SaveChanges();
                }
            }
           
            OsvjeziListu();
        }

        private Artikl DohvatiOdabraniArtikl()
        {
            if (lbArtikli.SelectedItem != null)
            {
                return lbArtikli.SelectedItem as Artikl;
            }
            else return null;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            Artikl odabraniArtikl = DohvatiOdabraniArtikl();
            if (odabraniArtikl != null) {
                frmArtiklManager artiklManager = new frmArtiklManager(kafic, odabraniArtikl);
                artiklManager.ShowDialog();


            }
            OsvjeziListu();

        }
    }
}
