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
    public partial class frmNarudzbe : Form
    {
        string testlbl;
        int brojac;
        private Konobar ulogiraniKonobar;
        private Kafic kafic;
        private Artikl odabraniArtikl;
        private Stavka_racuna stavkaZaObristati;
        private List<Stavka_racuna> stavkeArtikla;
        private Stol stol;
        private Racun racun;
        private bool firstLoad;
        UCStol upravljacStola;
        public frmNarudzbe(Konobar konobar, Kafic prosljedeniKafic, Stol prosljedeniStol,UCStol cStol)
        {
            InitializeComponent();
            ulogiraniKonobar = konobar;
            testlbl = ulogiraniKonobar.Ime + " " + ulogiraniKonobar.Prezime;
            brojac = 0;
            kafic = prosljedeniKafic;
            stavkeArtikla = new List<Stavka_racuna>();
            stol = prosljedeniStol;
            firstLoad = true;
            upravljacStola = cStol;
        }

        private void Narudzbe_Load(object sender, EventArgs e)
        {
            if (firstLoad) {
                racun = new Racun
                {
                    ID_Racun = DohvatiZadnjiID(),
                    Konobar_ID = ulogiraniKonobar.ID_Konobar,
                    Stol=stol.Oznaka_Stola,
                    Nacin_Placanja_ID = 1,
                    Ukupna_cijena = 0,
                    Kafic_ID = kafic.ID_Kafic

                };
                lblKonobar.Text = ulogiraniKonobar.Ime + " " + ulogiraniKonobar.Prezime + " " + brojac;
                using (var context = new Entities())
                {
                    context.Racun.Add(racun);
                    context.SaveChanges();
                }
                firstLoad = false;
                
            }
            lblKonobar.Text = "Konobar: "+ulogiraniKonobar.Ime + " " + ulogiraniKonobar.Prezime;
            
        }

        private int DohvatiZadnjiID()
        {
            List<Racun> lista;
            using (var context = new Entities())
            {
                var query = from r in context.Racun
                            select r;
                lista = query.ToList();
            }
            if (lista.Count > 0)
                return lista.Last<Racun>().ID_Racun + 1;
            else
                return 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            brojac++;
            lblKonobar.Text = ulogiraniKonobar.Ime + " " + ulogiraniKonobar.Prezime + brojac.ToString();

        }

        private void exit_Click(object sender, EventArgs e)
        {
            using (var context = new Entities())
            {
                foreach (Stavka_racuna stavka in stavkeArtikla)
                {
                    context.Stavka_racuna.Attach(stavka);
                    context.Stavka_racuna.Remove(stavka);
                    context.SaveChanges();

                }
                context.Racun.Attach(racun);
                context.Racun.Remove(racun);
                context.SaveChanges();
                upravljacStola.MakniNarudzbu();
                upravljacStola.MakniKonobara();
                upravljacStola.PromijeniBoju();
                Close();
            }


        }

        private void Narudzbe_Shown(object sender, EventArgs e)
        {
            if (brojac != 0)
                lblKonobar.Text = ulogiraniKonobar.Ime + " " + ulogiraniKonobar.Prezime + " " + brojac;

        }

        private void listboxMeni_ItemActivate(object sender, EventArgs e)
        {

            MessageBox.Show("Vrijednost je : " + sender.GetType().ToString());

        }


        private void pbTopliNapitci_Click(object sender, EventArgs e)
        {
            LoadWarmDrinks();
            lbArtikli.Text = "Topli napitci";
        }

        private void LoadWarmDrinks()
        {
            listboxMeni.DataSource = null;
            listboxMeni.DataSource = DohvatiToplaPica();







        }

        private List<Artikl> DohvatiToplaPica()
        {
            using (var context = new Entities())
            {
                var query = from a in context.Artikl.Include("Kategorija")
                            where a.Kategorija_ID == 1 && a.Kafic_ID==kafic.ID_Kafic
                            select a;
                return query.ToList();
            }
        }

        private void pbHladniNapitci_Click(object sender, EventArgs e)
        {
            listboxMeni.DataSource = null;
            listboxMeni.DataSource = DohvatiBezAlkoholnaPica();
            lbArtikli.Text = "Bezalkoholna pića";

        }

        private List<Artikl> DohvatiBezAlkoholnaPica()
        {
            using (var context = new Entities())
            {
                var query = from a in context.Artikl.Include("Kategorija")
                            where a.Kategorija_ID == 2 && a.Kafic_ID==kafic.ID_Kafic
                            select a;
                return query.ToList();
            }
        }

        public void promijeniKonobara(Konobar konobar)
        {
            ulogiraniKonobar = konobar;
        }

        private void listboxMeni_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listboxMeni.SelectedItem != null)
            {
                odabraniArtikl = listboxMeni.SelectedItem as Artikl;
            }

        }

        private void OsvjeziStavke()
        {
            lbRacun.DataSource = null;
            lbRacun.DataSource = stavkeArtikla;
        }

        private void listboxMeni_DoubleClick(object sender, EventArgs e)
        {
            if (!ProvjeriPostojanjeStavke(odabraniArtikl))
            {
                using (var context = new Entities())
                {
                    Stavka_racuna stavka = new Stavka_racuna
                    {
                        Artikl_ID = odabraniArtikl.ID_Artikl,
                        Racun_ID = racun.ID_Racun,
                        Količina = 1,
                        Cijena = odabraniArtikl.Cijena
                    }
                    ;
                    context.Stavka_racuna.Add(stavka);
                    context.SaveChanges();


                    stavkeArtikla.Add(stavka);
                    UpdateCijena();
                    OsvjeziStavke();
                }
            }
            else
            {
                using (var context = new Entities())
                {
                    var query = from s in context.Stavka_racuna.Include("Artikl")
                                where s.Artikl_ID == odabraniArtikl.ID_Artikl && s.Racun_ID==racun.ID_Racun
                                select s;
                    Stavka_racuna stavka = query.Single();
                    context.Stavka_racuna.Attach(stavka);
                    stavka.Količina++;
                    stavka.Cijena=stavka.Količina*stavka.Artikl.Cijena;
                    context.SaveChanges();
                    UpdateCijena();
                    OsvjeziStavke();
                }
            }
        }

        private void UpdateCijena()
        {
            lblUkupnaCijena.Text = "Ukupna cijena: " + IzracunajUkupnuCijenu(racun) + " kn";
        }

        private bool ProvjeriPostojanjeStavke(Artikl provjeriArtikl)
            {
                foreach (Stavka_racuna stavka in stavkeArtikla)
                {
                if (stavka.Artikl_ID == provjeriArtikl.ID_Artikl)
                    return true;
                }
            return false;
            }

            private void lbRacun_DoubleClick(object sender, EventArgs e)
            {
            if (stavkeArtikla.Count > 0) {
                using (var context = new Entities())
                {
                    context.Stavka_racuna.Attach(stavkaZaObristati);
                    context.Stavka_racuna.Remove(stavkaZaObristati);
                    context.SaveChanges();
                }
                stavkeArtikla.Remove(stavkaZaObristati);
                UpdateCijena();
                OsvjeziStavke();
            }
            
            }

            private void lbRacun_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (lbRacun.SelectedItem != null)
                {
                stavkaZaObristati = lbRacun.SelectedItem as Stavka_racuna;
                }
            }

        private void btnNaruci_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSpremiRacun_Click(object sender, EventArgs e)
        {
            if(stavkeArtikla.Count>0)
            {
                using (var context = new Entities())
                {
                    context.Racun.Attach(racun);
                    racun.ID = DohvatiDnevniID();
                    racun.Ukupna_cijena = IzracunajUkupnuCijenu(racun);
                    racun.Vrijeme = DateTime.Now;
                    racun.Konobar_ID = ulogiraniKonobar.ID_Konobar;
                    context.SaveChanges();

                }
                UpdateSkladiste();
                upravljacStola.MakniNarudzbu();
                upravljacStola.MakniKonobara();
                upravljacStola.PromijeniBoju();
                Close();
            }
        }

        private void UpdateSkladiste()
        {   
            using (var context = new Entities())
            {
                var query = from s in context.Stavka_racuna.Include("Artikl")
                            where s.Racun_ID == racun.ID_Racun
                            select s;
                List<Stavka_racuna> listaStavki = query.ToList();
                foreach (Stavka_racuna stavka in listaStavki)
                {
                    Normativ normativ = DohvatiNormativ(stavka);
                    var stavke = from n in context.Normativ.Include("Stavka_normativa")
                                 where n.ID_normativ == normativ.ID_normativ
                                 select n;
                    normativ = stavke.Single();
                    foreach(Stavka_normativa sNormativ in normativ.Stavka_normativa)
                    {
                        var upit = from s in context.Stavka_normativa.Include("Namirnica")
                                   where s.ID_Stavka_normativa == sNormativ.ID_Stavka_normativa
                                   select s;
                        Stavka_normativa odabranaStavka = upit.Single();
                        context.Namirnica.Attach(odabranaStavka.Namirnica);
                        odabranaStavka.Namirnica.Kolicina_na_skladistu = odabranaStavka.Namirnica.Kolicina_na_skladistu - (odabranaStavka.Kolicina*stavka.Količina);
                        context.SaveChanges();
                    }
                }
            }
           
        }

        private Normativ DohvatiNormativ(Stavka_racuna stavka)
        {
            using (var context = new Entities())
            {
                var upit = from s in context.Artikl.Include("Normativ")
                           where s.ID_Artikl == stavka.Artikl_ID
                           select s;
                Artikl artikl = upit.Single();
                return artikl.Normativ;
            }
        }

        private double IzracunajUkupnuCijenu(Racun racun)
        {
            double cijena = 0;
            using (var context = new Entities())
            {
                var query = from r in context.Racun.Include("Stavka_racuna")
                            where r.ID_Racun == racun.ID_Racun
                            select r;
                Racun nadeniRacun = query.Single();
                foreach(Stavka_racuna stavka in nadeniRacun.Stavka_racuna)
                {
                    cijena += stavka.Cijena;
                }
            }
            return cijena;
        }

        private int DohvatiDnevniID()
        {
            DateTime vrijeme = DateTime.Now;
            using (var context = new Entities())
            {
                var query = from r in context.Racun
                            where r.Vrijeme.Value.Day == vrijeme.Day && r.Vrijeme.Value.Month == vrijeme.Month
                            select r;
                var lista = query.ToList();
                if (lista.Count>0) return lista.Count + 1;
                else return 0;
                }

            }

        private void frmNarudzbe_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            PomocneFunkcije.PomocneFunkcije.HelpNarudzbe();
        }
    }
    } 

