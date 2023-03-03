using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial
{
    public partial class Dictionary : Form
    {
        Dictionary<int, string> discity = new Dictionary<int, string>();

        public Dictionary()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void clear()
        {

            txtcity.Clear();
            txtname.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int city = int.Parse(txtcity.Text);
            String name = txtname.Text;
            if (discity.ContainsKey(city) == true)
            {
                discity[city] = name;
            }
            else
            {
                discity.Add(city, name);
                clear();
                MessageBox.Show("City Add Successfully..");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int city = int.Parse(txtcity.Text);
            if (discity.ContainsKey(city) == true)
            {
                txtname.Text = discity[city];
            }
            else
            {
                MessageBox.Show("Record not found in Dictionary");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int city = int.Parse(txtcity.Text);
            if (discity.ContainsKey(city) == true)
            {
                discity.Remove(city);
            }
            else
            {
                MessageBox.Show("Record not found in Dictionary");
            }
        }
    }
}
