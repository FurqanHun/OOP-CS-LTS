using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L11_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void calculate_btn_Click(object sender, EventArgs e)
        {
            double Subtotal = double.Parse(subtotal_textbox.Text);
            double DiscountPercent;
            double DiscountAmount;
            double Total;

            if (Subtotal >= 500)
            {
                DiscountPercent = 0.2;
            }
            else if (Subtotal < 500 && Subtotal >= 250) {
                DiscountPercent = 0.15;
            }
            else if (Subtotal < 200 && Subtotal >= 100)
            {
                DiscountPercent = 0.1;
            }
            else
            {
                DiscountPercent = 0;
            }

            DiscountAmount = Subtotal * DiscountPercent;
            Total = Subtotal - DiscountAmount;

            discountpercent_textbox.Text = DiscountPercent.ToString();
            discount_textbox.Text = DiscountAmount.ToString();
            total_textbox.Text = Total.ToString();

            result_textbox .Text = Total.ToString();
        }
    }
}
