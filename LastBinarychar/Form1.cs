using System;
using System.Drawing;
using System.Windows.Forms;

namespace LastBinarychar
{
    public partial class Form1 : Form
    {
        private string[] binaryArray = { "01000001", "01000010", "01000011", "01000100" };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            char inputChar = InputTextBox.Text.ToUpper()[0];

            if (inputChar >= 'A' && inputChar <= 'D')
            {
                int index = inputChar - 'A';

                binaryArray[index] = null;
                UpdateArrayDisplay();
            }
            else
            {
                MessageBox.Show("Please enter a character between A to D.");
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

            if (inputChar >= 'A' && inputChar <= 'D')
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
                MessageBox.Show("Please enter a character between A to D.");
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
