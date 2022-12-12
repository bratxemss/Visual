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

namespace Individual_Assignment_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void inputButton_Click(object sender, EventArgs e)
        {
            try {
                int result = 1;
                for (int i = Convert.ToInt32(InputTextBox.Text); i > 0; i--)
                    result *= i;
                MessageBox.Show(Convert.ToString(result));

            }
            catch {
                MessageBox.Show("Input is empty");
            }
            
        }

        private void InputTextBox_TextChanged_1(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(InputTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Only numbers can be entered");
                InputTextBox.Text = InputTextBox.Text.Remove(InputTextBox.Text.Length - 1);
            }
        }
    }
}
