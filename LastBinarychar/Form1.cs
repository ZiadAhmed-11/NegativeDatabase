using System;
using System.Drawing;
using System.Windows.Forms;

namespace LastBinarychar
{
    public partial class Form1 : Form
    {
        private string[] binaryArray;

        public Form1()
        {
            InitializeComponent();
            InitializeBinaryArray();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void InitializeBinaryArray()
        {
            binaryArray = new string[26]; 

            for (char c = 'A'; c <= 'Z'; c++)
            {
                int index = c - 'A';
                binaryArray[index] = ConvertCharToBinary(c);
            }
        }

        private string ConvertCharToBinary(char c)
        {
            return Convert.ToString(c, 2).PadLeft(8, '0');
        }

        
        private void ConvertButton_Click(object sender, EventArgs e)
        {
            char inputChar = InputTextBox.Text.ToUpper()[0];

            if (inputChar >= 'A' && inputChar <= 'z')
            {
                int index = inputChar - 'A';

                binaryArray[index] = null;
                UpdateArrayDisplay();
            }
            else
            {
                MessageBox.Show("Please enter a character between A to Z.");
            }
        }

        private void UpdateArrayDisplay()
        {
            BinaryOutputTextBox.Clear();

            foreach (string binary in binaryArray)
            {
                if (binary != null)
                {
                    BinaryOutputTextBox.AppendText(binary + Environment.NewLine);
                }
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            char inputChar = textBox1.Text.ToUpper()[0];

            if (inputChar >= 'A' && inputChar <= 'Z')
            {
                int index = inputChar - 'A';

                if (binaryArray[index] != null)
                {
                    richTextBox1.Text=($"Binary number for '{inputChar}' does not exists in the database.");
                }
                else
                {
                    richTextBox1.Text=($"Binary number for '{inputChar}' exist in the database.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a character between A to Z.");
            }
        }
        


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
