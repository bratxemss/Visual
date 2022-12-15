using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _11
{


    public partial class Form1 : Form
    {
        Pet myPet;
        public Form1()
        {
            InitializeComponent();
            myPet = new Pet();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            myPet.Name = textBox1.Text;
            myPet.Type = textBox2.Text;
            myPet.Age = Convert.ToInt32(textBox3.Text);
        }

        // In another button click event handler, retrieve the values of the
        // Name, Type, and Age properties of the Pet object and display them
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name: " + myPet.Name + "\nType: " + myPet.Type + "\nAge: " + myPet.Age);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
