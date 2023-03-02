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
    public partial class Array1d : Form
    {
        int i = 0;
        int j = 0;

        String[] name = new String[2];
        int[] Rollno = new int[2];
        
        public Array1d()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name[i] = txtname.Text;
            Rollno[i] = int.Parse(txtrollno.Text);
            i++;
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtname.Text = name[j];
            txtrollno.Text = Rollno[j].ToString();
            MessageBox.Show("Name:" + name[j] + Environment.NewLine + "Roll no:" + Rollno[j]);
            j++;
        }
    }
}
