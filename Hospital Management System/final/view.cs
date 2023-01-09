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
    public partial class view : Form
    {
        public static int ek = 0;
        public view()
        {
            InitializeComponent();
        }

        private void view_Load(object sender, EventArgs e)
        {
            if (ek == 0)
            {
                label1.Text = appoinment.name2;
                label2.Text = appoinment.docname;
                label3.Text = appoinment.phone2;
                label4.Text = appoinment.pt;
            }
            else
            {
                label1.Text = "Empty";
                label2.Text = "Empty";
                label3.Text = "Empty";
                label4.Text = "Empty";
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
            cmd.CommandText = "DELETE FROM appoinment WHERE NAME ='" + textBox1.Text + "'";

            cmd.ExecuteNonQuery();
            con.Close();
            label1.Text = "Empty";
            label2.Text = "Empty";
            label3.Text = "Empty";
            label4.Text = "Empty";
            ek = 1;
            MessageBox.Show("dELETE Successfull");
        }
    }
}
