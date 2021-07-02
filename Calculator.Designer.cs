
namespace Legit22oOOP
{
    partial class Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FinalResult = new System.Windows.Forms.Button();
            this.OpDivide = new System.Windows.Forms.Button();
            this.OpMultiply = new System.Windows.Forms.Button();
            this.OpMinus = new System.Windows.Forms.Button();
            this.OpPlus = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Decimal = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.NegativeSign = new System.Windows.Forms.Button();
            this.Answer = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.FinalResult);
            this.groupBox1.Controls.Add(this.OpDivide);
            this.groupBox1.Controls.Add(this.OpMultiply);
            this.groupBox1.Controls.Add(this.OpMinus);
            this.groupBox1.Controls.Add(this.OpPlus);
            this.groupBox1.Controls.Add(this.Clear);
            this.groupBox1.Controls.Add(this.Nine);
            this.groupBox1.Controls.Add(this.Eight);
            this.groupBox1.Controls.Add(this.Seven);
            this.groupBox1.Controls.Add(this.Six);
            this.groupBox1.Controls.Add(this.Five);
            this.groupBox1.Controls.Add(this.Four);
            this.groupBox1.Controls.Add(this.Three);
            this.groupBox1.Controls.Add(this.Two);
            this.groupBox1.Controls.Add(this.One);
            this.groupBox1.Controls.Add(this.Decimal);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.NegativeSign);
            this.groupBox1.Controls.Add(this.Answer);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.Silver;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 539);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // FinalResult
            // 
            this.FinalResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.FinalResult.ForeColor = System.Drawing.Color.Black;
            this.FinalResult.Location = new System.Drawing.Point(309, 391);
            this.FinalResult.Name = "FinalResult";
            this.FinalResult.Size = new System.Drawing.Size(127, 73);
            this.FinalResult.TabIndex = 19;
            this.FinalResult.Text = "=";
            this.FinalResult.UseVisualStyleBackColor = false;
            this.FinalResult.Click += new System.EventHandler(this.FinalAnswerClick);
            // 
            // OpDivide
            // 
            this.OpDivide.BackColor = System.Drawing.Color.Salmon;
            this.OpDivide.ForeColor = System.Drawing.Color.Black;
            this.OpDivide.Location = new System.Drawing.Point(309, 312);
            this.OpDivide.Name = "OpDivide";
            this.OpDivide.Size = new System.Drawing.Size(127, 73);
            this.OpDivide.TabIndex = 18;
            this.OpDivide.Text = "/";
            this.OpDivide.UseVisualStyleBackColor = false;
            this.OpDivide.Click += new System.EventHandler(this.DivideClick);
            // 
            // OpMultiply
            // 
            this.OpMultiply.BackColor = System.Drawing.Color.Salmon;
            this.OpMultiply.ForeColor = System.Drawing.Color.Black;
            this.OpMultiply.Location = new System.Drawing.Point(309, 233);
            this.OpMultiply.Name = "OpMultiply";
            this.OpMultiply.Size = new System.Drawing.Size(127, 73);
            this.OpMultiply.TabIndex = 17;
            this.OpMultiply.Text = "×";
            this.OpMultiply.UseVisualStyleBackColor = false;
            this.OpMultiply.Click += new System.EventHandler(this.MultiplyClick);
            // 
            // OpMinus
            // 
            this.OpMinus.BackColor = System.Drawing.Color.Salmon;
            this.OpMinus.ForeColor = System.Drawing.Color.Black;
            this.OpMinus.Location = new System.Drawing.Point(379, 154);
            this.OpMinus.Name = "OpMinus";
            this.OpMinus.Size = new System.Drawing.Size(57, 73);
            this.OpMinus.TabIndex = 16;
            this.OpMinus.Text = "-";
            this.OpMinus.UseVisualStyleBackColor = false;
            this.OpMinus.Click += new System.EventHandler(this.MinusClick);
            // 
            // OpPlus
            // 
            this.OpPlus.BackColor = System.Drawing.Color.Salmon;
            this.OpPlus.ForeColor = System.Drawing.Color.Black;
            this.OpPlus.Location = new System.Drawing.Point(309, 154);
            this.OpPlus.Name = "OpPlus";
            this.OpPlus.Size = new System.Drawing.Size(64, 73);
            this.OpPlus.TabIndex = 15;
            this.OpPlus.Text = "+";
            this.OpPlus.UseVisualStyleBackColor = false;
            this.OpPlus.Click += new System.EventHandler(this.PlusClick);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.IndianRed;
            this.Clear.ForeColor = System.Drawing.Color.Black;
            this.Clear.Location = new System.Drawing.Point(18, 105);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(418, 43);
            this.Clear.TabIndex = 13;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.ClearClick);
            // 
            // Nine
            // 
            this.Nine.BackColor = System.Drawing.Color.Azure;
            this.Nine.ForeColor = System.Drawing.Color.Black;
            this.Nine.Location = new System.Drawing.Point(212, 154);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(91, 73);
            this.Nine.TabIndex = 12;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = false;
            this.Nine.Click += new System.EventHandler(this.NumClick);
            // 
            // Eight
            // 
            this.Eight.BackColor = System.Drawing.Color.Azure;
            this.Eight.ForeColor = System.Drawing.Color.Black;
            this.Eight.Location = new System.Drawing.Point(115, 154);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(91, 73);
            this.Eight.TabIndex = 11;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = false;
            this.Eight.Click += new System.EventHandler(this.NumClick);
            // 
            // Seven
            // 
            this.Seven.BackColor = System.Drawing.Color.Azure;
            this.Seven.ForeColor = System.Drawing.Color.Black;
            this.Seven.Location = new System.Drawing.Point(18, 154);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(91, 73);
            this.Seven.TabIndex = 10;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = false;
            this.Seven.Click += new System.EventHandler(this.NumClick);
            // 
            // Six
            // 
            this.Six.BackColor = System.Drawing.Color.Azure;
            this.Six.ForeColor = System.Drawing.Color.Black;
            this.Six.Location = new System.Drawing.Point(212, 233);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(91, 73);
            this.Six.TabIndex = 9;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = false;
            this.Six.Click += new System.EventHandler(this.NumClick);
            // 
            // Five
            // 
            this.Five.BackColor = System.Drawing.Color.Azure;
            this.Five.ForeColor = System.Drawing.Color.Black;
            this.Five.Location = new System.Drawing.Point(115, 233);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(91, 73);
            this.Five.TabIndex = 8;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = false;
            this.Five.Click += new System.EventHandler(this.NumClick);
            // 
            // Four
            // 
            this.Four.BackColor = System.Drawing.Color.Azure;
            this.Four.ForeColor = System.Drawing.Color.Black;
            this.Four.Location = new System.Drawing.Point(18, 233);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(91, 73);
            this.Four.TabIndex = 7;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = false;
            this.Four.Click += new System.EventHandler(this.NumClick);
            // 
            // Three
            // 
            this.Three.BackColor = System.Drawing.Color.Azure;
            this.Three.ForeColor = System.Drawing.Color.Black;
            this.Three.Location = new System.Drawing.Point(212, 312);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(91, 73);
            this.Three.TabIndex = 6;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = false;
            this.Three.Click += new System.EventHandler(this.NumClick);
            // 
            // Two
            // 
            this.Two.BackColor = System.Drawing.Color.Azure;
            this.Two.ForeColor = System.Drawing.Color.Black;
            this.Two.Location = new System.Drawing.Point(115, 312);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(91, 73);
            this.Two.TabIndex = 5;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = false;
            this.Two.Click += new System.EventHandler(this.NumClick);
            // 
            // One
            // 
            this.One.BackColor = System.Drawing.Color.Azure;
            this.One.ForeColor = System.Drawing.Color.Black;
            this.One.Location = new System.Drawing.Point(18, 312);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(91, 73);
            this.One.TabIndex = 4;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = false;
            this.One.Click += new System.EventHandler(this.NumClick);
            // 
            // Decimal
            // 
            this.Decimal.BackColor = System.Drawing.Color.Azure;
            this.Decimal.ForeColor = System.Drawing.Color.Black;
            this.Decimal.Location = new System.Drawing.Point(212, 391);
            this.Decimal.Name = "Decimal";
            this.Decimal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Decimal.Size = new System.Drawing.Size(91, 73);
            this.Decimal.TabIndex = 3;
            this.Decimal.Text = ".";
            this.Decimal.UseVisualStyleBackColor = false;
            this.Decimal.Click += new System.EventHandler(this.DecimalClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Azure;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(115, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 73);
            this.button2.TabIndex = 2;
            this.button2.Text = "0";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.NumClick);
            // 
            // NegativeSign
            // 
            this.NegativeSign.BackColor = System.Drawing.Color.Azure;
            this.NegativeSign.ForeColor = System.Drawing.Color.Black;
            this.NegativeSign.Location = new System.Drawing.Point(18, 391);
            this.NegativeSign.Name = "NegativeSign";
            this.NegativeSign.Size = new System.Drawing.Size(91, 73);
            this.NegativeSign.TabIndex = 1;
            this.NegativeSign.Text = "+/-";
            this.NegativeSign.UseVisualStyleBackColor = false;
            this.NegativeSign.Click += new System.EventHandler(this.NegativeSignClick);
            // 
            // Answer
            // 
            this.Answer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Answer.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Answer.Location = new System.Drawing.Point(18, 32);
            this.Answer.Name = "Answer";
            this.Answer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Answer.Size = new System.Drawing.Size(418, 61);
            this.Answer.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(461, 539);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "OOP Calculator v1.69";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button OpMultiply;
        private System.Windows.Forms.Button OpMinus;
        private System.Windows.Forms.Button OpPlus;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Decimal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button NegativeSign;
        private System.Windows.Forms.TextBox Answer;
        private System.Windows.Forms.Button FinalResult;
        private System.Windows.Forms.Button OpDivide;
    }
}

