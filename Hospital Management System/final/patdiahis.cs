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

    public partial class patdiahis : Form
    {
        public static int ek = 0;
        public patdiahis()
        {
            InitializeComponent();
         
        }
        

        private void label1_Click(object sender, EventArgs e)
        {
           

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void patdiahis_Load(object sender, EventArgs e)
        {
            if (ek == 0)
            {
                if (patdia.name1 == "" || patdia.phone1 == "" || patdia.age1 == "")
                {
                    label2.Text = "EMPTY";
                }
                else
                {
                    name.Text = patdia.name1;
                    label2.Text = patdia.phone1;
                    label3.Text = patdia.age1;
                    label4.Text = patdia.am.ToString();
                }
            }
            else
            {
                name.Text = "Empty";
                label2.Text = "Empty";
                label3.Text = "Empty";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new patdash().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-IGFI2GR2\\SQLEXPRESS;Initial Catalog=H_M_S;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM dia WHERE NAME ='" + textBox1.Text + "'";

            cmd.ExecuteNonQuery();
            con.Close();
            name.Text = "empty";
            label2.Text = "empty";
            label3.Text = "empty";
            ek = 1;
            MessageBox.Show("dELETE Successfull");
        }
    }
}
