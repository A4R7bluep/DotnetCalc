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
        public outputText()
        {
            InitializeComponent();
        }

        string[] calculation = {};

        private void update_textbox()
        {
            string value = "";
            for (int i = 0; i < calculation.Length; i++)
            {
                value += (calculation[i]);
            }

            textBox.Text = value;
        }

        // Number Input Button onclick functions

        private void button0_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox.Text = "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox.Text = "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox.Text = "3";
        }

        public void button4_Click(object sender, EventArgs e)
        {
            textBox.Text = "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox.Text = "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox.Text = "6";
        }

        public void button7_Click(object sender, EventArgs e)
        {
            textBox.Text = "7";
        }

        public void button8_Click(object sender, EventArgs e)
        {
            textBox.Text = "8";
        }

        public void button9_Click(object sender, EventArgs e)
        {
            textBox.Text = "9";
        }

        // Operator input buttons
        private void buttonDivision_Click(object sender, EventArgs e)
        {
            textBox.Text = "/";
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            textBox.Text = "*";
        }

        private void buttonSubtraction_Click(object sender, EventArgs e)
        {
            textBox.Text = "-";
        }

        private void buttonAddition_Click(object sender, EventArgs e)
        {
            textBox.Text = "+";
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            textBox.Text = ".";
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            textBox.Text = "=";
        }

        // Textbox typing function
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
