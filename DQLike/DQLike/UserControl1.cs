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
    public partial class UserControl1 : UserControl
    {
        private List<Personnage> ennemis = new List<Personnage>();
        private List<Personnage> allies = new List<Personnage>();
        private List<UserControl1> list1;
        private List<UserControl1> list2;
        private Personnage personnage;
        Form1 form1;


        public UserControl1()
        {
            InitializeComponent();
        }

        public UserControl1(List<UserControl1> list1, List<UserControl1> list2)
        {
            this.list1 = list1;
            this.list2 = list2;
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            
        }

        public void InitListes(List<UserControl1> list1, List<UserControl1> list2)
        {
            this.list1 = list1;
            this.list2 = list2;
        }

        public void ChangementTour(List<UserControl1> list1, List<UserControl1> list2)
        {
            this.list1 = list1;
            this.list2 = list2;
            foreach (UserControl1 u in list1)
            {
                u.button1.Visible = false; 
            }
            foreach (UserControl1 u in list2)
            {
                u.button1.Visible = false;
            }
            this.button1.Visible = true;
        }

        public void AfficherPersonnage(Personnage personnage)
        {
            this.personnage = personnage;
            groupBox1.Text = personnage.getNom();
            label2.Text = personnage.AfficherPV();
            label3.Text = personnage.AfficherPM();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (var form = new Form2(allies, ennemis, personnage.Attaquer(), personnage, form1))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    int i = 0;
                    foreach (UserControl1 u in list1)
                    {
                        if (i < allies.Count())
                        {
                            u.AfficherPersonnage(allies[i]);
                            i++;
                        }
                    }
                    i = 0;
                    foreach (UserControl1 u in list2)
                    {
                        if (i < ennemis.Count())
                        {
                            u.AfficherPersonnage(ennemis[i]);
                            i++;
                        }
                    }
                }

            }
        }

        public void SetListeA(List<Personnage> personnages)
        {           
           this.allies = personnages;
        }
        public void SetListeE(List<Personnage> personnages)
        {
            this.ennemis = personnages;
        }

        public Personnage GetPersonnage()
        {
            return personnage;
        }
    }
}
