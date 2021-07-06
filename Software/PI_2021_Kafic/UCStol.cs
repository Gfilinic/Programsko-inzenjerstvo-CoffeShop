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
        private Stol stol;
        private Timer timerClose;

        public UCStol(Kafic odabraniKafic,Stol prosljedeniStol)
        {
            InitializeComponent();
            narudzbe = null;
            kafic = odabraniKafic;
            stol = prosljedeniStol;
            timerClose = new Timer();
            this.timerClose.Tick += new System.EventHandler(this.timerClose_Tick);

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
                narudzbe = new frmNarudzbe(konobar,kafic,stol,this);
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
                else
                {
                    timerClose.Interval = 1000;
                    timerClose.Enabled = true;
                    MessageBox.Show("Neuspješna prijava");
                }
            }
            else
            {
                frmLoginKonobar frmLogin = new frmLoginKonobar(kafic);
                frmLogin.ShowDialog();
                if (frmLogin.DialogResult == DialogResult.OK)
                {
                    konobar = frmLogin.nadeniKonobar;
                    narudzbe = new frmNarudzbe(konobar,kafic,stol,this);
                    narudzbe.ShowDialog();
                    frmLogin.Close();
                }
                else
                {
                    timerClose.Interval = 1000;
                    timerClose.Enabled = true;
                    MessageBox.Show("Neuspješna prijava");
                }
            }
            PromijeniBoju();
        }
        public void PostaviKonobara(Konobar odabraniKonobar)
        {
            konobar = odabraniKonobar;
        }
        public void MakniKonobara()
        {
            konobar = null;
        }

        private void UCStol_Load(object sender, EventArgs e)
        {
            PromijeniBoju();
        }
        public void MakniNarudzbu()
        {
            narudzbe = null;
        }
        public void PromijeniBoju() {
            if (narudzbe == null) lblImeStola.ForeColor = System.Drawing.Color.Green;
            else
                lblImeStola.ForeColor = System.Drawing.Color.Red;

        }
        private void timerClose_Tick(object sender, EventArgs e)
        {
            timerClose.Enabled = false;
            SendKeys.Send("{ESC}");
        }
    }
}
