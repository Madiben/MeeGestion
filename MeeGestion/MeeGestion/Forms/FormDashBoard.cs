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
    public partial class FormDashBoard : Form
    {
        public FormDashBoard(login login)
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
                EStock etatstock = new EStock();
                etatstock.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Magasine magasine = new Magasine();
            magasine.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Compoir caisse = new Compoir();
            caisse.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Banque banque = new Banque();
            banque.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Facture facture = new Facture();
            facture.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Parametres parametres = new Parametres();
            parametres.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            login login = new login();
            login.Show();
                
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Compoir caisse = new Compoir();
            caisse.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Magasine magasine = new Magasine();
            magasine.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            EStock etatstock = new EStock();
            etatstock.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Banque banque = new Banque();
            banque.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Facture facture = new Facture();
            facture.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Parametres parametres = new Parametres();
            parametres.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
