﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POLE_plus_minus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);

            if (textBox3.Text == "+")
            {
                textBox4.Text = $"{num1 + num2}";
            }

            if (textBox3.Text == "-")
            {
                textBox4.Text = $"{num1 - num2}";
            }

            if (textBox3.Text == "*")
            {
                textBox4.Text = $"{num1 * num2}";
            }

            if (textBox3.Text == "/")
            {
                textBox4.Text = $"{num1 / num2}";
            }
        }
    }
}
