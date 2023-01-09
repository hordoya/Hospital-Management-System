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
    public partial class patientadmit : Form
    {
        public static int ekbar1 = 0;
        public static string name3 = "";
        public static string docname3 = "";
        public static string age3 = "";
        public static string phone3 = "";
        public static string re3 = "";
        public patientadmit()
        {
            InitializeComponent();
        }

        private void patientadmit_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ekbar1 == 0)
            {
                if (name.Text == "" || reason.Text == "" || phone.Text == "" || age.Text == "")
                {
                    MessageBox.Show("You Have to fillup all the fields");
                }
                else if (name.Text.Length < 4)
                {
                    MessageBox.Show("Enter 4 digit name");
                }
                else if (Int16.Parse(textBox2.Text) < 1)
                {
                    MessageBox.Show("Enter valid age");
                }
                else if (phone.Text.Length != 11)
                {
                    MessageBox.Show("Enter valid phone number");
                }

                else
                {
                    if (checkBox2.Checked == true)
                    {
                        SqlConnection con = new SqlConnection("Data Source=LAPTOP-IGFI2GR2\\SQLEXPRESS;Initial Catalog=H_M_S;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand(@"INSERT INTO admit VALUES ('" + textBox2.Text + "','" + name.Text + "','" + reason.Text + "','" + phone.Text + "','" + age.Text + "','" + checkBox2.Text + "')", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    
                        MessageBox.Show("Successfull");
                      
                    }
                    else if (checkBox1.Checked == true)
                    {
                        SqlConnection con = new SqlConnection("Data Source=LAPTOP-IGFI2GR2\\SQLEXPRESS;Initial Catalog=H_M_S;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand(@"INSERT INTO admit VALUES ('" + textBox2.Text + "','" + name.Text + "','" + reason.Text + "','" + phone.Text + "','" + age.Text + "','" + checkBox1.Text + "')", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Successfull");
                    }
                }
            }
            else
            {
                MessageBox.Show("u can enter only once");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new patdash().Show();
            this.Hide();
        }
    }
}
