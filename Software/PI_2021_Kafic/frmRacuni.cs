using Castle.Components.DictionaryAdapter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PomocneFunkcije;

namespace PI_2021_Kafic
{
    public partial class frmRacuni : Form
    {
        private Kafic kafic;
        private Racun odabraniRacun=null;
        private Namirnica odabranaNamirnica = null;
        private Artikl odabraniArtikl = null;
        private bool firstLoad = true;
        public frmRacuni(Kafic prosljedeniKafic)
        {
            InitializeComponent();
            kafic = prosljedeniKafic;
        }

        private void frmRacuni_Load(object sender, EventArgs e)
        {
            dtpOd.Value = DateTime.Today;
            dtpDo.Value = DateTime.Today;
            OsvjeziRacune();
            PopuniNamirnice();
            PopuniArtikle();
            
        }

        private void PopuniArtikle()
        {
            using (var context = new Entities())
            {
                var query = from a in context.Artikl
                            where a.Kafic_ID == kafic.ID_Kafic
                            select a;
                cmbArtikli.DataSource = query.ToList();
                cmbArtikli.SelectedIndex = -1;
            }
        }

        private void PopuniNamirnice()
        {
            using (var context = new Entities())
            {
                var query = from n in context.Namirnica
                            where n.Kafic_ID == kafic.ID_Kafic
                            select n;
                cmbNamirnice.DataSource = query.ToList();
                cmbNamirnice.SelectedIndex = -1;
                firstLoad = false;
            }
        }

        private void OsvjeziRacune()
        {
            
            using (var context=new Entities())
            {
                var query = from r in context.Racun.Include("Stavka_racuna").Include("Konobar").Include("Nacin_Placanja")
                            where r.Kafic_ID == kafic.ID_Kafic
                            && r.Vrijeme.Value.Day >= dtpOd.Value.Day && r.Vrijeme.Value.Month >= dtpOd.Value.Month
                            && r.Vrijeme.Value.Day <= dtpDo.Value.Day && r.Vrijeme.Value.Month <= dtpDo.Value.Month
                            orderby r.Vrijeme
                            select r;
                
                dgvRacuni.DataSource = query.ToList();
                dgvRacuni.Columns["Kafic"].Visible = false;
                dgvRacuni.Columns["Stavka_racuna"].Visible = false;
                dgvRacuni.Columns["Nacin_Placanja_ID"].Visible = false;
                dgvRacuni.Columns["Konobar_ID"].Visible = false;
                dgvRacuni.Columns["Kafic_ID"].Visible = false;
                dgvRacuni.Columns["ID_Racun"].Visible = false;
                dgvRacuni.Columns["Nacin_Placanja"].HeaderText = "Nacin plaćanja";
                dgvRacuni.Columns["Ukupna_cijena"].HeaderText = "Iznos računa";

            }
        }

        private void dtpOd_ValueChanged(object sender, EventArgs e)
        {
            OsvjeziRacune();
            dgvDetalji.DataSource = null;
            cmbNamirnice.SelectedIndex = -1;
        }

        private void dtpDo_ValueChanged(object sender, EventArgs e)
        {
            OsvjeziRacune();
            dgvDetalji.DataSource = null;
            cmbNamirnice.SelectedIndex = -1;
        }

        private void dgvRacuni_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            

        }

