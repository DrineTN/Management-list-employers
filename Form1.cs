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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Employe> list_emp = new List<Employe>();
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            decimal x;
            if (!Decimal.TryParse(num1.Text, out x))
            {
                MessageBox.Show("Le numero d employe doit etre numerique");
                num1.Clear();
                num1.Focus();
            }
            else
                if (String.IsNullOrEmpty(num1.Text))
                    MessageBox.Show("le champs de numero est obligatoire");
                else
                    if (Decimal.TryParse(np.Text,out x))
                    {
                        MessageBox.Show("Le Nom et prenom doit etre alphatique");
                        np.Clear();
                        np.Focus();
                    }
                    else 
                        if (String.IsNullOrEmpty(np.Text))
                        MessageBox.Show("le champs de Nom Prenom est obligatoire");
                    else
                        if (String.IsNullOrEmpty(ad.Text))
                            MessageBox.Show("Le Champs d'adresse est obligatoire");
                        else
                        {
                            int nb = 0;
                            Char[] tab_add = ad.Text.ToCharArray();
                            foreach (char c in tab_add)
                                if (c == ':')
                                    nb++;
                            if (nb != 2)
                            {
                                MessageBox.Show("L'address doit etre sous forme Rue : Code Postal : Ville");
                                ad.Clear();
                                ad.Focus();
                            }
                            else
                            {
                                String[] tab_adr = ad.Text.Split(':');
                                Decimal y;
                                if (!Decimal.TryParse(tab_adr[1], out y))
                                {
                                    MessageBox.Show("Le code Postal doit etre numerique");
                                    ad.Clear();
                                    ad.Focus();

                                }
                                else
                                {
                                    bool ok = false;
                                    foreach (Employe z1 in list_emp)
                                    {
                                        if (Convert.ToString(z1.numero) == num1.Text)
                                        {
                                            MessageBox.Show("employe deja exist");
                                            num1.Clear();
                                            np.Clear();
                                            ad.Clear();
                                            num1.Focus(); ok = true;

                                        }
                                        else
                                            continue;
                                    }
                                    if (ok == false)
                                    {
                                        Employe e1 = new Employe(Convert.ToInt32(num1.Text), np.Text, ad.Text);
                                        list_emp.Add(e1);
                                        string ch = Convert.ToString(e1.numero) + " | " + e1.nom_prenom + " | " + e1.adress;
                                        listBox1.Items.Add(ch);
                                        num1.Clear();
                                        np.Clear();
                                        ad.Clear();
                                        num1.Focus();
                                        modifier.Enabled = true;
                                        button3.Enabled = true;
                                    }

                                }
                            }
                        }
        }
         private void button2_Click(object sender, EventArgs e)
        {
             int indice = listBox1.SelectedIndex;
             string ch;
             if(modifier.Text=="modifier")
            {
                num1.Text = Convert.ToString(list_emp[indice].numero);
                np.Text = list_emp[indice].nom_prenom;
                ad.Text = list_emp[indice].adress;
                modifier.Text = "Valider";
                button1.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;

            }
            else
                if(modifier.Text=="Valider")
                {
                    list_emp[indice].nom_prenom =np.Text;
                    list_emp[indice].adress = ad.Text;
                    ch=list_emp[indice].numero+" | "+list_emp[indice].nom_prenom+" | "+ list_emp[indice].adress;
                    listBox1.Items[indice] = ch;
                    modifier.Text = "Modifier";
                    button1.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true; 
                }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n1 = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(n1);
            list_emp.RemoveAt(n1);
        }

      private void button4_Click(object sender, EventArgs e)
        {
            Recherche rech = new Recherche(listBox1);
            rech.ShowDialog();
        }

      private void pictureBox1_Click(object sender, EventArgs e)
      {

      }
    }
}
