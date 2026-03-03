using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace масив
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = ""; double [] a = new double[5];
            a = textBox1.Text.Split(' ').Select(double.Parse).ToArray();
            label2.Text = "Изначальный массив: ";
            for (int i = 0; i < 5; i++)
            {
                label2.Text = label2.Text + a[i] + " ";
            }
            label2.Text = label2.Text + "\nРеверсивный массив: ";
            double ser = a[0]; a[0] = a[4]; a[4] = ser; ser = a[1]; a[1] = a[3]; a[3] = ser;
            for (int i = 0; i < 5; i++)
            {
                label2.Text = label2.Text + a[i] + " ";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
