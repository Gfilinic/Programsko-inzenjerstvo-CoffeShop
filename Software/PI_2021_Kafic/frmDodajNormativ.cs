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
        Normativ noviNormativ;
        public frmDodajNormativ(Kafic odabraniKafic)
        {
            InitializeComponent();
            kafic = odabraniKafic;
            noviNormativ = new Normativ();
            
        }

        private void cmbNamirnice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmDodajNormativ_Load(object sender, EventArgs e)
        {
            OsvjeziCMB();
            textBox1.Text = noviNormativ.ID_normativ.ToString();
            //DOhvatizadnji normativ i dodaj mu +1 na id da dobijes id novog;
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
    }
}
