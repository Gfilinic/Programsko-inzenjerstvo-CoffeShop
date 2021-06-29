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
        private frmNarudzbe narudzbe;
        private Konobar konobar;
        private Kafic kafic;
        public UCStol(Kafic odabraniKafic)
        {
            InitializeComponent();
            narudzbe = null;
            kafic = odabraniKafic;
        }

        public string ImeStola
        {
            get { return lblImeStola.Text; }
            set { lblImeStola.Text = value; }
        }

        private void pbStol_Click(object sender, EventArgs e)
        {
            if (narudzbe == null && konobar != null)
            {
                narudzbe = new frmNarudzbe(konobar);
                narudzbe.ShowDialog();
            }
            else if (narudzbe != null)
            {
                frmLoginKonobar frmLogin = new frmLoginKonobar(kafic);
                frmLogin.ShowDialog();
                if (frmLogin.DialogResult == DialogResult.OK)
                {
                    narudzbe.promijeniKonobara(frmLogin.nadeniKonobar);

                    narudzbe.ShowDialog();
                }
            }
            else
            {
                frmLoginKonobar frmLogin = new frmLoginKonobar(kafic);
                frmLogin.ShowDialog();
                if (frmLogin.DialogResult == DialogResult.OK)
                {
                    konobar = frmLogin.nadeniKonobar;
                    narudzbe = new frmNarudzbe(konobar);
                    narudzbe.ShowDialog();
                    frmLogin.Close();
                }
            }
        }
        public void PostaviKonobara(Konobar odabraniKonobar)
        {
            konobar = odabraniKonobar;
        }
        public void MakniKonobara()
        {
            konobar = null;
        }
    }
}
