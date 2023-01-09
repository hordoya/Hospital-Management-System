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
    public partial class patientreg : Form
    {
        public patientreg()
        {
            InitializeComponent();
        }

        private void patientreg_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            new patlogincs().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("You Have to fillup all the fields");
            }
            else if (textBox3.Text != textBox4.Text)
            {
                MessageBox.Show("Password mismatch");
            }
            else if (textBox1.Text.Length < 4)
            {
                MessageBox.Show("Enter 4 digit name");
            }
            
            else if (textBox3.Text.Length <4)
            {
                MessageBox.Show("Enter valid password");
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-IGFI2GR2\\SQLEXPRESS;Initial Catalog=H_M_S;Integrated Security=True");
                SqlCommand cmd = new SqlCommand(@"INSERT INTO patient VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                new patlogincs().Show();
                this.Hide();

            }
        }
    }
}
