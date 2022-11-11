using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double first_number, second_number;
        string oper;
        public Form1()
        {
   
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Display.Text = "";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            double number = 2.71828183;
            Display.Text += Convert.ToString(number + Convert.ToDouble(Display.Text));
        }

        private void button25_Click(object sender, EventArgs e)
        {
            int result = 1;
            for (int i = Convert.ToInt32(Display.Text); i > 0; i--)
                result *= i;
            Display.Text = Convert.ToString(result);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(Display.Text);
            double Tan = Math.Tan(number);
            Display.Text = Convert.ToString(Tan);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(Display.Text);
            double Sin = Math.Sin(number);
            Display.Text = Convert.ToString(Sin);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            double pi = Math.PI;
            Display.Text = Convert.ToString(Convert.ToDouble(Display.Text) * pi);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(Display.Text);
            double Sqr = Math.Pow(number, 2);
            Display.Text += Convert.ToString(Sqr);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            double cos = Math.Cos(Convert.ToDouble(Display.Text));
            Display.Text = Convert.ToString(cos);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(Display.Text);
            Display.Text = Convert.ToString(Math.Pow(number, 2));
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Display.Text = Convert.ToString(Math.Abs(Convert.ToDouble(Display.Text)));
        }

        private void button33_Click(object sender, EventArgs e)
        {
            double Log = Math.Log(Convert.ToDouble(Display.Text));
            Display.Text = Convert.ToString(Log);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            // -------------------------------------------
        }

        private void button35_Click(object sender, EventArgs e)
        {
            double plus_min = Convert.ToDouble(Display.Text);
            Display.Text = Convert.ToString(-1 * plus_min);

        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (Display.Text.Contains("."))
            {
                Display.Text = Display.Text;
            }
            else {
                Display.Text += ".";
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0" || Display.Text == "")
            {
                Display.Text = Display.Text;
            } else
            {
                Display.Text += "0";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Display.Text += "1";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Display.Text += "4";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Display.Text += "7";
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            Display.Text += "2";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Display.Text += "5";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Display.Text += "8";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Display.Text += "3";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Display.Text += "6";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Display.Text += "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            second_number = double.Parse(Display.Text);
            switch(oper)
            {
                case "+":
                    Display.Text = (first_number + second_number).ToString();
                    break;
                case "-":
                    Display.Text = (first_number - second_number).ToString();
                    break;
                case "/":
                    Display.Text = (first_number / second_number).ToString();
                    break;
                case "*":
                    Display.Text = (first_number * second_number).ToString();
                    break;
                    
                default:
                    break;
            }

        }

        private void Display_TextChanged(object sender, EventArgs e)
        {

        }
        private void button11_Click(object sender, EventArgs e)
        {
            first_number = double.Parse(Display.Text);
            oper = "+";
            Display.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            first_number = double.Parse(Display.Text);
            oper = "-";
            Display.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            first_number = double.Parse(Display.Text);
            oper = "*";
            Display.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            first_number = double.Parse(Display.Text);
            oper = "/";
            Display.Text = "";
        }
    }
}
