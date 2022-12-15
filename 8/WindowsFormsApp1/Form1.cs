using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<string> girlNames = new List<string>();
        List<string> boyNames = new List<string>();

        public Form1()
        {
            InitializeComponent();

            girlNames = System.IO.File.ReadAllLines("GirlNames.txt").ToList();
            boyNames = System.IO.File.ReadAllLines("BoyNames.txt").ToList();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            string girlName = textBox1.Text;
            string boyName = textBox2.Text;

        
            if (girlNames.Contains(girlName))
            {
                MessageBox.Show($"{girlName} is among the most popular names given to girls born in Estonia.");
            }
            else
            {
                MessageBox.Show($"{girlName} is not among the most popular names given to girls born in Estonia.");
            }

            if (boyNames.Contains(boyName))
            {
                MessageBox.Show($"{boyName} is among the most popular names given to boys born in Estonia.");
            }
            else
            {
                MessageBox.Show($"{boyName} is not among the most popular names given to boys born in Estonia.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
