using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class outputText : Form
    {

        public List<string> calculation = new List<string>();

        public outputText()
        {
            InitializeComponent();
        }

        bool lockOperations = false;

        int mather()
        {
            string[] operations = {"+", "-", "*", "/", "="};
            string[] numbers = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "."};

            string number1 = "";
            string number2 = "";
            
            string x = "";

            for (int i = 0; i < calculation.Count; i++)
            {
                x += calculation[i];
            }
            //label1.Text = x.Replace(" - ", "");
            label1.Text = x.IndexOf("-").ToString();

            // First Number
            for (int i = 0; i < calculation.Count; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (calculation[i] == numbers[j])
                    {
                        number1 += calculation[i];
                    }
                    else
                    {
                        break;
                    }
                }
            }

            // Second Number
            for (int i = 0; i < calculation.Count; i++)
            {
                for (int j = 0; j < operations.Length; j++)
                {
                    if (calculation[i] == operations[j])
                    {
                        break;
                    }
                    else
                    {
                        number2 += calculation[i];
                    }
                }
            }

            //label1.Text = number1 + ", " + number2;

            return 0;
        }

        private void update_textbox(string type, string value)
        {
            switch (type)
            {
                case "number":
                    calculation.Add(value);
                    textBox.Lines = calculation.ToArray();
                    break;

                case "operation":
                    if (!lockOperations)
                    {
                        calculation.Add(value);
                        textBox.Lines = calculation.ToArray();
                    }
                    
                    lockOperations = true;
                    break;

                case "point":
                    calculation.Add(value);
                    textBox.Lines = calculation.ToArray();
                    break;

                case "enter":
                    break;
            }
        }

        // Number Input Button onclick functions

        private void button0_Click(object sender, EventArgs e)
        {
            update_textbox("number", "0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            update_textbox("number", "1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            update_textbox("number", "2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            update_textbox("number", "3");
        }

        public void button4_Click(object sender, EventArgs e)
        {
            update_textbox("number", "4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            update_textbox("number", "5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            update_textbox("number", "6");
        }

        public void button7_Click(object sender, EventArgs e)
        {
            update_textbox("number", "7");
        }

        public void button8_Click(object sender, EventArgs e)
        {
            update_textbox("number", "8");
        }

        public void button9_Click(object sender, EventArgs e)
        {
            update_textbox("number", "9");
        }

        // Operator input buttons
        private void buttonDivision_Click(object sender, EventArgs e)
        {
            update_textbox("operation", " / ");
            lockOperations = true;
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            update_textbox("operation", " * ");
            lockOperations = true;
        }

        private void buttonSubtraction_Click(object sender, EventArgs e)
        {
            update_textbox("operation", " - ");
            lockOperations = true;
        }

        private void buttonAddition_Click(object sender, EventArgs e)
        {
            update_textbox("operation", " + ");
            lockOperations = true;
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            update_textbox("point", ".");
            lockOperations = true;
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            //update_textbox("enter", "=");
            mather();
        }

        // Textbox typing function
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
