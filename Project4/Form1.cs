﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            //Convert

            //int varInt = 10;
            //string varStr = varInt.ToString();

            //long varLong = 12;
            //string varStr = varLong.ToString();


            string varStr = "10";
            int varInt =int.Parse(varStr) ;
            long varLong = long.Parse(varStr);
            float varFloat = float.Parse(varStr);


        }
    }
}
