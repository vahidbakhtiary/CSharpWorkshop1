﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{

   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


           

        }

        private void BtnSum_Click(object sender, EventArgs e)
        {
            int num1 = 5;
            int num2 = 10;
            int sum = num1 + num2;

            // Console.WriteLine(sum);
            MessageBox.Show(sum.ToString());
        }
    }
}
