using System;
using System.Windows.Forms;
using WindowsFormsApp12.DAL;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            new Requests().InitializerDb();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 r = new Form2();
            r.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form11 f = new Form11();
            f.Show();
        }
    }
}
