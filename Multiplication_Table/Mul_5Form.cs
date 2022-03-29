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
    public partial class Mul_5Form : Form
    {
        public Mul_5Form()
        {
            InitializeComponent();
        }

        private void Mul_5Form_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 20; i++)
            {
                listBox1.Items.Add(" 5 " + " x  " + i + "  " + " =  " + 5 * i);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            home_page hp = new home_page();
            hp.Show();
            this.Hide();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExi_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            Click_form ck = new Click_form();
            ck.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
