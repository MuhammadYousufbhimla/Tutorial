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
    public partial class Hashing : Form
    {
        Hashtable ht = new Hashtable();
        public Hashing()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int city = int.Parse(txtcity.Text);
            string name = txtname.Text;
            if (ht.ContainsKey(txtcity.Text) == true)
            {
                ht[city] = name;
            }
            else
            {
                ht.Add(txtcity.Text, txtname.Text);
                MessageBox.Show("Add Record Successfully...");
                clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ht.ContainsKey(txtcity.Text) == true)
            {
                txtname.Text = ht[txtcity.Text].ToString();
            }
            else
            {
                MessageBox.Show("Record Not found");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ht.ContainsKey(txtcity.Text) == true)
            {
                ht.Remove(txtcity.Text);
                clear();

            }
            else
            {
                MessageBox.Show("Record not found");
            }
        }
        private void clear()
        {
            txtcity.Clear();
            txtname.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
