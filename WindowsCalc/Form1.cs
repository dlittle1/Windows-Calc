using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsCalc
{
    public partial class Form1 : Form
    {
        double value = 0;
        string operation = "";
        bool pressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0")||(pressed))
            {
                result.Clear();
            }

            Button b = (Button)sender;
            result.Text += b.Text;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;

            value = Double.Parse(result.Text);
            pressed = true;
            equation.Text = value + " " + operation;
        }

        private void sum(object sender, EventArgs e)
        {
            switch(operation)
            {
                case "+":
                    result.Text = (value + double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;

            } // end switch
            
            equation.Text = "";
        }

        private void clear(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
            operation = "";
            equation.Text = "";
        }
    }
}
