using System.Windows.Forms;
using System;

namespace WindowsFormsApp22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {





        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int a;
            int b;
            int d;
            int x;
            int g;
            int x1;
            int d1;
            int p;
            int o;


            a = Convert.ToInt32(textBox3.Text);
            b = Convert.ToInt32(textBox4.Text);
            d = Convert.ToInt32(textBox1.Text);
            x = Convert.ToInt32(textBox2.Text);

            if ((a >= b) && (a % b == 0))
            {

                g = a / b;
                x1 = x * g;
                p = x1 + d;
                label1.Text = Convert.ToString(p);
                label2.Text = Convert.ToString(a);

            }
            else if ((b >= a) && (b % a == 0))
            {
                g = b / a;
                d1 = d * g;
                p = d1 + x;
                label1.Text = Convert.ToString(p);
                label2.Text = Convert.ToString(b);

            }
            else
            {
                o = a * b;
                p = (d * b) + (x * a);
                label1.Text = Convert.ToString(p);
                label2.Text = Convert.ToString(o);

            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int a;
            int b;
            int d;
            int x;
            int g;
            int x1;
            int d1;
            int p;
            int o;


            a = Convert.ToInt32(textBox3.Text);
            b = Convert.ToInt32(textBox4.Text);
            d = Convert.ToInt32(textBox1.Text);
            x = Convert.ToInt32(textBox2.Text);

            if ((a >= b) && (a % b == 0))
            {

                g = a / b;
                x1 = x * g;
                p = d - x1;
                label1.Text = Convert.ToString(p);
                label2.Text = Convert.ToString(a);

            }
            else if ((b >= a) && (b % a == 0))
            {
                g = b / a;
                d1 = d * g;
                p = d1 - x;
                label1.Text = Convert.ToString(p);
                label2.Text = Convert.ToString(b);

            }
            else
            {
                o = a * b;
                p = (d * b) - (x * a);
                label1.Text = Convert.ToString(p);
                label2.Text = Convert.ToString(o);

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            int x;
            int d;
            int p;
            int o;
            a = Convert.ToInt32(textBox3.Text);
            b = Convert.ToInt32(textBox4.Text);
            d = Convert.ToInt32(textBox1.Text);
            x = Convert.ToInt32(textBox2.Text);
            p = x * d;
            o = b * a;
            label1.Text = Convert.ToString(p);
            label2.Text = Convert.ToString(o);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            int x;
            int d;
            int p;
            int o;
            a = Convert.ToInt32(textBox3.Text);
            b = Convert.ToInt32(textBox4.Text);
            d = Convert.ToInt32(textBox1.Text);
            x = Convert.ToInt32(textBox2.Text);
            p = b * d;
            o = x * a;
            label1.Text = Convert.ToString(p);
            label2.Text = Convert.ToString(o);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }


}