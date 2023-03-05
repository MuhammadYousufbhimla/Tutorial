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
    public partial class ForLoop : Form
    {

        public ForLoop()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int no_table = int.Parse(txtnotable.Text);
            int start_tabel = int.Parse(txtstarttable.Text);
            int end_table = int.Parse(txtendtable.Text);
            String result = "";

            for (int count = start_tabel; count <= end_table; count++)
            {
                result = result + (no_table).ToString() + "X" + (count).ToString() + "=" + (count * no_table).ToString() + Environment.NewLine;

            }
            label4.Text = result;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<String> lstname = new List<string>();
            String result = "";
            lstname.Add("Muhammad");
            lstname.Add("Yousuf");

            lstname.Add("Asad");
            lstname.Add("Saleem");

            foreach (String name in lstname)
            {
                if (name.ToLower() == "Muhammad")
                {
                    MessageBox.Show("Equal name");
                }
                else
                {
                    MessageBox.Show("Not Equal name");
                }
                result = result + name + Environment.NewLine;
            }
            label5.Text = result;
        }
    }
}
