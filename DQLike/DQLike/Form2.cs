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
    public partial class Form2 : Form
    {
        Sort sort;
        private List<Personnage> allies = new List<Personnage>();
        private List<Personnage> ennemis = new List<Personnage>();
        private Personnage utilisateur;
        Form1 form;
        public Form2(List<Personnage> allies, List<Personnage> ennemis, Sort sort, Personnage utilisateur, Form1 form)
        {           
            this.allies = allies;
            this.ennemis = ennemis;
            this.sort = sort;
            this.utilisateur = utilisateur;
            this.form = form;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                listBox1.Items.Clear();
                foreach (Personnage allie in allies)
                {
                    listBox1.Items.Add(allie.getNom());
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                listBox1.Items.Clear();
                foreach (Personnage ennemi in ennemis)
                {
                    listBox1.Items.Add(ennemi.getNom());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            if (sort.GetNbCibles() != listBox1.SelectedItems.Count)
            {
                MessageBox.Show("Il faut choisir " + sort.GetNbCibles() + " cibles ! Vous en avez choisi " + listBox1.SelectedItems.Count + " actuellement.");
                return;               
            }
            else
            {
                List<Personnage> cibles = new List<Personnage>();
                if (radioButton2.Checked)
                {
                    foreach (string s in listBox1.SelectedItems)
                    {
                        cibles.Add( ennemis.Where(cible => cible.getNom() == s).First() );
                    }

                }
                sort.UtiliserSort(utilisateur, cibles, -5);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
