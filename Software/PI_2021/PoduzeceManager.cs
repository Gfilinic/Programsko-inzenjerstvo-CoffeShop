using PI_2021_Kafic;
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
    public partial class PoduzeceManager : Form
    {
        private Poduzeće odabranoPoduzece;
        public PoduzeceManager()
        {
            InitializeComponent();
            PopuniPoduzeca();
        }

        private void PopuniPoduzeca()
        {
            using (var context = new Entities())
            {
                var query = from p in context.Poduzeće
                            select p;
                lbPoduzece.DataSource = query.ToList();
            }
        }

        private void lbPoduzece_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbPoduzece.SelectedItem!=null)
            {
                odabranoPoduzece = lbPoduzece.SelectedItem as Poduzeće;
            }
            PopuniEdit();
        }

        private void PopuniEdit()
        {
            txtNazivE.Text = odabranoPoduzece.Naziv;
            txtVlasnikE.Text = odabranoPoduzece.Vlasnik;
            txtOIBe.Text = odabranoPoduzece.OIB;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ProvjeriPolja()) {
                Poduzeće poduzeće = new Poduzeće
                {
                    ID_Poduzece = DodajNoviID(),
                    Naziv = txtNaziv.Text,
                    Vlasnik = txtVlasnik.Text,
                    OIB = txtOIB.Text
                };
                using (var context = new Entities())
                {
                    context.Poduzeće.Add(poduzeće);
                    context.SaveChanges();
                }
                PopuniPoduzeca();
            }
        }

        private int DodajNoviID()
        {
            List<Poduzeće> lista;
            using (var context = new Entities())
            {
                var query = from p in context.Poduzeće
                            select p;
                lista = query.ToList();
                return lista.Last().ID_Poduzece + 1;
            }
        }

        private bool ProvjeriPolja()
        {
            try
            {
                if (txtNaziv.Text == "") throw new KriviUnosException("Polje za naziv mora biti popunjeno!");
                if (txtVlasnik.Text == "") throw new KriviUnosException("Polje za vlasnika mora biti popunjeno!");
                if (txtOIB.Text == "") throw new KriviUnosException("Polje za OIB mora biti popunjeno!");


            }
            catch (KriviUnosException ex)
            {
                MessageBox.Show(ex.DodatnaPoruka);
                return false;
                throw;
            }
            return true;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (ProvjeriPoljaE()) {
                using (var context = new Entities())
                {
                    context.Poduzeće.Attach(odabranoPoduzece);
                    odabranoPoduzece.Naziv = txtNazivE.Text;
                    odabranoPoduzece.Vlasnik = txtVlasnikE.Text;
                    odabranoPoduzece.OIB = txtOIBe.Text;
                    context.SaveChanges();
                }
                PopuniPoduzeca();
            }
        }

        private bool ProvjeriPoljaE()
        {
            try
            {
                if (txtNazivE.Text == "") throw new KriviUnosException("Polje za naziv mora biti popunjeno!");
                if (txtVlasnikE.Text == "") throw new KriviUnosException("Polje za vlasnika mora biti popunjeno!");
                if (txtOIBe.Text == "") throw new KriviUnosException("Polje za OIB mora biti popunjeno!");


            }
            catch (KriviUnosException ex)
            {
                return false;
                throw;
            }
            return true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (odabranoPoduzece != null)
            {
                if (MessageBox.Show("Jeste li sigurni da želite obrisati " + odabranoPoduzece.Naziv + "?", "Potvrdite brisanje", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    using (var context = new Entities())
                    {
                        context.Poduzeće.Attach(odabranoPoduzece);
                        context.Poduzeće.Remove(odabranoPoduzece);
                        context.SaveChanges();
                        PopuniPoduzeca();
                    }
                }
            }
        }
    }
}
