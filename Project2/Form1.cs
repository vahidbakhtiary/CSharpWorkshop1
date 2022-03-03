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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Implicit
            // int varInt = 10;
            // long varLong = varInt;

            //Explicit
            long varLong = 10;
            int varInt =(int) varLong;


            //String Common Function


            //Replace
            string str = "this is a test for a test";
            string newStr = str.Replace("test", "sample");

            Console.WriteLine(str);
            Console.WriteLine(newStr);


            //Change case
            string s = "aLi REza";
            //string newS=  s.ToLower();
            string newS = s.ToUpper();

            Console.WriteLine(s);
            Console.WriteLine(newS);


            //Check Empty or Null
            string text1 = "";  //empty
            string text2 = " "; //fill(space)
            string text3 = "ali";// fill(character)
            string text4 = null; //null
            string text5 = "      ";

            Console.WriteLine(String.IsNullOrEmpty(text1));
            Console.WriteLine(String.IsNullOrEmpty(text2));
            Console.WriteLine(String.IsNullOrEmpty(text3));
            Console.WriteLine(String.IsNullOrEmpty(text4));
            Console.WriteLine(String.IsNullOrEmpty(text5));

            Console.WriteLine(String.IsNullOrWhiteSpace(text2));
            Console.WriteLine(String.IsNullOrWhiteSpace(text5));


            //Substring
            string text6 = "my name is vahid";
            int length = text6.Length;
            Console.WriteLine(length);

           string newText = text6.Substring(3, 7);
            Console.WriteLine(newText);


            //Remove Space
            string text7 = " ali     ";
            if(text7.Trim().Equals("ali"))
            {
                Console.WriteLine("true");
            }else
            {
                Console.WriteLine("false");
            }

        }
    }
}
