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
    public partial class Narudzbe : Form
    {
        string testlbl;
        int brojac;
        public Narudzbe(string test)
        {
            InitializeComponent();
            testlbl = test;
            brojac = 0;
        }

        private void Narudzbe_Load(object sender, EventArgs e)
        {
            label1.Text = testlbl;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            brojac++;
            label1.Text = testlbl + brojac.ToString();
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Narudzbe_Shown(object sender, EventArgs e)
        {
            if(brojac!=0)
            label1.Text = testlbl + brojac.ToString();
        }

        private void listboxMeni_ItemActivate(object sender, EventArgs e)
        {
           
            MessageBox.Show("Vrijednost je : "+sender.GetType().ToString());
            
        }


       
        private void listboxMeni_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var item = listboxMeni.SelectedItems[0];
            
          
            string text = item.Text;
            rtbRačun.Text = text;
        }

      

        private void pbTopliNapitci_Click(object sender, EventArgs e)
        {
            LoadWarmDrinks();
        }

        private void LoadWarmDrinks()
        {
            listboxMeni.Clear();
           
            var group = new ListViewGroup("Topli Napitci");
            listboxMeni.Groups.Add(group);
           
            
        }

        private void pbHladniNapitci_Click(object sender, EventArgs e)
        {
            listboxMeni.Clear();
            var group = new ListViewGroup("Hladni Napitci");
            listboxMeni.Groups.Add(group);
           
        }
    }
}
