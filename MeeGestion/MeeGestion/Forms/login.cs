using MeeGestion.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeeGestion
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        
        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked)
            {
                if (!radioButton2.Checked)
                {
                    if (!radioButton3.Checked)
                    {
                        if (!radioButton4.Checked)
                        {
                            MessageBox.Show("Please Choose User Sir!!", "Error");
                        }
                    }
                }
            }
            else
            {
                if (radioButton1.Checked && txtpassword.Text == "1111")
                {
                    using (FormDashBoard dashBoard = new FormDashBoard(this))
                    {
                        this.Hide();
                        dashBoard.ShowDialog();
                    }
                }

                if (radioButton2.Checked && txtpassword.Text == "9999")
                {
                    using (FormDashBoard dashBoard = new FormDashBoard(this))
                    {
                        this.Hide();
                        dashBoard.ShowDialog();
                    }
                }
                else
                {
                    if (radioButton3.Checked && txtpassword.Text == "2222")
                    {
                        using (FormDashBoard dashBoard = new FormDashBoard(this))
                        {
                            this.Hide();
                            dashBoard.ShowDialog();
                        }
                    }
                    else
                    {
                        if (radioButton4.Checked && txtpassword.Text == "2019")
                        {
                            using (FormDashBoard dashBoard = new FormDashBoard(this))
                            {
                                this.Hide();
                                dashBoard.ShowDialog();
                            }
                        }
                        else { MessageBox.Show("Please Entre the Correct Password Sir!!", "Error"); }
                    }
                }

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup signup = new Signup();
            signup.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            txtpassword.Text = txtpassword.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtpassword.Text = txtpassword.Text + "2";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtpassword.Text = txtpassword.Text + "3";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtpassword.Text = txtpassword.Text + "4";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtpassword.Text = txtpassword.Text + "5";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtpassword.Text = txtpassword.Text + "6";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtpassword.Text = txtpassword.Text + "7";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtpassword.Text = txtpassword.Text + "8";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtpassword.Text = txtpassword.Text + "9";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtpassword.Text = txtpassword.Text + "0";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtpassword.Text = String.Empty;

        }
        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            txtpassword.MaxLength = 8;
            if (txtpassword.Text.Length > 8)
            {
                txtpassword.Text = "";
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(txtpassword.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtpassword.Text = txtpassword.Text.Remove(txtpassword.Text.Length - 1);
            }
        }
        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void checkhide_CheckedChanged(object sender, EventArgs e)
        {
            if (checkhide.Checked)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
