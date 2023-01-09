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
    public partial class patlogincs : Form
    {
        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        public static string SetValueForText3 = "";
        public patlogincs()
        {
            InitializeComponent();
        }

        private void patlogincs_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new patientreg().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("You Have to fillup all the fields");
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-IGFI2GR2\\SQLEXPRESS;Initial Catalog=H_M_S;Integrated Security=True");
                string cmd = "SELECT COUNT(*) FROM patient WHERE name ='" + textBox1.Text + "' and Password='" + textBox2.Text + "'";
                SqlDataAdapter cm = new SqlDataAdapter(cmd, con);
                DataTable dt = new DataTable();
                cm.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    new patdash().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("unSuccessfull");
                }
            }
        }
    }
}
