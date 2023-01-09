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
    public partial class diaedit : Form
    {
        public diaedit()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (name.Text == "")
            {
                MessageBox.Show("You Have to fillup name box");
            }
           
            else
            {
                int u = 0;
                if (checkBox1.Checked == true)
                {
                    u += 800;
                }
                if (checkBox2.Checked == true)
                {
                    u += 400;
                }
                if (checkBox3.Checked == true)
                {
                    u += 200;
                }
                if (checkBox4.Checked == true)
                {
                    u += 500;
                }
                if (checkBox5.Checked == true)
                {
                    u += 1000;
                }
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-IGFI2GR2\\SQLEXPRESS;Initial Catalog=H_M_S;Integrated Security=True");
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                if (textBox1.Text != "")
                {
                    cmd.CommandText = "UPDATE dia SET name='" + textBox1.Text + "' WHERE NAME ='" + name.Text + "'";
                }
                if (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true || checkBox4.Checked == true || checkBox5.Checked == true)
                {
                    cmd.CommandText = "UPDATE dia SET service='" + u + "' WHERE NAME ='" + name.Text + "'";
                }
                if (phone.Text != "")
                {
                    cmd.CommandText = "UPDATE dia SET phn='" + phone.Text + "' WHERE NAME ='" + name.Text + "'";
                }
                if (age.Text != "")
                {
                    cmd.CommandText = "UPDATE dia SET age='" + age.Text + "' WHERE NAME ='" + name.Text + "'";
                }

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Update Successfull");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new dia().Show();
            this.Hide();
        }
    }
}
