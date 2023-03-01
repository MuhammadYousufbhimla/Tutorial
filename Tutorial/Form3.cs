using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b;
            a = int.Parse(txtfirstnum.Text);
            b = int.Parse(txtsecondnum.Text);
            txtresult.Text = (a - b).ToString();
            MessageBox.Show("Add Number is " + txtresult.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            a = int.Parse(txtfirstnum.Text);
            b = int.Parse(txtsecondnum.Text);
            txtresult.Text = (a + b).ToString();
            MessageBox.Show("Add Number is " + txtresult.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a, b;
            a = int.Parse(txtfirstnum.Text);
            b = int.Parse(txtsecondnum.Text);
            txtresult.Text = (a * b).ToString();
            MessageBox.Show("Add Number is " + txtresult.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a, b;

            {
                a = int.Parse(txtfirstnum.Text);
                b = int.Parse(txtsecondnum.Text);
                if (b == 0)
                {
                    MessageBox.Show("Not divide");
                }
                else
                {
                    txtresult.Text = (a / b).ToString();


                    MessageBox.Show("Add Number is " + txtresult.Text);
                }
            }
        }
    }
}
