using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Individual_Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void class_a_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void class_a_output_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                int text_a_int = Int32.Parse(class_a_input.Text) * 15;
                class_a_output.Text = text_a_int.ToString();
                int text_b_int = Int32.Parse(class_b_input.Text) * 12;
                class_b_output.Text = text_b_int.ToString();
                int text_c_int = Int32.Parse(class_c_input.Text) * 9;
                class_c_output.Text = text_c_int.ToString();

                int all_output_calculated = Int32.Parse(class_a_output.Text) + Int32.Parse(class_b_output.Text) + Int32.Parse(class_c_output.Text);
                all_output.Text = all_output_calculated.ToString();
            }
            catch
            {
                MessageBox.Show("Input is wrong");
            }


        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            class_a_input.Text = "";
            class_a_output.Text = "";
            class_b_input.Text = "";
            class_b_output.Text = "";
            class_c_input.Text = "";
            class_c_output.Text = "";
            all_output.Text = "";
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