        private void dgvRacuni_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRacuni.CurrentRow != null) {
                odabraniRacun = dgvRacuni.CurrentRow.DataBoundItem as Racun;
                PopuniStavke();
            }

        }

        private void PopuniStavke()
        {
            using (var context = new Entities())
            {
                var query = from s in context.Stavka_racuna.Include("Artikl")
                            where odabraniRacun.ID_Racun == s.Racun_ID
                            select s;
                dgvDetalji.DataSource = query.ToList();
                
                dgvDetalji.Columns["Racun_ID"].Visible = false;
                dgvDetalji.Columns["Artikl_ID"].Visible = false;
                dgvDetalji.Columns["Racun"].Visible = false;
                dgvDetalji.Columns["Artikl"].DisplayIndex = 0;
                dgvDetalji.Columns["Cijena"].DisplayIndex = 1;
                dgvDetalji.Columns["Količina"].DisplayIndex = 2;



            }
        }

        private void cmbArtikli_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbArtikli.SelectedItem != null)
            {
                odabraniArtikl = cmbArtikli.SelectedItem as Artikl;
                if (odabraniArtikl != null)
                {
                    if (cmbArtikli.SelectedIndex > -1 && firstLoad == false) {
                        PopuniPredvidanjeArtikla();
                    }
                }
            }
        }

        private void PopuniPredvidanjeArtikla()
        {
            int brojac = 0;
            int brDana = 0;
            using (var context = new Entities())
            {
                var racuni = from r in context.Racun.Include("Stavka_racuna").Include("Konobar").Include("Nacin_Placanja")
                             where r.Kafic_ID == kafic.ID_Kafic &&
                             r.Vrijeme.Value.Day >= dtpOd.Value.Day && r.Vrijeme.Value.Month >= dtpOd.Value.Month
                             && r.Vrijeme.Value.Day <= dtpDo.Value.Day && r.Vrijeme.Value.Month <= dtpDo.Value.Month
                             orderby r.Vrijeme
                             select r;
                foreach (Racun racun in racuni.ToList())
                {
                    foreach (Stavka_racuna stavka in racun.Stavka_racuna)
                    {
                        var pronadiStavku = from s in context.Stavka_racuna.Include("Artikl")
                                            where s.Artikl_ID == stavka.Artikl_ID && s.Racun_ID == stavka.Racun_ID
                                            select s;
                        Stavka_racuna odabranaStavka = pronadiStavku.Single();
                        var pronadiArtikl = from a in context.Artikl.Include("Normativ")
                                            where a.ID_Artikl == odabranaStavka.Artikl_ID
                                            select a;
                        if (pronadiArtikl.ToList().Count > 0) {
                        Artikl pronadeniArtikl = pronadiArtikl.Single();
                        if(pronadeniArtikl.ID_Artikl == odabraniArtikl.ID_Artikl)
                            {
                                brojac += stavka.Količina;
                            } 
                            
                        }
                        
                        

                    }
                }
                TimeSpan proteklovrijeme = dtpDo.Value - dtpOd.Value;
                brDana = proteklovrijeme.Days;
                if (brDana == 0) brDana = 1;
                if (brojac != 0)
                {

                    double rezultat = PomocneFunkcije.PomocneFunkcije.IzracunajProsjek(brojac, brDana);
                    txtProsjek.Text = rezultat.ToString();
                    txtPredvidanje.Text = (rezultat * 7).ToString();
                }
                else
                {
                    txtProsjek.Text = "0";
                    txtPredvidanje.Text = "0";
                }
                
            }
        }

        private void PopuniPredvidanje()
        {
            txtKolicina.Text = odabranaNamirnica.Kolicina_na_skladistu.ToString();
            txtAvg.Text = IzracunajProsjek(odabranaNamirnica).ToString();
            txtOstalo.Text = (odabranaNamirnica.Kolicina_na_skladistu/ (double)IzracunajProsjek(odabranaNamirnica)).ToString();

        }

        private double IzracunajProsjek(Namirnica namirnica)
        {
            int brojac = 0;
            int brDana = 0;
            using (var context = new Entities())
            {
                var racuni = from r in context.Racun.Include("Stavka_racuna").Include("Konobar").Include("Nacin_Placanja")
                             where r.Kafic_ID == kafic.ID_Kafic &&
                             r.Vrijeme.Value.Day >= dtpOd.Value.Day && r.Vrijeme.Value.Month >= dtpOd.Value.Month
                             && r.Vrijeme.Value.Day <= dtpDo.Value.Day && r.Vrijeme.Value.Month <= dtpDo.Value.Month
                             orderby r.Vrijeme
                             select r;
                foreach(Racun racun in racuni.ToList())
                {
                    foreach(Stavka_racuna stavka in racun.Stavka_racuna)
                    {
                        var pronadiStavku = from s in context.Stavka_racuna.Include("Artikl")
                                            where s.Artikl_ID == stavka.Artikl_ID && s.Racun_ID == stavka.Racun_ID
                                            select s;
                        Stavka_racuna odabranaStavka = pronadiStavku.Single();
                        var pronadiArtikl = from a in context.Artikl.Include("Normativ")
                                            where a.ID_Artikl == odabranaStavka.Artikl_ID
                                            select a;
                        Artikl pronadeniArtikl = pronadiArtikl.Single();
                        var pronadiNormativ = from n in context.Normativ.Include("Stavka_normativa")
                                              where n.ID_normativ == pronadeniArtikl.Normativ_ID
                                              select n;
                        if (pronadiNormativ.ToList().Count>0) {
                            Normativ pronadeniNormativ = pronadiNormativ.Single();
                            foreach (Stavka_normativa stavka_Normativa in pronadeniNormativ.Stavka_normativa)
                                if (stavka_Normativa.Namirnica_ID == odabranaNamirnica.ID_Namirnica) brojac += stavka.Količina;
                        }
                        
                    }
                }
                TimeSpan proteklovrijeme = dtpDo.Value - dtpOd.Value;
                brDana = proteklovrijeme.Days;
                if (brDana == 0) brDana = 1;
                if (brojac != 0)
                {
                    return (double)brojac / brDana;
                }
                else return 0;
            }
        }

        private void cmbNamirnice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamirnice.SelectedItem != null)
            {
                odabranaNamirnica = cmbNamirnice.SelectedItem as Namirnica;
                if (odabranaNamirnica != null)
                {
                    if (cmbNamirnice.SelectedIndex > -1 && firstLoad == false)
                        PopuniPredvidanje();
                }
            }
        }

        private void btnPregledaj_Click(object sender, EventArgs e)
        {
            frmPotrosnja potrosnja = new frmPotrosnja(kafic, dtpOd.Value, dtpDo.Value);
            potrosnja.ShowDialog();
        }

        private void frmRacuni_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Helper.GetHelp(this);

        }
    }
}
