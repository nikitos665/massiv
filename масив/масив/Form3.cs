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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sumc = 0; int sumn = 0;
            label2.Text = ""; double [] a = new double[15];
            Random rand = new Random();
            for (int i = 0; i < 15; i++)
            {
                a[i] = rand.Next(10, 50);
            }
            foreach (int x in a)
            {
                if (x % 2 == 0)
                    sumc++;
                if (x % 2 != 0)
                    sumn++;
            }
            label2.Text = "В массиве A\nЧётныx чисел: " + sumc + "\nНечётных чисел: " + sumn;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
