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
    public partial class frmDodajNoviStol : Form
    {
        private Kafic kafic;
        public frmDodajNoviStol(Kafic odabraniKafic)
        {
            InitializeComponent();
            kafic = odabraniKafic;
        }

        private void btnDodajNoviStol_Click(object sender, EventArgs e)
        {
            int brojMjesta;
            int velicina = 0;
            if (radioButton2.Checked) velicina = 2;
            if (radioButton4.Checked) velicina = 4;
            if (radioButton6.Checked) velicina = 6;

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
                                orderby s.Broj_Mjesta
                                select s;
                    List<Stol> lista = query.ToList();
                    if (lista.Count > 0)
                    {
                        bool povecaj = false;
                        foreach (Stol st in lista)
                        {
                            if (st.Broj_Mjesta == brojMjesta) povecaj = true;
                            if (povecaj) st.Broj_Mjesta++;

                        }
                        context.SaveChanges();
                        var stolQuery = from s in context.Stol
                                        select s;
                        lista = stolQuery.ToList();
                        Stol zadnjiStol = lista.Last<Stol>();
                        Stol stol = new Stol
                        {
                            ID_Stol = zadnjiStol.ID_Stol + 1,
                            Oznaka_Stola = txtOznaka.Text,
                            Broj_Mjesta = brojMjesta,
                            Kafic_ID = kafic.ID_Kafic,
                            Velicina_Stola = (byte?)velicina
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
                    Close();



                }
            }
        }
    }
}
