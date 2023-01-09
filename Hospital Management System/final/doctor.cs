using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace final
{
    public partial class doctor : Form
    {
        public doctor()
        {
            InitializeComponent();
            dspp();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text=="")
            {
                MessageBox.Show("You Have to fillup all the fields");
            }
            else if(textBox1.Text.Length<4)
            {
                MessageBox.Show("Enter name of atleast 4 digit");
            }
            else if (textBox2.Text.Length < 4)
            {
                MessageBox.Show("Enter specialization of atleast 4 digit");
            }
            else if (textBox2.Text.Length < 4)
            {
                MessageBox.Show("Enter institute of atleast 4 digit");
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-IGFI2GR2\\SQLEXPRESS;Initial Catalog=H_M_S;Integrated Security=True");
                SqlCommand cmd = new SqlCommand(@"INSERT INTO doctor VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfull");
                dspp();
            }
        }
        public void dspp()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-IGFI2GR2\\SQLEXPRESS;Initial Catalog=H_M_S;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM doctor";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dspp();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            new reciep().Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new doctoredit().Show();
            this.Hide();
        }
    }
}
