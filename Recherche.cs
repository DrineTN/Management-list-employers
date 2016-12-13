using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp4
{
    public partial class Recherche : Form
    {
         ListBox listBoxs;
         list<Employe> liste;

        public Recherche(ListBox li)
        {
           
           listBoxs = li;
           InitializeComponent();
        }

      
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Recherche_Load(object sender, EventArgs e)
        {
            String[] ch2 = new String []{};
            String[] ch3;
            foreach (String z1 in listBoxs.Items)
            {
                ch2 = z1.Split('|');
                ch3=ch2[2].Split(':');
                string ch = ch3[0] + " ; " + ch3[1] + " ; " + ch3[2];
                list1.Items.Add(ch);
            }
        }

        private void Ville_keyPress(object sender, KeyPressEventArgs e)
        {
            list2.Items.Clear();
            if (Ville.Text != "" && e.KeyChar == (char)Keys.Return)
            {
                String[] tab_adr;
                foreach (String item in list1.Items)
                {
                    tab_adr = item.Split(';');
                    if (tab_adr[2].Contains(Ville.Text))
                        list2.Items.Add(item);
                }
            }
            else
            if ((e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < 'A' || e.KeyChar > 'Z') &&( e.KeyChar != (char)Keys.Return && e.KeyChar != (char)Keys.Back))
                e.KeyChar = (char)0;
                 }

        private void Ville_TextChanged(object sender, EventArgs e)
        {

        }

        private void list2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string adr =(String)list2.SelectedItem;
            String[] tab_adr = adr.Split(';');
            Rue.Text = tab_adr[0];
            CP.Text = tab_adr[1];
            Vil.Text = tab_adr[2];
        }
    }
}
