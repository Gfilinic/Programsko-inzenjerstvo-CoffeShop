using PI_2021_Kafic.Statistika;
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
    public partial class frmMainKafic : Form
    {
        List<UCStol> listaStolova;
        Kafic kafic;
        private Moderator moderator;
        private Konobar konobar;

        public frmMainKafic()
        {
            InitializeComponent();
            listaStolova = new List<UCStol>();
            kafic = DohvatiKafic();
            this.Text = kafic.Naziv;
            RefreshStolovi();
            upravaljnjeStolovimaToolStripMenuItem.Visible = false;
            odjaviModeratoraToolStripMenuItem.Visible = false;
            odjaviKonobaraToolStripMenuItem.Visible = false;
            trenutniKorisnikToolStripMenuItem.Visible = false;
            skladišteToolStripMenuItem.Visible = false;
            upravljanjeKonobarima.Visible = false;
            otpisToolStripMenuItem.Visible = false;
            racuniToolStripMenuItem.Visible = false;

        }

        private Kafic DohvatiKafic()
        {
            using (var context = new Entities())
            {
                var query = from k in context.Kafic
                            where k.Odabran == 1
                            select k;
                return query.Single();
            }
        }

        public void RefreshStolovi()
        {
            IzbrisiStolove();
            int point1 = 0;
            int point2 = 27;
            List<Stol> lista = new List<Stol>();
            using (var context = new Entities())
            {
                
                var query = from s in context.Stol
                            where s.Kafic_ID == kafic.ID_Kafic
                            orderby s.Broj_Mjesta
                            select s;
                lista = query.ToList();
                foreach(Stol stol in lista)
               
                {
                    UCStol uCStol = new UCStol(kafic,stol);
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
            Refresh();
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
            frmUpravljanje_Stolovima upravitelj = new frmUpravljanje_Stolovima(kafic,this);
            upravitelj.ShowDialog();
        }

       

        private void MainKafic_ResizeEnd(object sender, EventArgs e)
        {
            RefreshStolovi();
        }

        private void upravljanjeNamirnicamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNamirniceMain frmNamirnice = new frmNamirniceMain(kafic);
            frmNamirnice.ShowDialog();
        }

       

        private void upravljanjeNormativimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNormativMain frmNormativ = new frmNormativMain(kafic);
            frmNormativ.ShowDialog();
        }
        private void moderatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoginModerator frmLogin = new frmLoginModerator(kafic);
            frmLogin.ShowDialog();
            moderator = frmLogin.DohvatiModeratora();
            frmLogin.Close();
            if (moderator != null)
            {
                upravaljnjeStolovimaToolStripMenuItem.Visible = true;
                odjaviModeratoraToolStripMenuItem.Visible = true;
                moderatorToolStripMenuItem.Visible = false;
                skladišteToolStripMenuItem.Visible = true;
                upravljanjeKonobarima.Visible = true;
                racuniToolStripMenuItem.Visible = true;
            }
            else
            {
                timerClose.Interval = 1000;
                timerClose.Enabled = true;
                MessageBox.Show("Neuspješna prijava");
            }
        }

        private void odjaviModeratoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerClose.Interval = 1000;
            timerClose.Enabled = true;
            MessageBox.Show($"Odjavljen moderator {moderator.KorIme}");
            moderator = null;
            upravaljnjeStolovimaToolStripMenuItem.Visible = false;
            odjaviModeratoraToolStripMenuItem.Visible = false;
            moderatorToolStripMenuItem.Visible = true;
            skladišteToolStripMenuItem.Visible = false;
            upravljanjeKonobarima.Visible = false;
            racuniToolStripMenuItem.Visible = false;
            
        }

        private void loginKonobarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoginKonobar frmLogin = new frmLoginKonobar(kafic);
            frmLogin.ShowDialog();
            if (frmLogin.DialogResult == DialogResult.OK)
            {
                konobar = frmLogin.nadeniKonobar;
                loginKonobarToolStripMenuItem.Visible = false;
                odjaviKonobaraToolStripMenuItem.Visible = true;
                frmLogin.Close();
                trenutniKorisnikToolStripMenuItem.Visible = true;
                trenutniKorisnikToolStripMenuItem.Text = "User: " + konobar.Ime + " " + konobar.Prezime;
                DodijeliStolovimaKonobara(konobar);
                if (konobar.Voditelj == 1)
                {
                    otpisToolStripMenuItem.Visible = true;
                    racuniToolStripMenuItem.Visible = true;
                }
            }
            else { 
                
                frmLogin.Close();
                timerClose.Interval = 1000;
                timerClose.Enabled = true;
                MessageBox.Show("Neuspješna prijava");
            }
        }

        private void DodijeliStolovimaKonobara(Konobar konobar)
        {
            foreach (Control control in this.Controls)
            {
                if (control.GetType() == typeof(UCStol))
                {
                    UCStol stol = (UCStol)control;
                    stol.PostaviKonobara(konobar);
                }

            }
        }

        private void odjaviKonobaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (konobar.Voditelj == 1)
            {
                otpisToolStripMenuItem.Visible = false;
                racuniToolStripMenuItem.Visible = false;
            }
            konobar = null;
            loginKonobarToolStripMenuItem.Visible = true;
            odjaviKonobaraToolStripMenuItem.Visible = false;
            trenutniKorisnikToolStripMenuItem.Visible = false;
            
            MakniKonobaraSaStolova();
            timerClose.Interval = 1000;
            timerClose.Enabled = true;
            MessageBox.Show("Konobar odjavljen");
        }

        private void MakniKonobaraSaStolova()
        {
            foreach (Control control in this.Controls)
            {
                if (control.GetType() == typeof(UCStol))
                {
                    UCStol stol = (UCStol)control;
                    stol.MakniKonobara();
                }

            }
        }

        private void artikliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArtiklMain artiklMain = new frmArtiklMain(kafic);
            artiklMain.ShowDialog();

        }

        private void upravljanjeKonobarima_Click(object sender, EventArgs e)
        {
            frmUpravljanjeKonobarima frmKonobar = new frmUpravljanjeKonobarima(kafic);
            frmKonobar.ShowDialog();
        }

        private void stanjeNaSkladištuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStanjeSkladiste skladiste = new frmStanjeSkladiste(kafic);
            skladiste.ShowDialog();

        }

        private void otpisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOtpis frmOtpis = new frmOtpis(kafic);
            frmOtpis.ShowDialog();
        }

        private void racuniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRacuni racuni = new frmRacuni(kafic);
            racuni.ShowDialog();
        }

        private void timerClose_Tick(object sender, EventArgs e)
        {
            timerClose.Enabled = false;
            SendKeys.Send("{ESC}");
        }

        private void frmMainKafic_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            PomocneFunkcije.PomocneFunkcije.HelpMain();
        }

        private void toolstripStatistika_Click(object sender, EventArgs e)
        {
            frmStatistika frm = new frmStatistika(kafic);
            frm.ShowDialog();
        }
    }
}

