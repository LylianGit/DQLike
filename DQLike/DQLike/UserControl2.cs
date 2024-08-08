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
    public partial class UserControl2 : UserControl
    {
        private string nom;
        private int prix;
        private int total;

        /*public UserControl2()
        {
            InitializeComponent();
        }*/
        public UserControl2()
        {
            InitializeComponent();
        }

        public UserControl2(string nom, int prix)
        {
            this.nom = nom;
            this.prix = prix;
            InitializeComponent();
            groupBox1.Text = this.nom;
            label1.Text = "prix : " + this.prix + " PO";
            label2.Text = numericUpDown1.Value * this.prix + " PO";
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            total = Convert.ToInt32(numericUpDown1.Value) * this.prix;
            label2.Text = total + " PO";
        }

        public int Total()
        {
            return total;
        }
    }
}
