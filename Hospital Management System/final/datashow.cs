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
    public partial class datashow : Form
    {
        public datashow()
        {
            InitializeComponent();
        }

        private void datashow_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || reason.Text == "" || phone.Text == "" || age.Text == "")
            {
                MessageBox.Show("You Have to fillup all the fields");
            }
            else if (textBox1.Text.Length < 4)
            {
                MessageBox.Show("Enter name of atleast 4 digit");
            }
            else if (phone.Text.Length < 11)
            {
                MessageBox.Show("Enter number of  11 digit");
            }
            else if (Int16.Parse(age.Text) < 1)
            {
                MessageBox.Show("Enter valid age");
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-IGFI2GR2\\SQLEXPRESS;Initial Catalog=H_M_S;Integrated Security=True");
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                if (textBox1.Text != "")
                {
                    cmd.CommandText = "UPDATE admit SET name='" + textBox1.Text + "' WHERE NAME ='" + name.Text + "'";
                }
                if (reason.Text != "")
                {
                    cmd.CommandText = "UPDATE admit SET reason='" + reason.Text + "' WHERE NAME ='" + name.Text + "'";
                }
                if (phone.Text != "")
                {
                    cmd.CommandText = "UPDATE admit SET phone='" + phone.Text + "' WHERE NAME ='" + name.Text + "'";
                }
                if (age.Text != "")
                {
                    cmd.CommandText = "UPDATE admit SET age='" + age.Text + "' WHERE NAME ='" + name.Text + "'";
                }
                if (checkBox1.Checked == true)
                {
                    cmd.CommandText = "UPDATE admit SET payment='" + checkBox1.Text + "' WHERE NAME ='" + name.Text + "'";
                    admitpatient.name1 = "hoise";
                }
                if (checkBox2.Checked == true)
                {
                    admitpatient.name1 = "hoinai";
                    cmd.CommandText = "UPDATE admit SET payment='" + checkBox2.Text + "' WHERE NAME ='" + name.Text + "'";
                }
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Update Successfull");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new admitpatient().Show();
            this.Hide();
        }
    }
}
