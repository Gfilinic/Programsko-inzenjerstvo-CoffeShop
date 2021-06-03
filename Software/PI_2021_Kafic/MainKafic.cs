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
    public partial class MainKafic : Form
    {
        List<UCStol> listaStolova;
        Kafic kafic;
        public MainKafic()
        {
            InitializeComponent();
            listaStolova = new List<UCStol>();
            kafic = DohvatiKafic(1);
            
            RefreshStolovi();

        }

        private Kafic DohvatiKafic(int id)
        {
            using (var context = new Entities())
            {
                var query = from k in context.Kafic
                            where k.ID_Kafic == id
                            select k;
                return query.Single();
            }
        }

        private void RefreshStolovi()
        {
            IzbrisiStolove();
            int point1 = 0;
            int point2 = 27;
            List<Stol> lista = new List<Stol>();
            using (var context = new Entities())
            {
                
                var query = from s in context.Stol
                            where s.Kafic_ID == kafic.ID_Kafic
                            select s;
                lista = query.ToList();
                foreach(Stol stol in lista)
               
                {
                    UCStol uCStol = new UCStol();
                    if (point1 + 193 < this.Size.Width)
                    {
                        uCStol.Location = new Point(point1, point2);
                        point1 += 193;

                    }
                    else
                    {
                        point1 = 0;
                        point2 += 211;
                        uCStol.Location = new Point(point1, point2);
                    }
                    
                    uCStol.ImeStola = stol.Oznaka_Stola;
                    
                    this.Controls.Add(uCStol);
                    
                }
            }
            
        }

        private void IzbrisiStolove()
        {
            foreach (Control control in this.Controls)
            {
                if (control.GetType() == typeof(UCStol))
                {
                    this.Controls.Remove(control);
                }

            }
        }

        private void MainKafic_Load(object sender, EventArgs e)
        {
            PopuniStolove();
        }

        private void PromijeniImeStolova()
        {
            int brojStolova = 1;
            for (int i = listaStolova.Count-1; i >=0 ; i--)
            {
                listaStolova[i].ImeStola = "Stol" + brojStolova;
                brojStolova++;
            }
        }

        private void PopuniStolove()
        {
            listaStolova.Clear();
            foreach(Control control in this.Controls)
            {
                if (control.GetType() == typeof(UCStol))
                {
                    listaStolova.Add(control as UCStol);
                }

            }
        }

        private void upravaljnjeStolovimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Upravljanje_Stolovima upravitelj = new Upravljanje_Stolovima(kafic);
            upravitelj.ShowDialog();
            RefreshStolovi();
        }

        private void MainKafic_Activated(object sender, EventArgs e)
        {
            RefreshStolovi();
        }

        private void MainKafic_ResizeEnd(object sender, EventArgs e)
        {
            RefreshStolovi();
        }
    }
}
