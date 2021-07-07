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
    public partial class frmArtiklManager : Form
    {
        private Kafic kafic;
        private Kategorija odabranaKategorija;
        private Normativ odabraniNormativ;
        private Artikl odabraniArtikl;
        private bool uredi=false;
        public frmArtiklManager(Kafic prosljedeniKafic)
        {
            InitializeComponent();
            kafic = prosljedeniKafic;
        }

        public frmArtiklManager(Kafic prosljedeniKafic,Artikl prosljedeniArtikl)
        {
            InitializeComponent();
            kafic = prosljedeniKafic;
            odabraniArtikl = prosljedeniArtikl;
            uredi = true;
            

        }

        private void PopuniPodatke()
        {
            using (var context = new Entities())
            {
                var query = from a in context.Artikl.Include("Kategorija").Include("Normativ")
                            where odabraniArtikl.ID_Artikl == a.ID_Artikl
                            select a;
                odabraniArtikl = query.Single();
                            
            }
            txtNaziv.Text = odabraniArtikl.Naziv;
            txtCijena.Text = odabraniArtikl.Cijena.ToString();
            cmbKategorija.SelectedIndex = odabraniArtikl.Kategorija.ID_Kategorija - 1;
            cmbNormativ.SelectedIndex = DohvatiIndex();
            
        }

        private int DohvatiIndex()
        {
            List<Normativ> lista;
            using (var context = new Entities())
            {
                var query = from n in context.Normativ.Include("Artikl")
                            where n.Kafic_ID == kafic.ID_Kafic
                            select n;
                lista = query.ToList();
            }
            for (int i = 0; i < lista.Count; i++)
            {
                if(odabraniArtikl.Normativ!=null)
                if (lista[i].ID_normativ == odabraniArtikl.Normativ.ID_normativ)
                    return i;
            }
            return 0;

            
     }

        private void frmArtiklManager_Load(object sender, EventArgs e)
        {
            PopuniKategorije();
            PopuniNormative();
            if (uredi == true) PopuniPodatke();
            txtNaziv.Focus();
        }

        private void PopuniNormative()
        {
            using (var context = new Entities())
            {
                var query = from n in context.Normativ.Include("Artikl")
                            where n.Kafic_ID == kafic.ID_Kafic
                            select n;
                cmbNormativ.DataSource = query.ToList();
            }
        }

        private void PopuniKategorije()
        {
            using (var context = new Entities())
            {
                var query = from k in context.Kategorija.Include("Artikl")
                            select k;
                cmbKategorija.DataSource = query.ToList();
                            
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            ProvjeriPolja();
            
            using (var context = new Entities())
            {
                if (!uredi) {
                    Artikl noviArtikl = new Artikl
                    {
                        ID_Artikl = DodajNoviID(),
                        Kafic_ID = kafic.ID_Kafic,
                        Cijena = int.Parse(txtCijena.Text),
                        Naziv = txtNaziv.Text,
                        Kategorija_ID = odabranaKategorija.ID_Kategorija,
                        Normativ_ID = odabraniNormativ.ID_normativ,
                    };
                    context.Artikl.Add(noviArtikl);
                    MessageBox.Show(noviArtikl.ID_Artikl.ToString());
                    context.SaveChanges();
                }
                else
                {

                    context.Artikl.Attach(odabraniArtikl);
                    odabraniArtikl.Cijena = int.Parse(txtCijena.Text);
                    odabraniArtikl.Naziv = txtNaziv.Text;
                    odabraniArtikl.Kategorija_ID = odabranaKategorija.ID_Kategorija;
                    odabraniArtikl.Normativ_ID = odabraniNormativ.ID_normativ;
                    context.SaveChanges();
                }
               
                Close();
                
                
                 
            }
        }

        private int DodajNoviID()
        {
            List<Artikl> lista = new List<Artikl>();
            using (var context = new Entities())
            {
                var query = from a in context.Artikl
                            
                            select a;
                lista = query.ToList();
                return lista.Last<Artikl>().ID_Artikl + 1;
            }
        }

        private void ProvjeriPolja()
        {
            try
            {
                if (txtNaziv.Text == "") throw new KriviUnosException("Polje naziv mora biti nadopunjeno!");
            }
            catch (KriviUnosException ex)
            {
                MessageBox.Show(ex.DodatnaPoruka);
                
            }
            try
            {
                int.TryParse(txtCijena.Text, out int result);
                if (result==0) throw new KriviUnosException("Polje cijena mora biti numeričko!");
            }
            catch (KriviUnosException ex)
            {
                MessageBox.Show(ex.DodatnaPoruka);

            }
        }

        private void txtCijena_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNaziv_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbNormativ_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNormativ.SelectedItem != null)
                odabraniNormativ = cmbNormativ.SelectedItem as Normativ;
        }

        private void cmbKategorija_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKategorija.SelectedItem != null)
                odabranaKategorija = cmbKategorija.SelectedItem as Kategorija;
        }

        private void frmArtiklManager_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            PomocneFunkcije.PomocneFunkcije.HelpArtiklManager();
        }
    }
}
