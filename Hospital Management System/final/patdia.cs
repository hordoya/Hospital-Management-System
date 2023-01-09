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
    public partial class patdia : Form
    {
        public static string name1 = "";
        public static string phone1 = "";
        public static string age1 = "";
        public static int am ;
        public static int ekbar = 0;
        public patdia()
        {
            InitializeComponent();
            dspp();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ekbar == 0)
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
                if (name.Text == "" || phone.Text == "" || age.Text == "")
                {
                    MessageBox.Show("You Have to fillup all the fields");
                }
                else if (name.Text.Length < 4)
                {
                    MessageBox.Show("Enter 4 digit name");
                }
                else if (Int16.Parse(age.Text) < 1)
                {
                    MessageBox.Show("Enter valid age");
                }
                else if (phone.Text.Length != 11)
                {
                    MessageBox.Show("Enter valid phone number");
                }
                else
                {
                    name1 = name.Text;
                    phone1 = phone.Text;
                    age1 = age.Text;
                    am = u;
                    SqlConnection con = new SqlConnection("Data Source=LAPTOP-IGFI2GR2\\SQLEXPRESS;Initial Catalog=H_M_S;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO dia VALUES ('" + name.Text + "','" + u + "','" + phone.Text + "','" + age.Text + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    ekbar = 1;
                    MessageBox.Show("Successfull");
                }
            }
            else if(ekbar==1)
            {
                MessageBox.Show("You can enter only one time");
            }
        }
        public void dspp()
        {
            Console.WriteLine(name.Text);
            Console.WriteLine(phone.Text);
            Console.WriteLine(age.Text);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            new patdash().Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
