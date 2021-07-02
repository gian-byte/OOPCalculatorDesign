using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPCalculatorREVISED
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bool NegativeSignClicked = false;
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button AllNumbers = (Button)sender;
            Answer.Text = Answer.Text + AllNumbers.Text;
            if (Answer.Text == "0")
                Answer.Clear();

        }

        private void NegativeSignClick(object sender, EventArgs e)
        {
            Button NegativeSign = (Button)sender;
            Answer.Text = "-" + Answer.Text;
            bool NegativeSignClicked = true;
            if (NegativeSignClicked = true)
                NegativeSign.Enabled = false;


            
                
            


        }

        private void PlusClick(object sender, EventArgs e)
        {

        }

        private void MinusClick(object sender, EventArgs e)
        {

        }

        private void MultiplyClick(object sender, EventArgs e)
        {

        }

        private void EqualsClick(object sender, EventArgs e)
        {

        }
    }
}
