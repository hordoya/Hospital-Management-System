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
    public partial class reciep : Form
    {
        public reciep()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new admitpatient().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new doctor().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new dia().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new patcheckout().Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new doccheck().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new recappoinment().Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void apcheckout_Click(object sender, EventArgs e)
        {
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();
        }
    }
}
