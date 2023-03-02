using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Tutorial
{
    public partial class List : Form
    {
        List<int> rollno = new List<int>();
        List<String> name = new List<String>();
        List<String> fname = new List<String>();
        List<String> age = new List<String>();
        List<String> fees = new List<String>();
        List<String> gender = new List<String>();




        public List()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clearcode();




        }

        private void button1_Click(object sender, EventArgs e)
        {
            int search = rollno.FindIndex(r => r == int.Parse(txtrollno.Text));

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




            }
            else
            {
                rollno.Add(int.Parse(txtrollno.Text));
                name.Add(txtname.Text);
                fname.Add(txtfname.Text);
                age.Add(txtage.Text);
                gender.Add(txtgender.Text);
                fees.Add(txtfees.Text);


            }
        
        /*  rollno.Add(int.Parse(txtrollno.Text));
          name.Add(txtname.Text);
          fname.Add(txtfname.Text);
          age.Add(txtage.Text);
          gender.Add(txtgender.Text);
          fees.Add(txtfees.Text);
          clearcode();
          MessageBox.Show("Add Record Successfully...");*/
    }

        private void button2_Click(object sender, EventArgs e)
        {
            int search = rollno.FindIndex(r => r == int.Parse(txtrollno.Text));

            if (search != -1)
            {
                txtname.Text = name[search];
                txtfname.Text = fname[search];
                txtfees.Text = fees[search];
                txtgender.Text = gender[search];
                txtage.Text = age[search];

            }
            else
            {
                MessageBox.Show("No Record In List");
            }
        }

        public void clearcode()
        {
            txtname.Clear();
            txtfname.Clear();
            txtage.Clear();
            txtgender.Clear();
            txtfees.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int delete = rollno.FindIndex(r => r == int.Parse(txtrollno.Text));
            if (delete != -1)
            {
                rollno.RemoveAt(delete);
                name.RemoveAt(delete);
                fname.RemoveAt(delete);
                age.RemoveAt(delete);
                fees.RemoveAt(delete);
                gender.RemoveAt(delete);

                MessageBox.Show("Record Successfully deleted ");
            }
            else {
                MessageBox.Show("Record not found in list");
}
        }
    }


}