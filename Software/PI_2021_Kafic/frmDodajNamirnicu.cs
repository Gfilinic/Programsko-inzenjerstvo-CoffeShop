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
    public partial class frmDodajNamirnicu : Form
    {
        private Kafic kafic;
        public frmDodajNamirnicu(Kafic odabraniKafic)
        {
            InitializeComponent();
            kafic = odabraniKafic;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            using (var context = new Entities())
            {
                var query = from n in context.Namirnica
                            where n.Kafic_ID == kafic.ID_Kafic
                            select n;
                List<Namirnica> lista = query.ToList();
                Namirnica zadnjaNamirnica = lista.Last<Namirnica>();

                Namirnica novaNamirnica = new Namirnica
                {
                    ID_Namirnica = zadnjaNamirnica.ID_Namirnica + 1,
                    Naziv_Namirnice = txtNaziv.Text,
                    Kafic_ID = kafic.ID_Kafic,
                    Skladiste_ID = kafic.ID_Kafic,
                    Mjera = cmbMjera.Text
                    
                };
                context.Namirnica.Add(novaNamirnica);
                context.SaveChanges();
            }
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void frmDodajNamirnicu_Load(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();
            lista.Add("g");
            lista.Add("l");
            lista.Add("komad");
            cmbMjera.DataSource = lista;
        }

        private void frmDodajNamirnicu_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            PomocneFunkcije.PomocneFunkcije.HelpDodajNamirnicu();
        }
    }
}
