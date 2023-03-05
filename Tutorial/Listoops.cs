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
    public partial class Listoops : Form
    {
        List<Student> lst = new List<Student>();
        public Listoops()
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
            lst.Add(stu);
            MessageBox.Show("ADD Record Successfully");
            clear();
        }
        private void clear()
        {
            txtage.Clear();
            txtfname.Clear();
            txtname.Clear();
            txtgender.Clear();
            txtrollno.Clear();
            txtfees.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student stu = new Student();
            int index = lst.FindIndex(r => r.roll_no == int.Parse(txtrollno.Text));
            if (index != -1)
            {
                txtname.Text = lst[index].name;
                txtfname.Text = lst[index].f_name;
                txtgender.Text = lst[index].gender;
                txtfees.Text = lst[index].fess;
                txtage.Text = lst[index].age;
            }
            else
            {
                MessageBox.Show("Record Not Found");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Student stu = new Student();
            int index = lst.FindIndex(r => r.roll_no == int.Parse(txtrollno.Text));
            if (index != -1)
            {
                lst.RemoveAt(index);
                clear();

            }
            else
            {
                MessageBox.Show("Record Not Found");
            }
            
        }
    }
}
