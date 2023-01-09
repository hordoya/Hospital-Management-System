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
    public partial class cuspatadmit : Form
    {
        public cuspatadmit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || reason.Text == "" || phone.Text == "" || age.Text == "")
            {
                MessageBox.Show("You Have to fillup all the fields");
            }

            else
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-IGFI2GR2\\SQLEXPRESS;Initial Catalog=H_M_S;Integrated Security=True");
                SqlCommand cmd = new SqlCommand(@"INSERT INTO admit VALUES ('" + textBox2.Text + "','" + name.Text + "','" + reason.Text + "','" + phone.Text + "','" + age.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfull");
             
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new patdash().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
