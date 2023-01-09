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
    public partial class doctoredit : Form
    {
        public doctoredit()
        {
            InitializeComponent();
        }

        private void doctoredit_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-IGFI2GR2\\SQLEXPRESS;Initial Catalog=H_M_S;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            if (textBox1.Text != "")
            {
                cmd.CommandText = "UPDATE doctor SET name='" + textBox1.Text + "' WHERE NAME ='" + name.Text + "'";
            }
            if (reason.Text != "")
            {
                cmd.CommandText = "UPDATE doctor SET Specialization='" + reason.Text + "' WHERE NAME ='" + name.Text + "'";
            }
            if (phone.Text != "")
            {
                cmd.CommandText = "UPDATE doctor SET institute='" + phone.Text + "' WHERE NAME ='" + name.Text + "'";
            }
            if (age.Text != "")
            {
                cmd.CommandText = "UPDATE doctor SET availibility='" + age.Text + "' WHERE NAME ='" + name.Text + "'";
            }
            
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Update Successfull");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new doctor().Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
