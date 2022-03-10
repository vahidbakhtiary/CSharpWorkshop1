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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void ChkDiplom_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("check change");
        }

        private void ChkPHD_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("check change");
        }



        private void BtnClick_Click(object sender, EventArgs e)
        {
            bool isCheckedDiplom = chkDiplom.Checked;
            bool isCheckedPHD = chkPHD.Checked;
            bool isCheckedMale = rdMale.Checked;
            bool isCheckedFemale = rdFemale.Checked;

            if (isCheckedDiplom)
            {
                MessageBox.Show("Diplom is checked");
            }

            if (isCheckedPHD)
            {
                MessageBox.Show("PHD is checked");
            }
            if (isCheckedMale)
            {
                MessageBox.Show("Male is checked");
            }
            if (isCheckedFemale)
            {
                MessageBox.Show("FeMale is checked");
            }
        }

        private void RdMale_CheckedChanged(object sender, EventArgs e)
        {

            bool isCheckedMale = rdMale.Checked;

            if (isCheckedMale)
            {
                MessageBox.Show("Male is checked");
            }

        }

        private void RdFemale_CheckedChanged(object sender, EventArgs e)
        {
            bool isCheckedFemale = rdFemale.Checked;
            if(isCheckedFemale)
            {
                MessageBox.Show("FeMale is checked");
            }
            
        }

        
    }
}
