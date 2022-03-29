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
    public partial class Click_form : Form
    {
        public Click_form()
        {
            InitializeComponent();
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                int i;
                int no1n = 0;
                int startn = 0;
                int endn = 0;

                no1n = Convert.ToInt32(txtenNum.Text);
                startn = Convert.ToInt32(txt_StartNum.Text);
                endn = Convert.ToInt32(txtEndNum.Text);

                for (i = startn; i <= endn; i++)
                {
                    listBox1.Items.Add(no1n + " x  " + i + "  " + " =  " + no1n * i);
                }
            }

            catch
            {
                MessageBox.Show("Fill the all textbox", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtenNum.Focus();
            }
        }

        private void Click_form_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            home_page hp = new home_page();
            hp.Show();
            this.Hide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtenNum.Text = "";
            txt_StartNum.Text = "";
            txtEndNum.Text = "";
            listBox1.Items.Clear();

            txtenNum.Focus();

        }

        private void btnExite_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
