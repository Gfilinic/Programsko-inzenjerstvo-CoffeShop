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
    public partial class frmUpravljanjeKonobarima : Form
    {
        private Kafic kafic;
        private Konobar odabraniKonobar;
        public frmUpravljanjeKonobarima(Kafic prosljedenikafic)
        {
            InitializeComponent();
            kafic = prosljedenikafic;
        }

       

        private void frmUpravljanjeKonobarima_Load(object sender, EventArgs e)
        {
            OsvjeziListu();
        }

        private void OsvjeziListu()
        {
            lbKonobari.DataSource = DohvatiKonobare();

        }

        private List<Konobar> DohvatiKonobare()
        {
            using (var context = new Entities())
            {
                var query = from k in context.Konobar
                            where k.Kafic_ID == kafic.ID_Kafic
                            select k;
                return query.ToList();
            }
        }

        private void lbKonobari_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbKonobari.SelectedItem != null)
                odabraniKonobar = lbKonobari.SelectedItem as Konobar;
            if (odabraniKonobar != null) FillEdit();
        }

        private void FillEdit()
        {
            txtImeE.Text = odabraniKonobar.Ime;
            txtPrezimeE.Text = odabraniKonobar.Prezime;
            txtOIBE.Text = odabraniKonobar.OIB;
            txtPassE.Text = odabraniKonobar.Sifra;
            if (odabraniKonobar.Voditelj == 1) cbVoditeljE.Checked = true;
            else cbVoditeljE.Checked = false;
            
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (ProvjeriPolja()) {
            Konobar konobar = new Konobar();
            konobar.ID_Konobar = DodajKonobarID();
            konobar.Ime = txtIme.Text;
            konobar.Prezime = txtPrezime.Text;
            konobar.OIB = txtOIB.Text;
            konobar.Kafic_ID = kafic.ID_Kafic;
            konobar.Sifra = txtPass.Text;
            konobar.Datum_Pocetka = dtpPocetak.Value;
            if (cbVoditelj.Checked) konobar.Voditelj = 1;
            else konobar.Voditelj = 0;
            using (var context = new Entities())
            {
                context.Konobar.Add(konobar);
                context.SaveChanges();
            }
            OsvjeziListu();
            txtIme.Clear();
            txtPrezime.Clear();
            txtPass.Clear();
            txtOIB.Clear();
            cbVoditelj.Checked = false;
            }
           
        }

        private int DodajKonobarID()
        {
            List<Konobar> lista;
            using (var context = new Entities())
            {
                var query = from k in context.Konobar
                            select k;
                lista = query.ToList();
                return lista.Last().ID_Konobar + 1;
            }
        }

        private bool ProvjeriPolja()
        {
            try
            {
                if (txtIme.Text == "") throw new KriviUnosException("Polje za ime mora biti ispunjeno!");
                if (txtPrezime.Text == "") throw new KriviUnosException("Polje za prezime mora biti ispunjeno!");
                if (dtpPocetak.Value==null) throw new KriviUnosException("Polje za pocetak rada mora biti ispunjeno!");
                if (txtPass.Text == "") throw new KriviUnosException("Polja za sifru mora biti ispunjeno!");
            }
            catch (KriviUnosException ex)
            {
                MessageBox.Show(ex.DodatnaPoruka);

                return false;
            }
            return true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (odabraniKonobar != null)
            {
                using (var context = new Entities())
                {
                    context.Konobar.Attach(odabraniKonobar);
                    context.Konobar.Remove(odabraniKonobar);
                    context.SaveChanges();
                }
            }
            OsvjeziListu();

        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            if (ProvjeriPoljaE())
            {
                using (var context= new Entities())
                {
                    context.Konobar.Attach(odabraniKonobar);
                    odabraniKonobar.Ime = txtImeE.Text;
                    odabraniKonobar.Prezime = txtPrezimeE.Text;
                    odabraniKonobar.Sifra = txtPassE.Text;
                    odabraniKonobar.OIB = txtOIBE.Text;
                    if (cbVoditeljE.Checked) odabraniKonobar.Voditelj = 1;
                    else odabraniKonobar.Voditelj = 0;
                    context.SaveChanges();
                }
                OsvjeziListu();
            }
        }

        private bool ProvjeriPoljaE()
        {
            try
            {
                if (txtImeE.Text == "") throw new KriviUnosException("Polje za ime mora biti ispunjeno!");
                if (txtPrezimeE.Text == "") throw new KriviUnosException("Polje za prezime mora biti ispunjeno!");
                if (txtPassE.Text == "") throw new KriviUnosException("Polja za sifru mora biti ispunjeno!");
            }
            catch (KriviUnosException ex)
            {
                MessageBox.Show(ex.DodatnaPoruka);

                return false;
            }
            return true;
        }

        private void frmUpravljanjeKonobarima_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            PomocneFunkcije.PomocneFunkcije.HelpUpravljanjeKonobarima();
        }
    }
}
