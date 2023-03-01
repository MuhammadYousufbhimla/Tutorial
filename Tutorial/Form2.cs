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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name,Class,gpa,f_name,fees;

            name = txtname.Text;
            f_name = txtfname.Text;
            Class = txtclass.Text;
            gpa = txtgpa.Text;
            fees = txtfees.Text;

            MessageBox.Show("Student Information is : "+Environment.NewLine +name+Environment.NewLine+f_name+Environment.NewLine+Class+Environment.NewLine+gpa+Environment.NewLine+fees);

        }
    }
}
