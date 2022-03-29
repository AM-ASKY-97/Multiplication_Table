using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiplication_Table
{
    public partial class Mul_2Form : Form
    {
        public Mul_2Form()
        {
            InitializeComponent();
        }

        private void Mul_2Form_Load(object sender, EventArgs e)
        {
            for (int i=1; i <= 20; i++)
            {
                listBox1.Items.Add(" 2 " + " x  " + i + "  " + " =  " + 2*i);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            home_page hp = new home_page();
            hp.Show();
            this.Hide();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Click_form ck = new Click_form();
            ck.Show();
            this.Hide();
        }
    }
}
