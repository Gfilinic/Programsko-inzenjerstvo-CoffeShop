using PI_2021;
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

    public partial class frmUpravljanje_Stolovima : Form
    {

        private Kafic kafic;
        bool first;
        frmMainKafic frm;
        bool update = false;
        bool refresh = false;
        public frmUpravljanje_Stolovima(Kafic prosljedenjiKafic,frmMainKafic mainKafic)
        {
            InitializeComponent();
            kafic = prosljedenjiKafic;

            OsvjeziListu();
            txtOznaka.Text = "";
            txtBrMjesta.Text = "";
            first = true;
            frm = mainKafic;
        }

        private void OsvjeziListu()
        {
            listboxStol.DataSource = UcitajStolove();
        }

        private List<Stol> UcitajStolove()
        {
            List<Stol> lista = new List<Stol>();
            using (var context = new Entities())
            {

                var query = from s in context.Stol
                            where s.Kafic_ID == kafic.ID_Kafic
                            orderby s.Broj_Mjesta
                            select s;
                lista = query.ToList();

            }
            return lista;
        }

        private void Upravljanje_Stolovima_Load(object sender, EventArgs e)
        {
            listboxStol.DataSource = UcitajStolove();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DohvatiOdabraniStol() != null)
            {
                Stol stol = DohvatiOdabraniStol();
                using (var context = new Entities())
                {
                    context.Stol.Attach(stol);
                    context.Stol.Remove(stol);

                    context.SaveChanges();
                    OsvjeziMjesta();

                }
            }
            OsvjeziListu();
        }

        private void OsvjeziMjesta()
        {
            using (var context = new Entities())
            {
                int brojac = 1;
                var query = from s in context.Stol
                            where s.Kafic_ID == kafic.ID_Kafic
                            orderby s.Broj_Mjesta
                            select s;
                List<Stol> listaStolova = query.ToList();
                foreach (Stol st in listaStolova)
                {
                    st.Broj_Mjesta = brojac;
                    brojac++;
                }
                context.SaveChanges();
            }

        }

        private Stol DohvatiOdabraniStol()
        {
            if (listboxStol.SelectedItem != null)
                return listboxStol.SelectedItem as Stol;
            else return null;
        }



        private void btnDodajNoviStol_Click(object sender, EventArgs e)
        {
            frmDodajNoviStol noviStol = new frmDodajNoviStol(kafic);
            noviStol.ShowDialog();
            OsvjeziListu();
        }

        private void frmUpravljanje_Stolovima_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Helper.GetHelp(this);

        }

        private void listboxStol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!first)
            {
                Stol stol = DohvatiOdabraniStol();
                PopuniPodatke(stol);
            }
            else first = false;
            update = false;




        }

        private void PopuniPodatke(Stol stol)
        {
            txtOznaka.Text = stol.Oznaka_Stola;
            txtBrMjesta.Text = stol.Broj_Mjesta.ToString();
            int velicinaStola = (int)stol.Velicina_Stola;
            switch (velicinaStola)
            {
                case 2:
                    radioButton2.Checked = true;
                    break;
                case 4:
                    radioButton4.Checked = true;
                    break;
                case 6:
                    radioButton6.Checked = true;
                    break;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            int velicina = 0;
            if (radioButton2.Checked) velicina = 2;
            if (radioButton4.Checked) velicina = 4;
            if (radioButton6.Checked) velicina = 6;
            int brojMjesta;
            try
            {
                if (txtOznaka.Text == "") throw new KriviUnosException("Molim unesite Text");
                int.TryParse(txtBrMjesta.Text, out brojMjesta);
                if (brojMjesta < 1) throw new KriviUnosException("Broj mjesta mora biti veći od 1");

            }
            catch (KriviUnosException ex)
            {
                MessageBox.Show(ex.DodatnaPoruka);
            }

            int.TryParse(txtBrMjesta.Text, out brojMjesta);
            if (txtOznaka.Text != null && brojMjesta > 0)
            {
                using (var context = new Entities())
                {
                    Stol odabraniStol = DohvatiOdabraniStol();
                    var query = from s in context.Stol
                                where s.Kafic_ID == kafic.ID_Kafic
                                orderby s.Broj_Mjesta
                                select s;
                    List<Stol> lista = query.ToList();
                    
                    context.SaveChanges();
                    Stol stolZaIzmjeniti = lista.Find(x => x.ID_Stol == odabraniStol.ID_Stol);
                    if (brojMjesta > odabraniStol.Broj_Mjesta) { 
                    lista.Find(x => x.Broj_Mjesta == brojMjesta).Broj_Mjesta--;
                        stolZaIzmjeniti.Broj_Mjesta = brojMjesta;

                    }
                    else
                    {
                        stolZaIzmjeniti.Broj_Mjesta = 0;
                        bool update=false;
                        foreach (Stol stol in lista)
                        {
                            if (stol.Broj_Mjesta == brojMjesta) update = true;
                            if (update) stol.Broj_Mjesta++;
                        }
                        stolZaIzmjeniti.Broj_Mjesta=brojMjesta;
                    }
                    stolZaIzmjeniti.Velicina_Stola = (byte?)velicina;
                    stolZaIzmjeniti.Oznaka_Stola = txtOznaka.Text;
                    context.SaveChanges();

                }

                OsvjeziMjesta();
                OsvjeziListu();
                refresh = true;
            }
        }

        private void txtBrMjesta_TextChanged(object sender, EventArgs e)
        {
            update = true;
        }

        private void frmUpravljanje_Stolovima_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(refresh)
            frm.RefreshStolovi();
        }
    }
    public class KriviUnosException : Exception
    {
        public KriviUnosException(string poruka)
        {
            DodatnaPoruka = poruka;
        }
        public string DodatnaPoruka { get; set; }
    }
}
