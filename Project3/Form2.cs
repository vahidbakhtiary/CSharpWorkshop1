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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();


            //Array
            int a = 10;
            int b = 15;
            int c = 20;


            //define 1
            //int[] array = new int[3];
            //array[0] = 10;
            //array[1] = 15;
            //array[2] = 20;


            //define 2
            //int[] array = new int[] { 10 , 15 , 20};
            //string[] madrak =  { "Diplom", "BS", "MS", "PHD" };


            //define 2
            var array =new int[] { 10, 15, 20 };
            var array2 = new  [] { true, false, false };

            //Console.WriteLine(array[0]);
            //Console.WriteLine(array[1]);
            //Console.WriteLine(array[2]);


          // Console.WriteLine(array.Length);


            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("-------------");

            for (int i = array.Length - 1 ; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }

            //int i = 0;
            //foreach(var item in array)
            //{

            //    Console.WriteLine(item);
            //    i++;
            //}

        }
    }
}
