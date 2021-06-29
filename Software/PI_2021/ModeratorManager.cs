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
    public partial class ModeratorManager : Form
    {
        private Kafic kafic;
        private Moderator odabraniModerator;
        public ModeratorManager(Kafic prosljedeniKafic)
        {
            InitializeComponent();
            kafic = prosljedeniKafic;
        }

        private void ModeratorManager_Load(object sender, EventArgs e)
        {
            PopuniModeratore();
        }

        private void PopuniModeratore()
        {
            using (var context = new Entities())
            {
                var query = from m in context.Moderator
                            where m.Kafic_ID == kafic.ID_Kafic
                            select m;
                lbModeratori.DataSource = query.ToList();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ProvjeriPolja())
            {
                using (var context = new Entities())
                {
                    Moderator moderator = new Moderator
                    {
                        Kafic_ID = kafic.ID_Kafic,
                        Ime = txtIme.Text,
                        Prezime = txtPrezime.Text,
                        OIB = txtOIB.Text,
                        Datum_Pocetka = dtpPocetak.Value,
                        KorIme = txtKorime.Text,
                        Lozinka = txtPass.Text,
                        ID_Moderator = DodajNoviID()
                    };
                    context.Moderator.Add(moderator);
                    context.SaveChanges();
                    PopuniModeratore();
                }
            }
        }

        private int DodajNoviID()
        {
            List<Moderator> lista;
            using (var context = new Entities())
            {
                var query = from m in context.Moderator
                            select m;
                lista = query.ToList();
                return lista.Last<Moderator>().ID_Moderator + 1;
            }
        }

        private bool ProvjeriPolja()
        {
            try
            {
                if (txtIme.Text == "") throw new KriviUnosException("Polje ime mora biti popunjeno!");
                if (txtPrezime.Text=="") throw new KriviUnosException("Polje prezime mora biti popunjeno!");
                if (txtOIB.Text=="") throw new KriviUnosException("Polje OIB mora biti popunjeno!");
                if (txtKorime.Text=="") throw new KriviUnosException("Polje korisnickog imena mora biti popunjeno!");
                if (txtPass.Text=="") throw new KriviUnosException("Polje za lozinku mora biti popunjeno!");
            }
            catch (KriviUnosException ex)
            {

                MessageBox.Show(ex.DodatnaPoruka);
                return false;
            }
            return true;
        }

        private void lbModeratori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbModeratori.SelectedItem != null)
                odabraniModerator = lbModeratori.SelectedItem as Moderator;
            PopuniEdit();
        }

        private void PopuniEdit()
        {
            txtImeE.Text = odabraniModerator.Ime;
            txtPrezE.Text = odabraniModerator.Prezime;
            txtOIBE.Text = odabraniModerator.OIB;
            txtKorimeE.Text = odabraniModerator.KorIme;
            txtPassE.Text = odabraniModerator.Lozinka;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (odabraniModerator!=null)
            {
                if (MessageBox.Show("Jeste li sigurni da želite obrisati " + odabraniModerator.KorIme + "?", "Potvrdite brisanje", MessageBoxButtons.OKCancel) == DialogResult.OK) {
                    using (var context = new Entities())
                    {
                        context.Moderator.Attach(odabraniModerator);
                        context.Moderator.Remove(odabraniModerator);
                        context.SaveChanges();
                        PopuniModeratore();
                    }
                }
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (ProvjeriPoljaE())
            {
                using (var context = new Entities())
                {
                    context.Moderator.Attach(odabraniModerator);
                    odabraniModerator.Ime = txtImeE.Text;
                    odabraniModerator.Prezime = txtPrezE.Text;
                    odabraniModerator.Datum_Kraja = dtpKraj.Value;
                    odabraniModerator.KorIme = txtKorimeE.Text;
                    odabraniModerator.Lozinka = txtPassE.Text;
                    context.SaveChanges();
                    PopuniModeratore();
                }
            }
        }

        private bool ProvjeriPoljaE()
        {
            try
            {
                if (txtImeE.Text == "") throw new KriviUnosException("Polje ime mora biti popunjeno!");
                if (txtPrezE.Text == "") throw new KriviUnosException("Polje prezime mora biti popunjeno!");
                if (txtOIBE.Text == "") throw new KriviUnosException("Polje OIB mora biti popunjeno!");
                if (txtKorimeE.Text == "") throw new KriviUnosException("Polje korisnickog imena mora biti popunjeno!");
                if (txtPassE.Text == "") throw new KriviUnosException("Polje za lozinku mora biti popunjeno!");
            }
            catch (KriviUnosException ex)
            {

                MessageBox.Show(ex.DodatnaPoruka);
                return false;
            }
            return true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
