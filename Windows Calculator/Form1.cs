using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Calculator
{
    public partial class Form1 : Form
    {

        //Captures the arithmetic operator which was pressed.
        Double value = 0;
        String operation = "";
        bool operation_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        //This code creates generic event handler for non operator buttons.
        //And clears textbox when  0 is present || operator is clicked.
        {
            if ((result.Text == "0")||(operation_pressed))
                result.Clear();
            operation_pressed = false;
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }

        private void button14_Click(object sender, EventArgs e)
            //CE button handler resets textbox to 0.
        {
            result.Text = "0";
        }

        private void operator_Click(object sender, EventArgs e)
            //When operator is clicked first line captures value.
            //Second line stores operator in variable.
            //Third line parses and stores value in text box.
            //Fourth line clears text when operator is pressed by reference to line (32).
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(result.Text);
            operation_pressed = true;
            equation.Text = value + " " + operation;
        }

        private void button17_Click(object sender, EventArgs e)
            //This code gives functionality to the operators parsed to text, initiated after click event on = button.
        {
            switch (operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            }

        }

        private void button13_Click(object sender, EventArgs e)
            //C button clears textbox and initialises value to 0.
        {
            result.Text = "0";
            value = 0;

        }
    }
}
