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
    public partial class Fournisseur : Form
    {
        public Fournisseur()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Magasine magasine = new Magasine();
            magasine.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox2.Text != "") && (textBox3.Text != "") && (textBox4.Text != "") && (textBox5.Text != "") && (textBox6.Text != ""))
            {
                string MySqlConnectionString = "Server=localhost; Port=3307; Database=salespoint; Uid=root; Pwd=221299;";
                MySqlConnection mySqlConnection = new MySqlConnection(MySqlConnectionString);
                MySqlCommand cmd;
                mySqlConnection.Open();
                try
                {
                    cmd = mySqlConnection.CreateCommand();
                    cmd.CommandText = "INSERT INTO fournisseurmagasine(nomfournisseur,ntel,adress,nomMagasine,email,siteweb)VALUES(@productcode,@productname,@status,@prixachat,@prixvente,@fournisseur)";

                    cmd.Parameters.AddWithValue("@nomfournisseur", textBox1.Text);
                    cmd.Parameters.AddWithValue("@ntel", textBox2.Text);
                    cmd.Parameters.AddWithValue("@adress", textBox6.Text);
                    cmd.Parameters.AddWithValue("@nomMagasine", textBox4.Text);
                    cmd.Parameters.AddWithValue("@email", textBox3.Text);
                    cmd.Parameters.AddWithValue("@siteweb", textBox5.Text);
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


            }
            else
            {
                MessageBox.Show(" Please Fill All The Empty Fields ", "Sales Point", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
