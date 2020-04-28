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
    public partial class EStock : Form
    {
        public EStock()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelPD.Show();
            panelPInD.Hide();
            panelPP.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelPD.Hide();
            panelPInD.Show();
            panelPP.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panelPD.Hide();
            panelPInD.Hide();
            panelPP.Show();
        }
    }
}
