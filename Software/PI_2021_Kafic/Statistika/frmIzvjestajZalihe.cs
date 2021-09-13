using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_2021_Kafic.Statistika
{
    public partial class frmIzvjestajZalihe : Form
    {
        private Kafic kafic;
        public frmIzvjestajZalihe(Kafic odabraniKafic)
        {
            InitializeComponent();
            kafic = odabraniKafic;
        }

        private void frmIzvjestajZalihe_Load(object sender, EventArgs e)
        {
            namirnicaBindingSource.DataSource = DohvatiNamirnice();
            this.reportViewer1.RefreshReport();
        }

        private List<Namirnica> DohvatiNamirnice()
        {
            using (var context= new Entities())
            {
                var query = from n in context.Namirnica
                            where n.Kafic_ID == kafic.ID_Kafic
                            select n;
                return query.ToList();
            }
        }
    }
}
