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
        
    }
}
