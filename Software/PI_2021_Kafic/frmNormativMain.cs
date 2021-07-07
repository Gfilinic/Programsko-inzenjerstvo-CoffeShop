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
    public partial class frmNormativMain : Form
    {
        private Kafic kafic;
        private Normativ odabranaNormativ;
        public frmNormativMain(Kafic odabraniKafic)
        {
            InitializeComponent();
            kafic = odabraniKafic;
        }

        private void frmNamirniceMain_Load(object sender, EventArgs e)
        {
            OsvjeziListu();
            
        }

        private void OsvjeziListu()
        {
            lbNormativ.DataSource = null;
            lbNormativ.DataSource = DohvatiNormativLista();
        }

        private List<Normativ> DohvatiNormativLista()
        {
            List<Normativ> lista = new List<Normativ>();
            using (var context = new Entities())
            {
                var query = from n in context.Normativ
                            where n.Kafic_ID==kafic.ID_Kafic
                            select n;
                lista = query.ToList();
            }
            return lista;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmDodajNormativ frmDodaj = new frmDodajNormativ(kafic);
            frmDodaj.ShowDialog();
            OsvjeziListu();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DohvatiNormativ() != null)
            {
                Normativ normativ = DohvatiNormativ();
                MakniNormativZaArtikle(normativ);

                using (var context=new Entities())
                {
                    var query = from stavka in context.Stavka_normativa
                                where stavka.Normativ_ID == normativ.ID_normativ
                                select stavka;
                    List<Stavka_normativa> listaStavki = query.ToList();
                    foreach (Stavka_normativa stavka_ in listaStavki)
                    {
                        context.Stavka_normativa.Attach(stavka_);
                        context.Stavka_normativa.Remove(stavka_);
                        context.SaveChanges();
                    }
                }
                using (var context = new Entities())
                {
                    context.Normativ.Include("Stavka_normativa");
                    context.Normativ.Attach(normativ);
                    context.Normativ.Remove(normativ);
                    context.SaveChanges();
                }
            }
            OsvjeziListu();
        }

        private void MakniNormativZaArtikle(Normativ normativ)
        {
            using (var context = new Entities())
            {
                var query = from a in context.Artikl.Include("Normativ")
                            select a;
                foreach (Artikl artikl in query.ToList())
                {
                    if(artikl.Normativ_ID==normativ.ID_normativ)
                    {
                        context.Artikl.Attach(artikl);
                        artikl.Normativ_ID = null;
                        context.SaveChanges();
                    }
                }
            }
        }

        private Normativ DohvatiNormativ()
        {
            if (lbNormativ.SelectedItem != null)
                return lbNormativ.SelectedItem as Normativ;
            else return null;
        }

        private void lbNamirnice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DohvatiNormativ() != null)
            {
                using (var context = new Entities())
                {
                    Normativ dohvacenNormativ = DohvatiNormativ();

                    context.Normativ.Attach(dohvacenNormativ);
                    
                    odabranaNormativ = dohvacenNormativ;
                }
            }
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            if (DohvatiNormativ() != null) {
                frmDodajNormativ frmDodajNormativ = new frmDodajNormativ(kafic, DohvatiNormativ());
                frmDodajNormativ.ShowDialog();
            }
           
                
               
            
            OsvjeziListu();
        }

        private void frmNormativMain_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            PomocneFunkcije.PomocneFunkcije.HelpNormativMain();
        }
    }
}
