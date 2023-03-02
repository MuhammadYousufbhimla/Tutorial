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
    public partial class Array : Form
    {
        String[] name = new String[2];
        String[] fname = new String[2];
        String[] age = new String[2];
        String[] gender = new String[2];
        String[] fees = new String[2];

        String Recordcount = "1";
        String Recorddisplay = "1";

        public Array()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Recordcount == "1")
            {
                name[0] = txtname.Text;
                fname[0] = txtfname.Text;
                age[0] = txtage.Text;
                fees[0] = txtfees.Text;
                gender[0] = txtgender.Text;
                MessageBox.Show("Add First Record");

                Recordcount = "2";
            }
            else if (Recordcount == "2")
            {
                name[1] = txtname.Text;
                fname[1] = txtfname.Text;
                age[1] = txtage.Text;
                fees[1] = txtfees.Text;
                gender[1] = txtgender.Text;
                MessageBox.Show("Add second Record");
            }
            else
            {
                MessageBox.Show("Array Limit Finished");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Recorddisplay == "1")
            {
                txtname.Text = name[0];
                txtfname.Text = fname[0];
                txtage.Text = age[0];
                txtfees.Text = fees[0];
                txtgender.Text =gender[0];

                Recorddisplay = "2";

            }
            else if (Recorddisplay == "2")
            {
                txtname.Text = name[1];
                txtfname.Text = fname[1];
                txtage.Text = age[1];
                txtfees.Text = fees[1];
                txtgender.Text = gender[1];
            }
            else
            {
                MessageBox.Show("No Record Found");
            }
        }
    }
}
