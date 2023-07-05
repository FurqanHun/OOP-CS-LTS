using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L11_1
{
    public partial class Form1 : Form
    {
        public double a;
        public double b;
        public double c;
        public Form1()
        {
            InitializeComponent();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (int1_txtbox.Text == "")
            {
                a = 0;
            }
            else if (int2_txtbox.Text == "")
            {
                b = 0;
            }
            else
            {
                a = double.Parse(int1_txtbox.Text);
                b = double.Parse(int2_txtbox.Text);
            }
            c = a + b;
            result_textbox.Text = c.ToString();
        }

        private void subtract_btn_Click(object sender, EventArgs e)
        {
            if (int1_txtbox.Text == "")
            {
                a = 0;
            }
            else if (int2_txtbox.Text == "")
            {
                b = 0;
            }
            else
            {
                a = double.Parse(int1_txtbox.Text);
                b = double.Parse(int2_txtbox.Text);
            }
            c = a - b;
            result_textbox.Text = c.ToString();
        }

        private void multiply_btn_Click(object sender, EventArgs e)
        {
            if (int1_txtbox.Text == "")
            {
                a = 0;
            }
            else if (int2_txtbox.Text == "")
            {
                b = 0;
            }
            else
            {
                a = double.Parse(int1_txtbox.Text);
                b = double.Parse(int2_txtbox.Text);
            }
            c = a * b;
            result_textbox.Text = c.ToString();
        }

        private void divide_btn_Click(object sender, EventArgs e)
        {
            if (int1_txtbox.Text == "")
            {
                a = 0;
            }
            else if (int2_txtbox.Text == "")
            {
                b = 0;
            }
            else
            {
                a = double.Parse(int1_txtbox.Text);
                b = double.Parse(int2_txtbox.Text);
            }

            if (a == 0 && b == 0)
            {
                result_textbox.Text = "Undefined";
            }
            else
            {
                c = a / b;
                result_textbox.Text = c.ToString();
            }
        }

        private void off_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clr_btn_Click(object sender, EventArgs e)
        {
            int1_txtbox.Text = "";
            int2_txtbox.Text = "";
            result_textbox.Text = "";

            a = 0; b = 0; c = 0;
        }
    }
}
