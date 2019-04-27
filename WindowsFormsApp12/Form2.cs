using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 h1 = new Form3();
            h1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 h2 = new Form4();
            h2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 h3 = new Form5();
            h3.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 h4 = new Form6();
            h4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 h5 = new Form7();
            h5.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form8 h6 = new Form8();
            h6.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form9 h7 = new Form9();
            h7.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form10 h8 = new Form10();
            h8.Show();
        }
    }
}
