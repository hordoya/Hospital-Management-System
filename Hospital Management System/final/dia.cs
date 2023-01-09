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
    public partial class dia : Form
    {
        public dia()
        {
            InitializeComponent();
            dsp();
        }

        private void dia_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
            else if(name.Text.Length<4)
            {
                MessageBox.Show("You Have to enter 4 digit of length");
            }
            else if (phone.Text.Length < 11)
            {
                MessageBox.Show("Enter valid phone number");
            }
            else if (Int16.Parse(age.Text) <1)
            {
                MessageBox.Show("Enter valid age");
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-IGFI2GR2\\SQLEXPRESS;Initial Catalog=H_M_S;Integrated Security=True");
                SqlCommand cmd = new SqlCommand(@"INSERT INTO dia VALUES ('" + name.Text + "','" + u + "','" + phone.Text + "','" + age.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfull");
                dsp(); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new reciep().Show();
            this.Hide();
        }
        public void dsp()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-IGFI2GR2\\SQLEXPRESS;Initial Catalog=H_M_S;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM dia";

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

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            new diaedit().Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void age_TextChanged(object sender, EventArgs e)
        {

        }

        private void phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
