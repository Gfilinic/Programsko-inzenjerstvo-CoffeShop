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
            lbNormativ.DataSource = DohvatiNormativLista();
        }

        private List<Normativ> DohvatiNormativLista()
        {
            List<Normativ> lista = new List<Normativ>();
            using (var context = new Entities())
            {
                var query = from n in context.Normativ
                            
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
                Normativ Normativ = DohvatiNormativ();
                using (var context = new Entities())
                {
                    context.Normativ.Attach(Normativ);
                    context.Normativ.Remove(Normativ);
                    context.SaveChanges();
                }
            }
            OsvjeziListu();
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
            if (DohvatiNormativ() != null)
            using (var context = new Entities())
            {
                
                Normativ dohvacenNormativ = DohvatiNormativ();
                    context.Normativ.Attach(dohvacenNormativ);
                    
                    context.SaveChanges();

            }
            OsvjeziListu();
        }
    }
}
