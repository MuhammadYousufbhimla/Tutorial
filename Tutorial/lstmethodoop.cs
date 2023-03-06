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
    public partial class lstmethodoop : Form
    {

        Student mainlist = new Student();
        public lstmethodoop()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student stu = new Student();
            stu.roll_no = int.Parse(txtrollno.Text);
            stu.name = txtname.Text;
            stu.age = txtage.Text;
            stu.f_name = txtfname.Text;
            stu.fess = txtfees.Text;
            stu.gender = txtgender.Text;
            mainlist.Save(stu);
            MessageBox.Show("Record Add Successfully..");
            Student.clearcontrol(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student s = mainlist.Search(int.Parse(txtrollno.Text));
            if (s != null)
            {
                txtname.Text = s.name;
                txtfname.Text = s.f_name;
                txtgender.Text = s.age;
                txtfees.Text = s.fess;
                txtage.Text = s.age;
            }
            else
            {
                MessageBox.Show("Record not found");
                Student.clearcontrol(this);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool chk = mainlist.Delete(int.Parse(txtrollno.Text));
            if (chk == true)
            {
                MessageBox.Show("Record Deleted Successfully");
                Student.clearcontrol(this);
            }
            else
            {
                MessageBox.Show("Record not found");
                Student.clearcontrol(this);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Student.clearcontrol(this);
        }
    }
}
