using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_2021_Kafic
{
    public partial class UCStol : UserControl
    {
        private Narudzbe narudzbe;
        public UCStol()
        {
            InitializeComponent();
            narudzbe = null;
        }
        
        public string ImeStola
        {
            get { return lblImeStola.Text; }
            set { lblImeStola.Text = value; }
        }

        private void pbStol_Click(object sender, EventArgs e)
        {
            if (narudzbe == null)
            {
                narudzbe = new Narudzbe(ImeStola);
                narudzbe.ShowDialog();
            }
            else narudzbe.ShowDialog();
        }
    }
}
