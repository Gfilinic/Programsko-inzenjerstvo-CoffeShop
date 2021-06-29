using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_2021
{
    public partial class KaficManager : Form
    {
        private Poduzeće odabranoPoduzece;
        private Kafic kaficZaUrediti;
        private bool uredi = false;
        public KaficManager()
        {
            InitializeComponent();
        }
        public KaficManager(Kafic kafic)
        {
            InitializeComponent();

            kaficZaUrediti = kafic;
            uredi = true;
        }
        private void DodajKafic_Load(object sender, EventArgs e)
        {
            PopuniPoduzeca();
            if (uredi)
            {
                txtNaziv.Text = kaficZaUrediti.Naziv;
                cmbPoduzece.SelectedIndex = kaficZaUrediti.Poduzece_ID;
                btnAdd.Text = "Spremi promjene";
            }
        }

        private void PopuniPoduzeca()
        {
            using (var context = new Entities())
            {
                var query = from p in context.Poduzeće
                            select p;
                cmbPoduzece.DataSource = query.ToList();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!uredi) {
            Kafic noviKafic = new Kafic
            {
                ID_Kafic = DodajNoviKaficID(),
                Naziv = txtNaziv.Text,
                Poduzece_ID = odabranoPoduzece.ID_Poduzece
            };
            using (var context = new Entities())
            {
                context.Kafic.Add(noviKafic);
                context.SaveChanges();
            }
            }
            else
            {
                using (var context = new Entities())
                {
                    context.Kafic.Attach(kaficZaUrediti);
                    kaficZaUrediti.Naziv = txtNaziv.Text;
                    kaficZaUrediti.Poduzece_ID = odabranoPoduzece.ID_Poduzece;
                    context.SaveChanges();
                }
            }
           
            Close();
        }

        private int DodajNoviKaficID()
        {
            List<Kafic> lista;
            using (var context = new Entities())
            {
                var query = from k in context.Kafic
                            select k;
                lista = query.ToList();
                return lista.Last().ID_Kafic + 1;
            }
        }

        private void cmbPoduzece_SelectedIndexChanged(object sender, EventArgs e)
        {
            odabranoPoduzece = cmbPoduzece.SelectedItem as Poduzeće;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
