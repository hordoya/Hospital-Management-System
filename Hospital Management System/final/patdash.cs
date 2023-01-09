using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final
{
    public partial class patdash : Form
    {
        public patdash()
        {
            InitializeComponent();
        }

        private void patdash_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new appoinment().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new patdia().Show();
            this.Hide();
        }

        private void diahistory_Click(object sender, EventArgs e)
        {
            new patdiahis().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new patientadmit().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new view().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new patadmithis().Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new patlogincs().Show();
            this.Hide();
        }
    }
}
