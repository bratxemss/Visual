using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace _7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            char mostFrequentCharacter = FindMostFrequentCharacter(input);

            MessageBox.Show("The most frequent character in the string is: " + mostFrequentCharacter);
        }
        private char FindMostFrequentCharacter(string input)
        {
            // Create a dictionary to keep track of how many times each character appears in the string
            Dictionary<char, int> charCounts = new Dictionary<char, int>();

            // Loop through each character in the input string
            foreach (char c in input)
            {
                // If the character is not in the dictionary, add it with a count of 1
                if (!charCounts.ContainsKey(c))
                {
                    charCounts.Add(c, 1);
                }
                else
                {
                    // If the character is already in the dictionary, increment its count by 1
                    charCounts[c]++;
                }
            }

            // Find the character with the highest count
            char mostFrequentCharacter = '\0'; // null character
            int maxCount = 0;
            foreach (KeyValuePair<char, int> kvp in charCounts)
            {
                if (kvp.Value > maxCount)
                {
                    mostFrequentCharacter = kvp.Key;
                    maxCount = kvp.Value;
                }
            }

            return mostFrequentCharacter;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
