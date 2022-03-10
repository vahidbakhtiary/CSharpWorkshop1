using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            /*if(condintion)
             * {
             * }
             * 
             * 
             * if(condintion)
             * {
             * }else
             * {
             * }
             * 
             * 
             * if(condintion)
             * {
             * } else if(condintion)
             * {
             * }else if(condintion)
             * {
             * }else
             * {
             * }
             */

            int number = 6;
            if (number % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("Odd");
            }


            // Loop
            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
