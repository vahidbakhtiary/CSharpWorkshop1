using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            string lastResult = txtResult.Text;
            lastResult = lastResult + 1;
            txtResult.Text = lastResult;
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            string lastResult = txtResult.Text;
            lastResult = lastResult + 2;
            txtResult.Text = lastResult;
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            string lastResult = txtResult.Text;
            lastResult = lastResult + 3;
            txtResult.Text = lastResult;
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            string lastResult = txtResult.Text;
            lastResult = lastResult + "+";
            txtResult.Text = lastResult;
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            string lastResult = txtResult.Text;
            Console.WriteLine(lastResult);
        }
    }
}
