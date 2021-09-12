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
    public partial class frmLoginKonobar : Form
    {
        private Kafic kafic;
        public Konobar nadeniKonobar;
        public frmLoginKonobar(Kafic odabraniKafic)
        {
            InitializeComponent();
            kafic = odabraniKafic;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (var context = new Entities())
            {
                Konobar konobar = null;
                var query = from k in context.Konobar
                            where k.Kafic_ID == kafic.ID_Kafic && k.Sifra == txtSifra.Text
                            select k;
                if (query.ToList().Count > 0) { 
                    konobar = query.Single();
                }
                if (konobar != null)
                {
                    nadeniKonobar = konobar;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                }
            }
        }
          

        private void btnClose_Click(object sender, EventArgs e)
        {
            
                Close();
        }

        private void frmLoginKonobar_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Helper.GetHelp(this);
        }
    }
}
