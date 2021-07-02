using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legit22oOOP
{
    public partial class Calculator : Form
        
    {
        string operation = "";
        string Answer1 = "";
        bool DecimalClicked = false;
        bool OperationClicked = false; 
        public Calculator()
        {
            InitializeComponent();
        }
        private void NumClick(object sender, EventArgs e)
        {
            Button AllNum = (Button)sender;
            Answer.Text = Answer.Text + AllNum.Text;
            if (Answer.Text == "0")
                Answer.Clear();
        }
        private void NegativeSignClick(object sender, EventArgs e)
        {
            Button NegativeSign = (Button)sender;
            Answer.Text = "-" + Answer.Text;
            operation = "--";
            bool NegativeSignClicked = true;
            if (NegativeSignClicked = true)
                NegativeSign.Enabled = false;
        }
        private void DecimalClick(object sender, EventArgs e)
        {
            Answer.Text = Answer.Text + ".";
            operation = "..";
            DecimalClicked = true;
            if (Answer.Text == "0")
                Answer.Clear();
            if (DecimalClicked = true)
                Decimal.Enabled = false;
        }
        private void ClearClick(object sender, EventArgs e)
        {
            Answer.Clear();
            Decimal.Enabled = true;
            NegativeSign.Enabled = true;
        }
        private void FinalAnswerClick(object sender, EventArgs e)
        {
            if (operation == "+")
                Answer.Text = (float.Parse(Answer.Text) + float.Parse(Answer1)).ToString();
            if (operation == "-")
                Answer.Text = (float.Parse(Answer1) - float.Parse(Answer.Text)).ToString();
            if (operation == "*")
                Answer.Text = (float.Parse(Answer.Text) * float.Parse(Answer1)).ToString();
            if (operation == "/")
                Answer.Text = (float.Parse(Answer1) / float.Parse(Answer.Text)).ToString();
            Decimal.Enabled = true;
            NegativeSign.Enabled = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void PlusClick(object sender, EventArgs e)
        {
            operation = "+";
            bool OperationClicked = true;
            if (OperationClicked = true)
                Answer1 = Answer.Text;
            Answer.Clear();
            Decimal.Enabled = true;
            NegativeSign.Enabled = true;
        }
        private void MinusClick(object sender, EventArgs e)
        {
            operation = "-";
            bool OperationClicked = true;
            if (OperationClicked = true)
                Answer1 = Answer.Text;
            Answer.Clear();
            Decimal.Enabled = true;
            NegativeSign.Enabled = true;
        }
        private void MultiplyClick(object sender, EventArgs e)
        {
            operation = "*";
            bool OperationClicked = true;
            if (OperationClicked = true)
                Answer1 = Answer.Text;
            Answer.Clear();
            Decimal.Enabled = true;
            NegativeSign.Enabled = true;
        }
        private void DivideClick(object sender, EventArgs e)
        {
            operation = "/";
            bool OperationClicked = true;
            if (OperationClicked = true)
                Answer1 = Answer.Text;
            Answer.Clear();
            Decimal.Enabled = true;
            NegativeSign.Enabled = true;
            
        }
    }
}
