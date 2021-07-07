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
        public frmUpravljanje_Stolovima(Kafic prosljedenjiKafic)
        {
            InitializeComponent();
            kafic = prosljedenjiKafic;

            OsvjeziListu();
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
                }
            }
            OsvjeziListu();
        }

        private Stol DohvatiOdabraniStol()
        {
            if (listboxStol.SelectedItem != null)
                return listboxStol.SelectedItem as Stol;
            else return null;
        }

     

        private void btnDodajNoviStol_Click(object sender, EventArgs e)
        {
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
                    var query = from s in context.Stol
                                where s.Kafic_ID == kafic.ID_Kafic
                                select s;
                    List<Stol> lista = query.ToList();
                    if (lista.Count > 0) {
                    Stol zadnjiStol = lista.Last<Stol>();
                        Stol stol = new Stol
                        {
                            ID_Stol = zadnjiStol.ID_Stol + 1,
                            Oznaka_Stola = txtOznaka.Text,
                            Broj_Mjesta = brojMjesta,
                            Kafic_ID = kafic.ID_Kafic
                        };
                        context.Stol.Add(stol);
                        context.SaveChanges();
                    }
                    else
                    {

                        Stol stol = new Stol
                        {
                            ID_Stol = 0,
                            Oznaka_Stola = txtOznaka.Text,
                            Broj_Mjesta = brojMjesta,
                            Kafic_ID = kafic.ID_Kafic
                        };
                        context.Stol.Add(stol);
                        context.SaveChanges();
                    }

                   
                    
                }
            }
            OsvjeziListu();
        }

        private void frmUpravljanje_Stolovima_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            PomocneFunkcije.PomocneFunkcije.HelpUpravaljanjeStolovima();
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
