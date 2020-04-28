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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Achats achats = new Achats();
            achats.Show();
        }
        private void Products_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox2.Text != "") && (textBox3.Text != "") && (textBox4.Text != "") && (comboBox2.Text != "") && (comboBox1.Text != ""))
            {
                string MySqlConnectionString = "Server=localhost; Port=3307; Database=salespoint; Uid=root; Pwd=221299;";
                MySqlConnection mySqlConnection = new MySqlConnection(MySqlConnectionString);
                MySqlCommand cmd;
                mySqlConnection.Open();
                try
                {
                    cmd = mySqlConnection.CreateCommand();
                    cmd.CommandText = "INSERT INTO productmagasine(productcode,productname,status,prixachat,prixvente,fournisseur)VALUES(@productcode,@productname,@status,@prixachat,@prixvente,@fournisseur)";

                    cmd.Parameters.AddWithValue("@productcode", textBox1.Text);
                    cmd.Parameters.AddWithValue("@productname", textBox2.Text);
                    cmd.Parameters.AddWithValue("@prixachat", textBox4.Text);
                    cmd.Parameters.AddWithValue("@prixvente", textBox3.Text);
                    cmd.Parameters.AddWithValue("@status", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@fournisseur", comboBox2.Text);
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

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            if (dataGridView1.SelectedRows[0].Cells[2].Value.ToString() == "Active")
            {
                comboBox1.SelectedIndex = 0;
            }
            else
            {
                comboBox1.SelectedIndex = 1;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //LoadData();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                datefinPro.Visible = true;
            }
            else {
                datefinPro.Visible = false;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /*private void LoadData()
{
string MySqlConnectionString = "Server=localhost; Port=3307; Database=salespoint; Uid=root; Pwd=221299;";
MySqlConnection mySqlConnection = new MySqlConnection(MySqlConnectionString);
mySqlConnection.Open();
try
{
MySqlCommand cmd = mySqlConnection.CreateCommand();
cmd.CommandText = "SELECT FROM productmagasine";
MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
DataSet ds = new DataSet();
adap.Fill(ds);
dataGridView1.DataSource = ds;


}
catch(Exception E)
{
MessageBox.Show("Error : " + E.Message);
}
finally
{
if(mySqlConnection.State == ConnectionState.Open)
{
mySqlConnection.Clone();
}
}

}*/
    }
}
