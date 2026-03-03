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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label2.Text = "";
            int n = Convert.ToInt32(textBox1.Text); double [] a = new double [n];
            Random random = new Random();
            for (int i = 0; i< n; i++)
            {
                a[i] = random.Next(1, 100);
            }double max = a[0]; int maxind = 1;
            double min = a[0]; int minind = 1;
            for (int i = 0; i < n; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                    maxind = (i+1);
                }
                if (a[i] < min)
                {
                    min = a[i];
                    minind = (i+1);
                }
            }
            label2.Text = label2.Text + "Максимальный элемент массива A = " + max +" с индексом "+ maxind;
            label2.Text = label2.Text + "\nМинимальный элемент массива A = " + min + " с индексом " + minind;
        }
    }
}
