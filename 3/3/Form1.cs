using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Individual_Assignment_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string GetBmiMessage(double bmi)
        {
            if (bmi < 18.1) {
                return "Underweight";
            } else if (bmi < 25)
            {
                return "Normal weight";
            } else if (bmi < 30)
            {
                return "Overweight";
            } else {
                return "Obesity";
            }
}

        private void calculate_btn_Click(object sender, EventArgs e)
        {
            try
            {

                double weight_input_int = Convert.ToDouble(weight_input.Text);
                double height_input_int = Convert.ToDouble(height_input.Text);



                double bmi_output = weight_input_int / Math.Pow(height_input_int,2);
                bmi_count_lbl.Text = "BMI: " + bmi_output.ToString();
                bmi_status_lbl.Text="Status: " + GetBmiMessage(bmi_output);
            }
            catch
            {
                MessageBox.Show("Input is wrong");
            }
        }
    }
}
