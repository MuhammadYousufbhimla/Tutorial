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
    public partial class Form4 : Form
    {
        String name, fname, age, fees, gender;

        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            name = txtname.Text;
            fname = txtfname.Text;
            age = txtage.Text;
            fees = txtfees.Text;
            gender = txtgender.Text;

            MessageBox.Show("Record add Successfully..");

            txtname.Text = "";
            txtfname.Text = "";
            txtage.Text = "";
            txtgender.Text = "";
            txtfees.Clear();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtname.Text = name;
            txtfname.Text = fname;
            txtgender.Text = gender;
            txtfees.Text = fees;
            txtage.Text = age;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtname.Text = "";
            txtfname.Text = "";
            txtage.Text = "";
            txtgender.Text = "";
            txtfees.Clear();
        }
    }
}
