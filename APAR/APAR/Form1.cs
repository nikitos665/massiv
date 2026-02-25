namespace APAR
{
    public partial class Form1 : Form
    {
        double[] a = new double[10];
        double i; double s;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            a[0] = Convert.ToDouble(textBox1.Text);
          
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "¬ведите элементы массива";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            a[1] = Convert.ToDouble(textBox2.Text);
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            a[2] = Convert.ToDouble(textBox3.Text);
           
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            a[3] = Convert.ToDouble(textBox4.Text);
          
        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {
            a[4] = Convert.ToDouble(textBox5.Text);
            
        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {
            a[5] = Convert.ToDouble(textBox6.Text);
           
        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {
            a[6] = Convert.ToDouble(textBox7.Text);
          
        }

        private void textBox8_TextChanged_1(object sender, EventArgs e)
        {
            a[7] = Convert.ToDouble(textBox8.Text);
        
        }

        private void textBox9_TextChanged_1(object sender, EventArgs e)
        {
            a[8] = Convert.ToDouble(textBox9.Text);
       
        }

        private void textBox10_TextChanged_1(object sender, EventArgs e)
        {
            a[9] = Convert.ToDouble(textBox10.Text);
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 9; i++)
            {
                s = s + a[i];
            }
            label2.Text = "ќтвет: " + s;
            s = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
