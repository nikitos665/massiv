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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;  label2.Text = ""; n = Convert.ToInt32(textBox1.Text); double [] a = new double[n]; double[] b = new double[n];
            Random randik = new Random();
            label2.Text = "Изначальный массив: ";
            for (int i = 0; i < n; i++)
            {
                a[i] = randik.Next(1, 100);
                label2.Text = label2.Text + a[i] + " ";
            }
            double isnac = 0; double posl = 0;
            for (int i = 0; i < n; i++)
            {
                if (n - i != 1)
                    b[i + 1] = a[i];
                else b[0] = a[i];
            }
            label2.Text = label2.Text + "\nПеределанный массив: ";
            for (int i = 0; i < n; i++)
            {
                label2.Text = label2.Text + b[i] + " ";
            }
        }
    }
}
