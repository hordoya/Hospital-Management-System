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
    public partial class admitpatient : Form
    {
        public static int ee =0;
        public static string name1 = "";
        public admitpatient()
        {
            InitializeComponent();
            dsp();
        }

        private void admitpatient_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new reciep().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || reason.Text == "" || phone.Text == "" || age.Text == "")
            {
                MessageBox.Show("You Have to fillup all the fields");
            }
            else if(name.Text.Length<4)
            {
                MessageBox.Show("Enter 4 digit name");
            }
            else if (phone.Text.Length != 11)
            {
                MessageBox.Show("Enter valid phone number");
            }
            else if (Int16.Parse(age.Text) <1)
            {
                MessageBox.Show("Enter valid age");
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
                    name1 = "hoinai";
                    MessageBox.Show("Successfull");
                    dsp();
                }
                else if (checkBox1.Checked == true)
                {
                    SqlConnection con = new SqlConnection("Data Source=LAPTOP-IGFI2GR2\\SQLEXPRESS;Initial Catalog=H_M_S;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO admit VALUES ('" + textBox2.Text + "','" + name.Text + "','" + reason.Text + "','" + phone.Text + "','" + age.Text + "','" + checkBox1.Text + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    name1 = "hoise";
                    MessageBox.Show("Successfull");
                    dsp();
                }
            }
        }
        public void dsp()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-IGFI2GR2\\SQLEXPRESS;Initial Catalog=H_M_S;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM admit";

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dsp();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new datashow().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
