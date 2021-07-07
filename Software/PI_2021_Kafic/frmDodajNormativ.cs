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
    public partial class frmDodajNormativ : Form
    {
        private Kafic kafic;
        private Normativ noviNormativ;
        private Namirnica odabranaNamirnica;
        private Stavka_normativa odabranaStavka;
        private bool uredi = false;
        public frmDodajNormativ(Kafic odabraniKafic)
        {
            InitializeComponent();
            kafic = odabraniKafic;
            noviNormativ = new Normativ();
            noviNormativ.ID_normativ = DohvatiZadnjiNormativ()+1;
            noviNormativ.Kafic_ID = kafic.ID_Kafic;
            using (var context= new Entities())
            {
                context.Normativ.Add(noviNormativ);
                context.SaveChanges();
            }
            odabranaNamirnica = new Namirnica();
        }
        public frmDodajNormativ(Kafic odabraniKafic, Normativ normativToEdit)
        {
            InitializeComponent();
            kafic = odabraniKafic;
            noviNormativ = normativToEdit;
            odabranaNamirnica = new Namirnica();
            uredi = true;
        }
        private int DohvatiZadnjiNormativ()
        {
            using (var context = new Entities())
            {
                var query = from n in context.Normativ
                            select n;
                List<Normativ> lista = query.ToList();
                Normativ zadnjiNormativ = lista.Last<Normativ>();
                return zadnjiNormativ.ID_normativ;

                   
            }
        }

        private void cmbNamirnice_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(cmbNamirnice.SelectedItem as Namirnica != null)
            {
                odabranaNamirnica = cmbNamirnice.SelectedItem as Namirnica;
            }
        }

        private void frmDodajNormativ_Load(object sender, EventArgs e)
        {
            OsvjeziCMB();
            OsvjeziStavke();
            if (uredi)
            {
                btnDodajNormativ.Text = "Spremi izmjene";
                btnCancel.Text = "Odbaci izmjene";
                txtNaziv.Text = noviNormativ.Naziv;
            }
            nudKolicina.DecimalPlaces = 2;
            
        }

        private void OsvjeziCMB()
        {
            cmbNamirnice.DataSource = DohvatiNamirnice();
        }

        private List<Namirnica> DohvatiNamirnice()
        {
            List<Namirnica> lista = new List<Namirnica>();
            using (var context = new Entities())
            {
                var query = from n in context.Namirnica
                            where n.Kafic_ID == kafic.ID_Kafic
                            select n;
                lista = query.ToList();
            }
            return lista;
        }

        private void btnDodajStavku_Click(object sender, EventArgs e)
        {
            using (var context = new Entities())
            {
                var query = from s in context.Stavka_normativa
                            select s;
                int id = 0;
                List<Stavka_normativa> lista = query.ToList();
                Stavka_normativa zadnjaStavka = null;
                if (lista.Count>0) {
                zadnjaStavka = lista.Last<Stavka_normativa>();
                }
                if (zadnjaStavka != null)
                {
                    id = zadnjaStavka.ID_Stavka_normativa+1;
                }
                try {
                    if (nudKolicina.Value <= 0) throw new KriviUnosException("Kolicina namirnice mora biti vece od nula!");
                    else {
                        Stavka_normativa stavka = new Stavka_normativa
                        {
                            ID_Stavka_normativa = id,
                            Normativ_ID = noviNormativ.ID_normativ,
                            Namirnica_ID = odabranaNamirnica.ID_Namirnica,
                            Kolicina = (double)nudKolicina.Value
                        };
                        context.Stavka_normativa.Add(stavka);
                        context.SaveChanges();
                    }
                    
                }
                catch(KriviUnosException ob)
                {
                    MessageBox.Show(ob.DodatnaPoruka);
                }
                
                
            }
            OsvjeziStavke();
        }

        private void OsvjeziStavke()
        {
            lbStavkeNormativa.DataSource = DohvatiStavke();
        }

        private List<Stavka_normativa> DohvatiStavke()
        {
            using (var context = new Entities())
            {
                var query = from s in context.Stavka_normativa
                            where s.Normativ_ID == noviNormativ.ID_normativ
                            select s;
                List<Stavka_normativa> lista = query.ToList();
                return lista;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (uredi) Close();
            else {
                List<Stavka_normativa> stavke = DohvatiStavke();
                foreach (Stavka_normativa stavka in stavke)
                {
                    using (var context = new Entities())
                    {
                        context.Stavka_normativa.Attach(stavka);
                        context.Stavka_normativa.Remove(stavka);
                        context.SaveChanges();

                    }
                }
                using (var context = new Entities())
                {
                    context.Normativ.Attach(noviNormativ);
                    context.Normativ.Remove(noviNormativ);
                    context.SaveChanges();
                }
            }
            
            Close();
        }

        private void lbStavkeNormativa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbStavkeNormativa.SelectedItem!=null)
            {
                odabranaStavka = lbStavkeNormativa.SelectedItem as Stavka_normativa;
            }
        }

        private void btnRemoveStavka_Click(object sender, EventArgs e)
        {
            using (var context = new Entities())
            {
                context.Stavka_normativa.Attach(odabranaStavka);
                context.Stavka_normativa.Remove(odabranaStavka);
                context.SaveChanges();

            }
            OsvjeziStavke();
        }

        private void btnDodajNormativ_Click(object sender, EventArgs e)
        {
            
            try {
                if (txtNaziv.Text != null)
                    using (var context = new Entities())
                    {
                        context.Normativ.Attach(noviNormativ);
                        noviNormativ.Naziv = txtNaziv.Text;

                        context.SaveChanges();
                        
                    }
                else throw new KriviUnosException("Unesite polje za naziv");

            }
            catch(KriviUnosException ob)
            {
                MessageBox.Show(ob.DodatnaPoruka);
            }



            Close();
        }

        private void frmDodajNormativ_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            PomocneFunkcije.PomocneFunkcije.HelpDodajNormativ();
        }
    }
}
