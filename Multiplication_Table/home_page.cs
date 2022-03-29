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
    public partial class home_page : Form
    {
        public home_page()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            Mul_2Form f2 = new Mul_2Form();
            f2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            Mul_3Form f3 = new Mul_3Form();
            f3.Show();
            this.Hide();
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            Mul_4Form f4 = new Mul_4Form();
            f4.Show();
            this.Hide();
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            Mul_5Form f5 = new Mul_5Form();
            f5.Show();
            this.Hide();
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            Mul_6Form f6 = new Mul_6Form();
            f6.Show();
            this.Hide();
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            Mul_7Form f7 = new Mul_7Form();
            f7.Show();
            this.Close();
        }

        private void btneight_Click(object sender, EventArgs e)
        {
            Mul_8Form f8 = new Mul_8Form();
            f8.Show();
            this.Hide();
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            Mul_9Form f9 = new Mul_9Form();
            f9.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Click_form ck = new Click_form();
            ck.Show();
            this.Hide();
        }
    }
}
