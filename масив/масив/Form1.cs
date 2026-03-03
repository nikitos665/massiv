using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace масив
{
    public partial class Form1 : Form
    {
        int w = 0;
        Form2 a = new Form2();
        Form3 b = new Form3();
        Form4 c = new Form4();
        Form5 d = new Form5();
        Form6 es = new Form6();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (w)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 0: label2.Text = "Вы не выбрали режим "; break;



            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            b.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            c.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            d.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            es.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
