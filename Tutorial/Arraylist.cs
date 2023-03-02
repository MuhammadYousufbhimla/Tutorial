using System;
using System.Collections;
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
    public partial class Arraylist : Form
    {
        ArrayList rollno = new ArrayList();
        ArrayList name = new ArrayList();
        ArrayList fname = new ArrayList();
        ArrayList age = new ArrayList();
        ArrayList gender = new ArrayList();
        ArrayList fees = new ArrayList();



        public Arraylist()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int search = rollno.IndexOf(int.Parse(txtrollno.Text));

            if (search != -1)
            {
                rollno.RemoveAt(search);
                name.RemoveAt(search);
                fname.RemoveAt(search);
                age.RemoveAt(search);
                gender.RemoveAt(search);
                fees.RemoveAt(search);


                rollno.Insert(search, int.Parse(txtrollno.Text));
                name.Insert(search, txtname.Text);
                fname.Insert(search, txtfname.Text);
                fees.Insert(search, txtfees.Text);
                gender.Insert(search, txtgender.Text);
                age.Insert(search, txtage.Text);
                clearcode();



            }
            else
            {
                rollno.Add(int.Parse(txtrollno.Text));
                name.Add(txtname.Text);
                fname.Add(txtfname.Text);
                age.Add(txtage.Text);
                gender.Add(txtgender.Text);
                fees.Add(txtfees.Text);
                MessageBox.Show("Add Record Successfully ");
                clearcode();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = rollno.IndexOf(int.Parse(txtrollno.Text));
            if (index != -1)
            {
                txtname.Text = name[index].ToString();
                txtfname.Text = fname[index].ToString();
                txtage.Text = age[index].ToString();
                txtfees.Text = fees[index].ToString();
                txtgender.Text = gender[index].ToString();


            }
            else
            {
                MessageBox.Show("Record Not found in array list");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = rollno.IndexOf(int.Parse(txtrollno.Text));
            if (index != -1)
            {
                rollno.RemoveAt(index);
                name.RemoveAt(index);
                fname.RemoveAt(index);
                fees.RemoveAt(index);
                gender.RemoveAt(index);
                age.RemoveAt(index);
                MessageBox.Show("Record Deleted in Arraylist");
            }
            else
            {
                MessageBox.Show("Record not found in array list ");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clearcode();
        }
        private void clearcode()
        {
            txtname.Clear();
            txtfname.Clear();
            txtage.Clear();
            txtgender.Clear();
            txtfees.Clear();
        }
    }
}
