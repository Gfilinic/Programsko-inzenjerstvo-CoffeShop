using Microsoft.Reporting.WinForms;
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
    public partial class frmPotrosnja : Form
    {
        private Kafic kafic;
        private DateTime pocetak;
        private DateTime kraj;
        private bool firstLoad = true;
        private List<Namirnica> listaNamirnicaIstek;
        private List<ReportParameter> listaParametra = new List<ReportParameter>();

        public frmPotrosnja(Kafic prosljedeniKafic, DateTime od, DateTime dodate)
        {
            InitializeComponent();
            pocetak = od;
            kraj = dodate;
            kafic = prosljedeniKafic;
           
        }

        private void frmPotrosnja_Load(object sender, EventArgs e)
        {
            PopuniCMB();
            firstLoad = false;

        }

        private void PopuniLB()
        {
            
            using (var context = new Entities())
            {
                listaNamirnicaIstek = new List<Namirnica>();
                List<string> listaIsteka = new List<string>();
                List<Namirnica> listaNamirnica = PopuniNamirnice();
                foreach (Namirnica odabranaNamirnica in listaNamirnica)
                {
                    int brojac = 0;
                    int brDana = 0;
                    var racuni = from r in context.Racun.Include("Stavka_racuna").Include("Konobar").Include("Nacin_Placanja").Include("Stol")
                                 where r.Kafic_ID == kafic.ID_Kafic &&
                                 r.Vrijeme.Value.Day >= pocetak.Day && r.Vrijeme.Value.Month >= pocetak.Month
                                 && r.Vrijeme.Value.Day <= kraj.Day && r.Vrijeme.Value.Month <= kraj.Month
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
                            Artikl pronadeniArtikl = pronadiArtikl.Single();
                            var pronadiNormativ = from n in context.Normativ.Include("Stavka_normativa")
                                                  where n.ID_normativ == pronadeniArtikl.Normativ_ID
                                                  select n;
                            if (pronadiNormativ.ToList().Count > 0)
                            {
                                Normativ pronadeniNormativ = pronadiNormativ.Single();
                                foreach (Stavka_normativa stavka_Normativa in pronadeniNormativ.Stavka_normativa)
                                    if (stavka_Normativa.Namirnica_ID == odabranaNamirnica.ID_Namirnica) brojac += stavka.Količina;
                            }

                        }
                    }
                    TimeSpan proteklovrijeme = kraj - pocetak;
                    brDana = proteklovrijeme.Days;
                    if (brDana == 0) brDana = 1;
                    if (brojac != 0)
                    {
                        double prosjek = brojac / brDana;
                        if(prosjek * int.Parse(cmbPeriod.SelectedItem.ToString()) > odabranaNamirnica.Kolicina_na_skladistu) {
                            listaIsteka.Add(odabranaNamirnica.Naziv_Namirnice + " | Kolicina: " + odabranaNamirnica.Kolicina_na_skladistu + "| Prosjek: " + prosjek + "| Preostalo dana: "+ odabranaNamirnica.Kolicina_na_skladistu/prosjek);
                            listaNamirnicaIstek.Add(odabranaNamirnica);
                            
                            

                        }
                    }
                }
                ReportParameter parametar = new ReportParameter("period", cmbPeriod.SelectedItem.ToString() + " dana", true);
                reportNamirnice.LocalReport.SetParameters(parametar);
                reportNamirnice.RefreshReport();

                lbNamirnice.DataSource = listaIsteka;
            }
        }

        private List<Namirnica> PopuniNamirnice()
        {
            using (var context = new Entities())
            {
                var query = from n in context.Namirnica
                            where n.Kafic_ID == kafic.ID_Kafic
                            select n;
                return query.ToList();
            }
        }

        private void PopuniCMB()
        {
            List<int> lista = new List<int>();
            lista.Add(7);
            lista.Add(14);
            lista.Add(30);
            cmbPeriod.DataSource = lista;
            cmbPeriod.SelectedIndex = -1;
        }

        private void cmbPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!firstLoad)
            PopuniLB();
            NamirnicaBindingSource.DataSource = listaNamirnicaIstek;
            reportNamirnice.RefreshReport();

        }

        private void lbNamirnice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void reportNamirnice_Load(object sender, EventArgs e)
        {
            
        }


        private void frmPotrosnja_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            PomocneFunkcije.PomocneFunkcije.HelpPotrosnja();

        }
    }
}
