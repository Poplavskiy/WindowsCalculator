using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsCalculator
{
    public partial class Form1 : Form
    {
        double someValue = 0;
        string operation = "";
        bool operationPressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0")||(operationPressed))
            {
                textBox1.Clear();
            }
            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + b.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            
            operation = b.Text;
            someValue = double.Parse(textBox1.Text);
            operationPressed = true;

        }

        private void button18_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBox1.Text = Convert.ToString(someValue + double.Parse(textBox1.Text));
                    break;
                case "-":
                    textBox1.Text = Convert.ToString(someValue - double.Parse(textBox1.Text));
                    break;
                case "*":
                    textBox1.Text = Convert.ToString(someValue * double.Parse(textBox1.Text));
                    break;
                case "/":
                    textBox1.Text = Convert.ToString(someValue / double.Parse(textBox1.Text));
                    break;

                default:
                    break;
            }
            operationPressed = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            someValue = 0;
        }
    }
}
