using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DQLike
{
    public partial class Form0 : Form
    {
        private List<Personnage> ennemis = new List<Personnage>();
        public int PO = 0;
        private List<UserControl2> articles = new List<UserControl2>();
        private int prixTotal;

        public Form0()
        {
            InitializeComponent();
            articles.Add(userControl21);
            articles.Add(userControl22);
            articles.Add(userControl23);
            /*userControl21 = new UserControl2("Herbe médicinale", 5);
            userControl22 = new UserControl2("Arme", 50);
            userControl23 = new UserControl2("Armure", 50);*/
            label3.Text = "Vous avez " + PO + " pièces d'or.";
            labelTotal.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personnage Slime = new Personnage("Slime", 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5);
            ennemis.Add(Slime);
            Form1 form = new Form1(ennemis);
            form.ShowDialog();
        }

        private void Form0_Load(object sender, EventArgs e)
        {
            /*label3.Text = "Vous avez " + PO + " pièces d'or.";
            labelTotal.Text = "";
            userControl21 = new UserControl2("Herbe médicinale", 5);
            userControl22 = new UserControl2("Arme", 50);
            userControl23 = new UserControl2("Armure", 50);
            articles.Add(userControl21);
            articles.Add(userControl22);
            articles.Add(userControl23);*/
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            prixTotal = 0;  
            foreach(UserControl2 u in articles)
            {
                prixTotal += u.Total();
            }
            DialogResult result;
            result = MessageBox.Show("Vous allez perdre " + prixTotal + " PO.", "Action", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                if (PO >= prixTotal)
                {
                    PO -= prixTotal;
                }
                else
                {
                    MessageBox.Show("Pas assez d'argent", "Erreur", MessageBoxButtons.OK);
                }
            }
        }
    }
}
