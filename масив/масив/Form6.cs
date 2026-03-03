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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = ""; double [] a = new double[10];
            int sum = 0;
            a = textBox1.Text.Split(' ').Select(double.Parse).ToArray();
            double set;
            bool [] counted = new bool [10];
            for (int i = 0; i < 10; i++)
            {
                if (counted[i]) continue; 
                for (int j = 0; j < 10; j++)
                {
                    if (a[i] == a[j])
                    {
                        sum++;
                        counted[j] = true;
                    }
                }
                if (sum > 1)
                    label2.Text = label2.Text + "\nЧисло " + a[i] + " встречается: " + sum + " раз";
                sum = 0;
            }
        }
    }
}
