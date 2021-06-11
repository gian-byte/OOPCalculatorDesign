using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstProgram
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        double fordecimal = 0;
        string operation = "";
        bool DecimalClickedAlready;
        bool NegativeSignClickedAlready;
        bool operationclickedalready;
        bool multiplyop;
        double answer;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OneClick(object sender, EventArgs e)
        {
            Output.Text = Output.Text + "1";
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            operation = "*";
            operationclickedalready = true;
            if (operationclickedalready == true)
                Output.Clear();
            if (operationclickedalready == true)
                input = Output.Text;
            multiplyop = true;


        }

        private void Minus_Click(object sender, EventArgs e)
        {
            operation = "-";
            operationclickedalready = true;
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            operation = "+";
            operationclickedalready = true;
            
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            if (multiplyop == true)
                operation = "*";
            answer = Convert.ToDouble(Output.Text) * Convert.ToDouble(input);

        }

        private void Divide_Click(object sender, EventArgs e)
        {
            operation = "/";
            operationclickedalready = true;
        }

        private void ClearOneNumber_Click(object sender, EventArgs e)
        {
            Output.Text = "0";
        }

        private void ClearEverything_Click(object sender, EventArgs e)
        {
            
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            if (Output.Text == "0") 
                Output.Clear();
            Output.Text = Output.Text + "7";
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            if (Output.Text == "0")
                Output.Clear();
            Output.Text = Output.Text + "8";
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            if (Output.Text == "0")
                Output.Clear();
            Output.Text = Output.Text + "9";
        }

        private void Four_Click(object sender, EventArgs e)
        {
            if (Output.Text == "0")
                Output.Clear();
            Output.Text = Output.Text + "4";
        }

        private void Five_Click(object sender, EventArgs e)
        {
            if (Output.Text == "0")
                Output.Clear();
            Output.Text = Output.Text + "5";
        }

        private void Six_Click(object sender, EventArgs e)
        {
            if (Output.Text == "0")
                Output.Clear();
            Output.Text = Output.Text + "6";
        }

        private void Two_Click(object sender, EventArgs e)
        {
            if (Output.Text == "0")
                Output.Clear();
            Output.Text = Output.Text + "2";
        }

        private void Three_Click(object sender, EventArgs e)
        {
            if (Output.Text == "0")
                Output.Clear();
            Output.Text = Output.Text + "3";
        }

        private void NegativeSign_Click(object sender, EventArgs e)
        {
            Output.Text = '-' + Output.Text;
            NegativeSignClickedAlready = true;
            if(NegativeSignClickedAlready == true)
                NegativeSign.Enabled = false;
            if (operationclickedalready == true)
                NegativeSign.Enabled = true;

        }

        private void Zero_Click(object sender, EventArgs e)
        {
            Output.Text = Output.Text + "0";
        }

        private void Decimal_Click(object sender, EventArgs e)
        {
            Output.Text = Output.Text + ".";
            DecimalClickedAlready = true;
            if (DecimalClickedAlready == true)
                Decimal.Enabled = false;
                
        }

        private void PercentForm_Click(object sender, EventArgs e)
        {
            
        }

        private void Output_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
