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
    public partial class frmNamirniceMain : Form
    {
        private Kafic kafic;
        private Namirnica odabranaNamirnica;
        public frmNamirniceMain(Kafic odabraniKafic)
        {
            InitializeComponent();
            kafic = odabraniKafic;
        }

        private void frmNamirniceMain_Load(object sender, EventArgs e)
        {
            OsvjeziListu();
            PopuniMjere();
        }

        private void PopuniMjere()
        {
            List<string> lista = new List<string>();
            lista.Add("g");
            lista.Add("l");
            lista.Add("komad");
            cmbMjera.DataSource = lista;
        }

        private void OsvjeziListu()
        {
            lbNamirnice.DataSource = DohvatiNamirnice();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmDodajNamirnicu frmDodaj = new frmDodajNamirnicu(kafic);
            frmDodaj.ShowDialog();
            OsvjeziListu();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DohvatiNamirnicu() != null)
            {
                Namirnica namirnica = DohvatiNamirnicu();
                using (var context = new Entities())
                {
                    context.Namirnica.Attach(namirnica);
                    context.Namirnica.Remove(namirnica);
                    context.SaveChanges();
                }
            }
            OsvjeziListu();
        }

        private Namirnica DohvatiNamirnicu()
        {
            if (lbNamirnice.SelectedItem != null)
                return lbNamirnice.SelectedItem as Namirnica;
            else return null;
        }

        private void lbNamirnice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DohvatiNamirnicu() != null)
            {
                using (var context = new Entities())
                {
                    Namirnica dohvacenaNamirnica = DohvatiNamirnicu();

                    context.Namirnica.Attach(dohvacenaNamirnica);
                    txtNaziv.Text = dohvacenaNamirnica.Naziv_Namirnice;
                    cmbMjera.Text = dohvacenaNamirnica.Mjera;
                    odabranaNamirnica = dohvacenaNamirnica;
                }
            }
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            if (DohvatiNamirnicu() != null)
            using (var context = new Entities())
            {
                
                Namirnica dohvacenaNamirnica = DohvatiNamirnicu();
                    context.Namirnica.Attach(dohvacenaNamirnica);
                    dohvacenaNamirnica.Naziv_Namirnice = txtNaziv.Text;
                    dohvacenaNamirnica.Mjera = cmbMjera.Text;
                    context.SaveChanges();

            }
            OsvjeziListu();
        }

        private void frmNamirniceMain_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            PomocneFunkcije.PomocneFunkcije.HelpFormNamirnice();
        }
    }
}
