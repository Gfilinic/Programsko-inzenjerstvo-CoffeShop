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
    public partial class frmOtpis : Form
    {
        private Kafic kafic;
        private Kategorija odabranaKategorija;
        private Artikl artikl;
        public frmOtpis(Kafic prosljedeniKafic)
        {
            InitializeComponent();
            kafic = prosljedeniKafic;
        }

        private void frmOtpis_Load(object sender, EventArgs e)
        {
            PrikaziSveArtikle();
            PopuniKategorije();
        }

        private void PopuniKategorije()
        {
            using (var context = new Entities())
            {
                var query = from k in context.Kategorija
                            select k;
                cmbKategorija.DataSource = query.ToList();
            }
        }

        private void PrikaziSveArtikle()
        {
            using (var context = new Entities())
            {
                var query = from a in context.Artikl.Include("Normativ")
                            where kafic.ID_Kafic == a.Kafic_ID
                            select a;
                lbArtikli.DataSource = query.ToList();
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            PrikaziSveArtikle();
        }

        private void cmbKategorija_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKategorija.SelectedItem != null) {
                odabranaKategorija = cmbKategorija.SelectedItem as Kategorija;
                PromijeniFilter(odabranaKategorija);
            }
        }

        private void PromijeniFilter(Kategorija odabranaKategorija)
        {
            using (var context = new Entities())
            {
                var query = from a in context.Artikl.Include("Normativ")
                            where kafic.ID_Kafic == a.Kafic_ID &&
                            a.Kategorija_ID == odabranaKategorija.ID_Kategorija
                            select a;
                lbArtikli.DataSource = query.ToList();
            }
        }

        private void btnOtpisi_Click(object sender, EventArgs e)
        {
            try {
                if (nUDKolicina.Value == 0) throw new KriviUnosException("Kolicina mora biti veca od 0!");
                if (artikl == null) throw new KriviUnosException("Nije odabran artikl!");
                else
                {
                    UpdateajSkladiste();
                    nUDKolicina.Value = 0;
                    MessageBox.Show("Uspješno ste otpisali: " + artikl.Naziv);
                }
            }
            catch(KriviUnosException ex)
            {
                MessageBox.Show(ex.DodatnaPoruka);
            }
            
        }

        private void UpdateajSkladiste()
        {
            using (var context = new Entities())
            {
                Normativ normativ = artikl.Normativ;
                var stavke = from n in context.Normativ.Include("Stavka_normativa")
                             where n.ID_normativ == normativ.ID_normativ
                             select n;
                normativ = stavke.Single();
                foreach (Stavka_normativa sNormativ in normativ.Stavka_normativa)
                {
                    var upit = from s in context.Stavka_normativa.Include("Namirnica")
                               where s.ID_Stavka_normativa == sNormativ.ID_Stavka_normativa
                               select s;
                    Stavka_normativa odabranaStavka = upit.Single();
                    context.Namirnica.Attach(odabranaStavka.Namirnica);
                    odabranaStavka.Namirnica.Kolicina_na_skladistu = odabranaStavka.Namirnica.Kolicina_na_skladistu - (double)nUDKolicina.Value;
                    context.SaveChanges();
                }
            }
            
            
        }

        private void lbNamirnice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbArtikli.SelectedItem != null)
            {
                artikl = lbArtikli.SelectedItem as Artikl;
                label2.Text = artikl.Naziv;
            }
        }

       

        private void frmOtpis_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            PomocneFunkcije.PomocneFunkcije.HelpOtpis();

        }
    }
}
