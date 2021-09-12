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
    public partial class frmLoginModerator : Form
    {
        private Kafic kafic;
        public Moderator moderator;
        public frmLoginModerator(Kafic chosenKafic)
        {
            InitializeComponent();
            kafic = chosenKafic;
            
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Moderator odabraniModerator = null;
            using (var context= new Entities())
            {
                var query = from m in context.Moderator
                            where m.Kafic_ID==kafic.ID_Kafic && m.KorIme == txtUser.Text && m.Lozinka == txtPassword.Text
                            select m;
                if(query.ToList().Count>0)
                 odabraniModerator= query.Single();
                if (odabraniModerator != null)
                {
                    moderator = odabraniModerator;
                    Hide();
                }
                else Close();

                            
            }
        }

        public Moderator DohvatiModeratora()
        {
            return moderator;
        }

        private void frmLoginModerator_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Helper.GetHelp(this);

        }
    }
}
