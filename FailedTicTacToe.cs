using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class FailedTicTacToe : Form
    {
        public FailedTicTacToe()
        {
            InitializeComponent();
        }
        bool player;
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void UMButtonClick(object sender, EventArgs e)
        {
            if (player == false)
                UpperMiddle.Text = "X";
            if (player == true)
                UpperMiddle.Text = "O";
            UpperMiddle.Enabled = false;
            if (player == false)
                player = true;
            else
                player = false;
            bool wincondition = false;
            if (((TopLeft.Text == UpperMiddle.Text) && (UpperMiddle.Text == UpperRight.Text)) && UpperRight.Enabled == false)
                wincondition = true;
            if ((LeftMid.Text == Middle.Text) && (Middle.Text == MiddleRight.Text))
                wincondition = true;
            if (((BottomLeft.Text == LowerMiddle.Text) && (LowerMiddle.Text == BottomRight.Text)) && BottomRight.Enabled == false)
                wincondition = true;
            if (((TopLeft.Text == LeftMid.Text) && (LeftMid.Text == BottomLeft.Text)) && BottomLeft.Enabled == false)
                wincondition = true;
            if (((UpperMiddle.Text == Middle.Text) && (Middle.Text == LowerMiddle.Text)) && LowerMiddle.Enabled == false)
                wincondition = true;
            if (((UpperRight.Text == MiddleRight.Text) && (MiddleRight.Text == BottomRight.Text)) && BottomRight.Enabled == false)
                wincondition = true;
            if (((UpperRight.Text == Middle.Text) && (Middle.Text == BottomLeft.Text)) && BottomLeft.Enabled == false)
                wincondition = true;
            if (((TopLeft.Text == Middle.Text) && (Middle.Text == BottomRight.Text)) && TopLeft.Enabled == false)
                wincondition = true;
            if (wincondition == true)
                Congratulations.Text = "Congratulations!";
        }
        private void URButtonClick(object sender, EventArgs e)
        {
            if (player == false)
                UpperRight.Text = "X";
            else
                UpperRight.Text = "O";
            UpperRight.Enabled = false;
            if (player == false)
                player = true;
            else
                player = false;
            bool wincondition = false;
            if (((TopLeft.Text == UpperMiddle.Text) && (UpperMiddle.Text == UpperRight.Text)) && UpperRight.Enabled == false)
                wincondition = true;
            if ((LeftMid.Text == Middle.Text) && (Middle.Text == MiddleRight.Text))
                wincondition = true;
            if (((BottomLeft.Text == LowerMiddle.Text) && (LowerMiddle.Text == BottomRight.Text)) && BottomRight.Enabled == false)
                wincondition = true;
            if (((TopLeft.Text == LeftMid.Text) && (LeftMid.Text == BottomLeft.Text)) && BottomLeft.Enabled == false)
                wincondition = true;
            if (((UpperMiddle.Text == Middle.Text) && (Middle.Text == LowerMiddle.Text)) && LowerMiddle.Enabled == false)
                wincondition = true;
            if (((UpperRight.Text == MiddleRight.Text) && (MiddleRight.Text == BottomRight.Text)) && BottomRight.Enabled == false)
                wincondition = true;
            if (((UpperRight.Text == Middle.Text) && (Middle.Text == BottomLeft.Text)) && BottomLeft.Enabled == false)
                wincondition = true;
            if (((TopLeft.Text == Middle.Text) && (Middle.Text == BottomRight.Text)) && TopLeft.Enabled == false)
                wincondition = true;
            if (wincondition == true)
                Congratulations.Text = "Congratulations!";
        }
        private void MLButtonClick(object sender, EventArgs e)
        {
            if (player == false)
                LeftMid.Text = "X";
            else
                LeftMid.Text = "O";
            LeftMid.Enabled = false;
            if (player == false)
                player = true;
            else
                player = false;
            bool wincondition = false;
            if (((TopLeft.Text == UpperMiddle.Text) && (UpperMiddle.Text == UpperRight.Text)) && UpperRight.Enabled == false)
                wincondition = true;
            if ((LeftMid.Text == Middle.Text) && (Middle.Text == MiddleRight.Text))
                wincondition = true;
            if (((BottomLeft.Text == LowerMiddle.Text) && (LowerMiddle.Text == BottomRight.Text)) && BottomRight.Enabled == false)
                wincondition = true;
            if (((TopLeft.Text == LeftMid.Text) && (LeftMid.Text == BottomLeft.Text)) && BottomLeft.Enabled == false)
                wincondition = true;
            if (((UpperMiddle.Text == Middle.Text) && (Middle.Text == LowerMiddle.Text)) && LowerMiddle.Enabled == false)
                wincondition = true;
            if (((UpperRight.Text == MiddleRight.Text) && (MiddleRight.Text == BottomRight.Text)) && BottomRight.Enabled == false)
                wincondition = true;
            if (((UpperRight.Text == Middle.Text) && (Middle.Text == BottomLeft.Text)) && BottomLeft.Enabled == false)
                wincondition = true;
            if (((TopLeft.Text == Middle.Text) && (Middle.Text == BottomRight.Text)) && TopLeft.Enabled == false)
                wincondition = true;
            if (wincondition == true)
                Congratulations.Text = "Congratulations!";
        }
        private void MButtonClick(object sender, EventArgs e)
        {
            if (player == false)
                Middle.Text = "X";
            else
                Middle.Text = "O";
            Middle.Enabled = false;
            if (player == false)
                player = true;
            else
                player = false;
            bool wincondition = false;
            if (((TopLeft.Text == UpperMiddle.Text) && (UpperMiddle.Text == UpperRight.Text)) && UpperRight.Enabled == false)
                wincondition = true;
            if ((LeftMid.Text == Middle.Text) && (Middle.Text == MiddleRight.Text))
                wincondition = true;
            if (((BottomLeft.Text == LowerMiddle.Text) && (LowerMiddle.Text == BottomRight.Text)) && BottomRight.Enabled == false)
                wincondition = true;
            if (((TopLeft.Text == LeftMid.Text) && (LeftMid.Text == BottomLeft.Text)) && BottomLeft.Enabled == false)
                wincondition = true;
            if (((UpperMiddle.Text == Middle.Text) && (Middle.Text == LowerMiddle.Text)) && LowerMiddle.Enabled == false)
                wincondition = true;
            if (((UpperRight.Text == MiddleRight.Text) && (MiddleRight.Text == BottomRight.Text)) && BottomRight.Enabled == false)
                wincondition = true;
            if (((UpperRight.Text == Middle.Text) && (Middle.Text == BottomLeft.Text)) && BottomLeft.Enabled == false)
                wincondition = true;
            if (((TopLeft.Text == Middle.Text) && (Middle.Text == BottomRight.Text)) && TopLeft.Enabled == false)
                wincondition = true;
            if (wincondition == true)
                Congratulations.Text = "Congratulations!";
        }
        private void MRButtonClick(object sender, EventArgs e)
        {
            if (player == false)
                MiddleRight.Text = "X";
            else
                MiddleRight.Text = "O";
            MiddleRight.Enabled = false;
            if (player == false)
                player = true;
            else
                player = false;
            bool wincondition = false;
            if (((TopLeft.Text == UpperMiddle.Text) && (UpperMiddle.Text == UpperRight.Text)) && UpperRight.Enabled == false)
                wincondition = true;
            if ((LeftMid.Text == Middle.Text) && (Middle.Text == MiddleRight.Text))
                wincondition = true;
            if (((BottomLeft.Text == LowerMiddle.Text) && (LowerMiddle.Text == BottomRight.Text)) && BottomRight.Enabled == false)
                wincondition = true;
            if (((TopLeft.Text == LeftMid.Text) && (LeftMid.Text == BottomLeft.Text)) && BottomLeft.Enabled == false)
                wincondition = true;
            if (((UpperMiddle.Text == Middle.Text) && (Middle.Text == LowerMiddle.Text)) && LowerMiddle.Enabled == false)
                wincondition = true;
            if (((UpperRight.Text == MiddleRight.Text) && (MiddleRight.Text == BottomRight.Text)) && BottomRight.Enabled == false)
                wincondition = true;
            if (((UpperRight.Text == Middle.Text) && (Middle.Text == BottomLeft.Text)) && BottomLeft.Enabled == false)
                wincondition = true;
            if (((TopLeft.Text == Middle.Text) && (Middle.Text == BottomRight.Text)) && TopLeft.Enabled == false)
                wincondition = true;
            if (wincondition == true)
                Congratulations.Text = "Congratulations!";
        }
        private void BLButtonClick(object sender, EventArgs e)
        {
            if (player == false)
                BottomLeft.Text = "X";
            else
                BottomLeft.Text = "O";
            BottomLeft.Enabled = false;
            if (player == false)
                player = true;
            else
                player = false;
            bool wincondition = false;
            if (((TopLeft.Text == UpperMiddle.Text) && (UpperMiddle.Text == UpperRight.Text)) && UpperRight.Enabled == false)
                wincondition = true;
            if ((LeftMid.Text == Middle.Text) && (Middle.Text == MiddleRight.Text))
                wincondition = true;
            if (((BottomLeft.Text == LowerMiddle.Text) && (LowerMiddle.Text == BottomRight.Text)) && BottomRight.Enabled == false)
                wincondition = true;
            if (((TopLeft.Text == LeftMid.Text) && (LeftMid.Text == BottomLeft.Text)) && BottomLeft.Enabled == false)
                wincondition = true;
            if (((UpperMiddle.Text == Middle.Text) && (Middle.Text == LowerMiddle.Text)) && LowerMiddle.Enabled == false)
                wincondition = true;
            if (((UpperRight.Text == MiddleRight.Text) && (MiddleRight.Text == BottomRight.Text)) && BottomRight.Enabled == false)
                wincondition = true;
            if (((UpperRight.Text == Middle.Text) && (Middle.Text == BottomLeft.Text)) && BottomLeft.Enabled == false)
                wincondition = true;
            if (((TopLeft.Text == Middle.Text) && (Middle.Text == BottomRight.Text)) && TopLeft.Enabled == false)
                wincondition = true;
            if (wincondition == true)
                Congratulations.Text = "Congratulations!";
        }
        private void LMButtonClick(object sender, EventArgs e)
        {
            if (player == false)
                LowerMiddle.Text = "X";
            else
                LowerMiddle.Text = "O";
            LowerMiddle.Enabled = false;
            if (player == false)
                player = true;
            else
                player = false;
            bool wincondition = false;
            if (((TopLeft.Text == UpperMiddle.Text) && (UpperMiddle.Text == UpperRight.Text)) && UpperRight.Enabled == false)
                wincondition = true;
            if ((LeftMid.Text == Middle.Text) && (Middle.Text == MiddleRight.Text))
                wincondition = true;
            if (((BottomLeft.Text == LowerMiddle.Text) && (LowerMiddle.Text == BottomRight.Text)) && BottomRight.Enabled == false)
                wincondition = true;
            if (((TopLeft.Text == LeftMid.Text) && (LeftMid.Text == BottomLeft.Text)) && BottomLeft.Enabled == false)
                wincondition = true;
            if (((UpperMiddle.Text == Middle.Text) && (Middle.Text == LowerMiddle.Text)) && LowerMiddle.Enabled == false)
                wincondition = true;
            if (((UpperRight.Text == MiddleRight.Text) && (MiddleRight.Text == BottomRight.Text)) && BottomRight.Enabled == false)
                wincondition = true;
            if (((UpperRight.Text == Middle.Text) && (Middle.Text == BottomLeft.Text)) && BottomLeft.Enabled == false)
                wincondition = true;
            if (((TopLeft.Text == Middle.Text) && (Middle.Text == BottomRight.Text)) && TopLeft.Enabled == false)
                wincondition = true;
            if (wincondition == true)
                Congratulations.Text = "Congratulations!";
        }
        private void BRButtonClick(object sender, EventArgs e)
        {
            if (player == false)
                BottomRight.Text = "X";
            else
                BottomRight.Text = "O";
            BottomRight.Enabled = false;
            if (player == false)
                player = true;
            else
                player = false;
            bool wincondition = false;
            if (((TopLeft.Text == UpperMiddle.Text) && (UpperMiddle.Text == UpperRight.Text)) && UpperRight.Enabled == false)
                wincondition = true;
            if ((LeftMid.Text == Middle.Text) && (Middle.Text == MiddleRight.Text))
                wincondition = true;
            if (((BottomLeft.Text == LowerMiddle.Text) && (LowerMiddle.Text == BottomRight.Text)) && BottomRight.Enabled == false)
                wincondition = true;
            if (((TopLeft.Text == LeftMid.Text) && (LeftMid.Text == BottomLeft.Text)) && BottomLeft.Enabled == false)
                wincondition = true;
            if (((UpperMiddle.Text == Middle.Text) && (Middle.Text == LowerMiddle.Text)) && LowerMiddle.Enabled == false)
                wincondition = true;
            if (((UpperRight.Text == MiddleRight.Text) && (MiddleRight.Text == BottomRight.Text)) && BottomRight.Enabled == false)
                wincondition = true;
            if (((UpperRight.Text == Middle.Text) && (Middle.Text == BottomLeft.Text)) && BottomLeft.Enabled == false)
                wincondition = true;
            if (((TopLeft.Text == Middle.Text) && (Middle.Text == BottomRight.Text)) && TopLeft.Enabled == false)
                wincondition = true;
            if (wincondition == true)
                Congratulations.Text = "Congratulations!";
        }
        private void ULButtonClick(object sender, EventArgs e)
        {
            if (player == false)
                TopLeft.Text = "X";
            else
                TopLeft.Text = "O";
            TopLeft.Enabled = false;
            if (player == false)
                player = true;
            else
                player = false;
            bool wincondition = false;
            if (((TopLeft.Text == UpperMiddle.Text) && (UpperMiddle.Text == UpperRight.Text))&& UpperRight.Enabled == false)
                wincondition = true;
            if ((LeftMid.Text == Middle.Text) && (Middle.Text == MiddleRight.Text))
                wincondition = true;
            if (((BottomLeft.Text == LowerMiddle.Text) && (LowerMiddle.Text == BottomRight.Text)) && BottomRight.Enabled == false)
                wincondition = true;
            if (((TopLeft.Text == LeftMid.Text) && (LeftMid.Text == BottomLeft.Text)) && BottomLeft.Enabled == false)
                wincondition = true;
            if (((UpperMiddle.Text == Middle.Text) && (Middle.Text == LowerMiddle.Text)) && LowerMiddle.Enabled == false)
                wincondition = true;
            if (((UpperRight.Text == MiddleRight.Text) && (MiddleRight.Text == BottomRight.Text)) && BottomRight.Enabled == false)
                wincondition = true;
            if (((UpperRight.Text == Middle.Text) && (Middle.Text == BottomLeft.Text)) && BottomLeft.Enabled == false)
                wincondition = true;
            if (((TopLeft.Text == Middle.Text) && (Middle.Text == BottomRight.Text)) && TopLeft.Enabled == false)
                wincondition = true;
            if (wincondition == true)
                Congratulations.Text = "Congratulations!";
        }
    }
}
