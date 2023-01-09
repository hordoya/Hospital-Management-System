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
    public partial class recappoinment : Form
    {
        public static int ekbar1 = 0;
        public static string name3 = "";
        public static string docname3 = "";
        public static string age3 = "";
        public static string phone3 = "";
        public static string re3 = "";
        public recappoinment()
        {
            InitializeComponent();
            dspp();
            dsp();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox4.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("You Have to fillup all the fields");
            }
            else if (textBox1.Text.Length < 4)
            {
                MessageBox.Show("Enter 4 digit name");
            }
            else if (textBox3.Text.Length != 11)
            {
                MessageBox.Show("Enter valid phone number");
            }
            
            else
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-IGFI2GR2\\SQLEXPRESS;Initial Catalog=H_M_S;Integrated Security=True");
                SqlCommand cmd = new SqlCommand(@"INSERT INTO appoinment values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                name3 = textBox1.Text;
                docname3 = textBox2.Text;
                age3 = textBox3.Text;
                MessageBox.Show("Successfull");
            }
        }
        public void dspp()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-IGFI2GR2\\SQLEXPRESS;Initial Catalog=H_M_S;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM appoinment";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        public void dsp()
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
            dataGridView2.DataSource = dt;
            con.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dspp();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dsp();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new reciep().Show();
            this.Hide();
        }
    }
}
