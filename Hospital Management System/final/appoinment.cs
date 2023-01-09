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
    public partial class appoinment : Form
    {
        public static int ekbar = 0;
        public static string name2 = "";
        public static string docname = "";
        public static string age2 = "";
        public static string phone2 = "";
        public static string pt = "";
        public appoinment()
        {
            InitializeComponent();
            dspp();
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
            else if (textBox2.Text.Length < 4)
            {
                MessageBox.Show("Enter 4 digit name");
            }
            else if (textBox3.Text.Length != 11)
            {
                MessageBox.Show("Enter valid phone number");
            }

            if (ekbar == 0)
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-IGFI2GR2\\SQLEXPRESS;Initial Catalog=H_M_S;Integrated Security=True");
                SqlCommand cmd = new SqlCommand(@"INSERT INTO appoinment values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                ekbar = 1;
                name2 = textBox1.Text;
                docname = textBox2.Text;
                phone2 = textBox3.Text;
                pt = textBox4.Text;
                MessageBox.Show("Successfull");
            }
            else
            {
                MessageBox.Show("can not enter twice");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new patdash().Show();
            this.Hide();
        }
    }
}
