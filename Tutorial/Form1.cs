namespace Tutorial
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name;
            name = txtname.Text;
            MessageBox.Show("Add Record" +name);
        }
    }
}