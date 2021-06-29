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
    public partial class btnPoduzeca : Form
    {
        private Kafic odabraniKafic;
        public btnPoduzeca()
        {
            InitializeComponent();
            this.BackColor=Color.FromArgb(8,29,53);
            panel1.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            PopuniKafice();
        }

        private void PopuniKafice()
        {
            using (var context = new Entities())
            {
                var query = from k in context.Kafic.Include("Poduzeće")
                            select k;
                lbKafici.DataSource = query.ToList();

            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbKafici_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbKafici.SelectedItem != null)
                odabraniKafic = lbKafici.SelectedItem as Kafic;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbKafici.SelectedItem != null)
            {
                using (var context = new Entities())
                {
                    context.Kafic.Attach(odabraniKafic);
                    context.Kafic.Remove(odabraniKafic);
                    context.SaveChanges();
                }
                PopuniKafice();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            KaficManager frmManager = new KaficManager();
            frmManager.ShowDialog();
            PopuniKafice();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (odabraniKafic != null)
            {
                KaficManager managerKafic = new KaficManager(odabraniKafic);
                managerKafic.ShowDialog();
                PopuniKafice();
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (odabraniKafic != null)
            {
                ModeratorManager modManager = new ModeratorManager(odabraniKafic);
                modManager.ShowDialog();
            }
        }

        private void btnPoduzece_Click(object sender, EventArgs e)
        {
            if (odabraniKafic != null)
            {
                PoduzeceManager manager = new PoduzeceManager();
                manager.ShowDialog();
            }
        }
    }
}
