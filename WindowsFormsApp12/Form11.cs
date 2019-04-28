using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp12.DAL;

namespace WindowsFormsApp12
{
    public partial class Form11 : Form
    {
        Requests req;
        public Form11()
        {
            InitializeComponent();
            req = new Requests();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var t = numericUpDown1.Value;
            req.Task_1(t, dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            req.Task_2(dataGridView2);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            var t = numericUpDown2.Value;
            req.Task_3(t, dataGridView3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var ot = numericUpDown3.Value;
            var dot = numericUpDown4.Value;
            req.Task_4(ot, dot, dataGridView4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var day = numericUpDown7.Value;
            var ot = numericUpDown6.Value;
            var dot = numericUpDown5.Value;
            req.Task_5(day, ot, dot, dataGridView5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var date = numericUpDown9.Value;
            var id = numericUpDown8.Value;
            req.Task_2_1(date, id, dataGridView6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var id = numericUpDown10.Value;
            req.Task_2_2(id, dataGridView7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var day = numericUpDown11.Value;
            req.Task_2_3(day, dataGridView8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var date = numericUpDown12.Value;
            var id = numericUpDown13.Value;
            req.Task_3_1(date, id, dataGridView9);
        }

        private void dataGridView9_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            var id = numericUpDown14.Value;
            req.Task_3_2(id, dataGridView10);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var name = textBox1.Text;
            if(string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Введите название цвета!");
            }
            else
            {
                req.Task_3_3(name, dataGridView11);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var id = numericUpDown15.Value;
            req.Task_3_4(id, dataGridView12);
        }
    }
}
