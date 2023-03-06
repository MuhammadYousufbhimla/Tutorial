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
    public partial class genericclass : Form
    {
        generic<Student> mainclass = new generic<Student>();
        public genericclass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student stu = new Student();
            stu.roll_no = int.Parse(txtrollno.Text);
            stu.name = txtname.Text;
            stu.f_name = txtfname.Text;
            stu.gender = txtgender.Text;
            stu.fess = txtfees.Text;
            stu.age = txtage.Text;
            Predicate<Student> cond = (c => c.roll_no == int.Parse(txtrollno.Text));
            mainclass.Save(stu, cond);
            MessageBox.Show("Record Add Successfully");
            generic<Student>.clearcontrol(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Predicate<Student> cond = (c => c.roll_no == int.Parse(txtrollno.Text));
            Student stu = (Student)mainclass.Serach(cond);
            if (stu != null)
            {
                txtname.Text = stu.name;
                txtfname.Text = stu.f_name;
                txtgender.Text = stu.gender;
                txtfees.Text = stu.fess;
                txtage.Text = stu.age;

            }
            else
            {
                MessageBox.Show("Record not found");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Predicate<Student> cond = (c => c.roll_no == (int.Parse(txtrollno.Text)));
            bool check = mainclass.delete(cond);
            if (check == true)
            {
                MessageBox.Show("Record Deleted Successfully");
                generic<Student>.clearcontrol(this);
            }
            else
            {
                MessageBox.Show("Record not Found");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            generic<Student>.clearcontrol(this);
        }
    }
}
