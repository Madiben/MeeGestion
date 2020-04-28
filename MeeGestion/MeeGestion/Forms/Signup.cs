using MySql.Data.MySqlClient;
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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            login form = new login();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox2.Text != "") && (textBox3.Text != "") && (textBox4.Text != "") && (textBox5.Text != "") && (textBox6.Text != "") && (textBox7.Text != "") && (textBox8.Text != "") && (textBox9.Text != "") && (textBox10.Text != "") && (textBox11.Text != "") && (checkBox1.Checked))
            {
                string MySqlConnectionString = "Server=localhost; Port=3307; Database=salespoint; Uid=root; Pwd=221299;";
                MySqlConnection mySqlConnection = new MySqlConnection(MySqlConnectionString);
                MySqlCommand cmd;
                mySqlConnection.Open();
                try
                {
                    cmd = mySqlConnection.CreateCommand();
                    cmd.CommandText = "INSERT INTO account(uuid,nom,prenom,ntelephone,email,password,daten,village,pays,adress,idnumber,licencenumber,Time)VALUES(uuid(),@nom,@prenom,@ntelephone,@email,@password,@daten,@village,@pays,@adress,@idnumber,@licencenumber,@Time)";

                    cmd.Parameters.AddWithValue("@nom", textBox1.Text);
                    cmd.Parameters.AddWithValue("@prenom", textBox2.Text);
                    cmd.Parameters.AddWithValue("@ntelephone", textBox4.Text);
                    cmd.Parameters.AddWithValue("@email", textBox3.Text);
                    cmd.Parameters.AddWithValue("@password", textBox7.Text);
                    cmd.Parameters.AddWithValue("@daten", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@village", textBox10.Text);
                    cmd.Parameters.AddWithValue("@pays", textBox11.Text);
                    cmd.Parameters.AddWithValue("@adress", textBox6.Text);
                    cmd.Parameters.AddWithValue("@idnumber", textBox5.Text);
                    cmd.Parameters.AddWithValue("@licencenumber", textBox9.Text);
                    cmd.Parameters.AddWithValue("@Time", dateTimePicker2.Text);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception E)
                {
                    MessageBox.Show("Error : " + E.Message);
                }
                finally
                {
                    if (mySqlConnection.State == ConnectionState.Open)
                    {
                        mySqlConnection.Close();
                    }
                }
                this.Dispose();
                login form = new login();
                form.Show();
            }
            else
            {
                MessageBox.Show(" Please Fill All The Empty Fields ", "Sales Point", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            checkBox1.Checked = false;
        }

        private void Number_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

       

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            if (textBox1.Text.Length > 0)

            {

                if (!rEMail.IsMatch(textBox1.Text))

                {

                    MessageBox.Show("E-Mail expected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBox1.SelectAll();

                    e.Cancel = true;

                }
            }
        }

        
    }
}
