using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeeGestion.Forms
{
    public partial class Magasine : Form
    {
        public Magasine()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Achats achats = new Achats();
            achats.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Fournisseur fournisseur = new Fournisseur();
            fournisseur.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
