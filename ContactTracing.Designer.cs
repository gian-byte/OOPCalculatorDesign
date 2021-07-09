
namespace Contact_Tracing_Form
{
    partial class ContactTracing
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
            this.grpbox = new System.Windows.Forms.GroupBox();
            this.Submitbtn = new System.Windows.Forms.Button();
            this.Contactnumtextbox = new System.Windows.Forms.TextBox();
            this.contactnumlabel = new System.Windows.Forms.Label();
            this.Addresstxtbox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.IfOtherstxtbox = new System.Windows.Forms.TextBox();
            this.Otherscheckbox = new System.Windows.Forms.CheckBox();
            this.iffemalecheckbox = new System.Windows.Forms.CheckBox();
            this.ifmalecheckbox = new System.Windows.Forms.CheckBox();
            this.Genderlabel = new System.Windows.Forms.Label();
            this.Agetxtbox = new System.Windows.Forms.TextBox();
            this.Agelabel = new System.Windows.Forms.Label();
            this.Surnamelabel = new System.Windows.Forms.Label();
            this.firstnamelabel = new System.Windows.Forms.Label();
            this.Surnametxtbox = new System.Windows.Forms.TextBox();
            this.Firstnametxtbox = new System.Windows.Forms.TextBox();
            this.textlabel1 = new System.Windows.Forms.Label();
            this.grpbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbox
            // 
            this.grpbox.BackColor = System.Drawing.Color.OldLace;
            this.grpbox.Controls.Add(this.Submitbtn);
            this.grpbox.Controls.Add(this.Contactnumtextbox);
            this.grpbox.Controls.Add(this.contactnumlabel);
            this.grpbox.Controls.Add(this.Addresstxtbox);
            this.grpbox.Controls.Add(this.AddressLabel);
            this.grpbox.Controls.Add(this.IfOtherstxtbox);
            this.grpbox.Controls.Add(this.Otherscheckbox);
            this.grpbox.Controls.Add(this.iffemalecheckbox);
            this.grpbox.Controls.Add(this.ifmalecheckbox);
            this.grpbox.Controls.Add(this.Genderlabel);
            this.grpbox.Controls.Add(this.Agetxtbox);
            this.grpbox.Controls.Add(this.Agelabel);
            this.grpbox.Controls.Add(this.Surnamelabel);
            this.grpbox.Controls.Add(this.firstnamelabel);
            this.grpbox.Controls.Add(this.Surnametxtbox);
            this.grpbox.Controls.Add(this.Firstnametxtbox);
            this.grpbox.Controls.Add(this.textlabel1);
            this.grpbox.Location = new System.Drawing.Point(3, -18);
            this.grpbox.Name = "grpbox";
            this.grpbox.Size = new System.Drawing.Size(497, 452);
            this.grpbox.TabIndex = 0;
            this.grpbox.TabStop = false;
            // 
            // Submitbtn
            // 
            this.Submitbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.Submitbtn.Location = new System.Drawing.Point(19, 357);
            this.Submitbtn.Name = "Submitbtn";
            this.Submitbtn.Size = new System.Drawing.Size(371, 37);
            this.Submitbtn.TabIndex = 16;
            this.Submitbtn.Text = "Submit";
            this.Submitbtn.UseVisualStyleBackColor = false;
            this.Submitbtn.Click += new System.EventHandler(this.Submitbtn_Click);
            // 
            // Contactnumtextbox
            // 
            this.Contactnumtextbox.Location = new System.Drawing.Point(26, 317);
            this.Contactnumtextbox.Name = "Contactnumtextbox";
            this.Contactnumtextbox.Size = new System.Drawing.Size(183, 23);
            this.Contactnumtextbox.TabIndex = 15;
            // 
            // contactnumlabel
            // 
            this.contactnumlabel.AutoSize = true;
            this.contactnumlabel.Location = new System.Drawing.Point(22, 290);
            this.contactnumlabel.Name = "contactnumlabel";
            this.contactnumlabel.Size = new System.Drawing.Size(96, 15);
            this.contactnumlabel.TabIndex = 14;
            this.contactnumlabel.Text = "Contact Number";
            // 
            // Addresstxtbox
            // 
            this.Addresstxtbox.Location = new System.Drawing.Point(128, 146);
            this.Addresstxtbox.Name = "Addresstxtbox";
            this.Addresstxtbox.Size = new System.Drawing.Size(317, 23);
            this.Addresstxtbox.TabIndex = 13;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(128, 128);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(49, 15);
            this.AddressLabel.TabIndex = 12;
            this.AddressLabel.Text = "Address";
            // 
            // IfOtherstxtbox
            // 
            this.IfOtherstxtbox.Location = new System.Drawing.Point(198, 248);
            this.IfOtherstxtbox.Name = "IfOtherstxtbox";
            this.IfOtherstxtbox.Size = new System.Drawing.Size(148, 23);
            this.IfOtherstxtbox.TabIndex = 11;
            // 
            // Otherscheckbox
            // 
            this.Otherscheckbox.AutoSize = true;
            this.Otherscheckbox.BackColor = System.Drawing.Color.Thistle;
            this.Otherscheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Otherscheckbox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Otherscheckbox.Location = new System.Drawing.Point(29, 248);
            this.Otherscheckbox.Name = "Otherscheckbox";
            this.Otherscheckbox.Size = new System.Drawing.Size(163, 23);
            this.Otherscheckbox.TabIndex = 10;
            this.Otherscheckbox.Text = "Others (Please Specify)";
            this.Otherscheckbox.UseVisualStyleBackColor = false;
            this.Otherscheckbox.CheckedChanged += new System.EventHandler(this.Otherscheckbox_CheckedChanged);
            // 
            // iffemalecheckbox
            // 
            this.iffemalecheckbox.AutoSize = true;
            this.iffemalecheckbox.BackColor = System.Drawing.Color.HotPink;
            this.iffemalecheckbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iffemalecheckbox.Location = new System.Drawing.Point(98, 217);
            this.iffemalecheckbox.Name = "iffemalecheckbox";
            this.iffemalecheckbox.Size = new System.Drawing.Size(79, 25);
            this.iffemalecheckbox.TabIndex = 9;
            this.iffemalecheckbox.Text = "Female";
            this.iffemalecheckbox.UseVisualStyleBackColor = false;
            this.iffemalecheckbox.CheckedChanged += new System.EventHandler(this.iffemalecheckbox_CheckedChanged);
            // 
            // ifmalecheckbox
            // 
            this.ifmalecheckbox.AutoSize = true;
            this.ifmalecheckbox.BackColor = System.Drawing.Color.SkyBlue;
            this.ifmalecheckbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ifmalecheckbox.Location = new System.Drawing.Point(29, 217);
            this.ifmalecheckbox.Name = "ifmalecheckbox";
            this.ifmalecheckbox.Size = new System.Drawing.Size(63, 25);
            this.ifmalecheckbox.TabIndex = 8;
            this.ifmalecheckbox.Text = "Male";
            this.ifmalecheckbox.UseVisualStyleBackColor = false;
            this.ifmalecheckbox.CheckedChanged += new System.EventHandler(this.ifmalecheckbox_CheckedChanged);
            // 
            // Genderlabel
            // 
            this.Genderlabel.AutoSize = true;
            this.Genderlabel.Location = new System.Drawing.Point(22, 199);
            this.Genderlabel.Name = "Genderlabel";
            this.Genderlabel.Size = new System.Drawing.Size(45, 15);
            this.Genderlabel.TabIndex = 7;
            this.Genderlabel.Text = "Gender";
            // 
            // Agetxtbox
            // 
            this.Agetxtbox.Location = new System.Drawing.Point(22, 146);
            this.Agetxtbox.Name = "Agetxtbox";
            this.Agetxtbox.Size = new System.Drawing.Size(45, 23);
            this.Agetxtbox.TabIndex = 6;
            // 
            // Agelabel
            // 
            this.Agelabel.AutoSize = true;
            this.Agelabel.Location = new System.Drawing.Point(22, 128);
            this.Agelabel.Name = "Agelabel";
            this.Agelabel.Size = new System.Drawing.Size(28, 15);
            this.Agelabel.TabIndex = 5;
            this.Agelabel.Text = "Age";
            // 
            // Surnamelabel
            // 
            this.Surnamelabel.AutoSize = true;
            this.Surnamelabel.Location = new System.Drawing.Point(245, 66);
            this.Surnamelabel.Name = "Surnamelabel";
            this.Surnamelabel.Size = new System.Drawing.Size(54, 15);
            this.Surnamelabel.TabIndex = 4;
            this.Surnamelabel.Text = "Surname";
            // 
            // firstnamelabel
            // 
            this.firstnamelabel.AutoSize = true;
            this.firstnamelabel.Location = new System.Drawing.Point(22, 66);
            this.firstnamelabel.Name = "firstnamelabel";
            this.firstnamelabel.Size = new System.Drawing.Size(64, 15);
            this.firstnamelabel.TabIndex = 3;
            this.firstnamelabel.Text = "First Name";
            // 
            // Surnametxtbox
            // 
            this.Surnametxtbox.Location = new System.Drawing.Point(245, 84);
            this.Surnametxtbox.Name = "Surnametxtbox";
            this.Surnametxtbox.Size = new System.Drawing.Size(200, 23);
            this.Surnametxtbox.TabIndex = 2;
            // 
            // Firstnametxtbox
            // 
            this.Firstnametxtbox.Location = new System.Drawing.Point(22, 84);
            this.Firstnametxtbox.Name = "Firstnametxtbox";
            this.Firstnametxtbox.Size = new System.Drawing.Size(217, 23);
            this.Firstnametxtbox.TabIndex = 1;
            // 
            // textlabel1
            // 
            this.textlabel1.AutoSize = true;
            this.textlabel1.BackColor = System.Drawing.Color.Bisque;
            this.textlabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textlabel1.Location = new System.Drawing.Point(114, 19);
            this.textlabel1.Name = "textlabel1";
            this.textlabel1.Size = new System.Drawing.Size(241, 32);
            this.textlabel1.TabIndex = 0;
            this.textlabel1.Text = "Contact Tracing Form";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 434);
            this.Controls.Add(this.grpbox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Tracing";
            this.grpbox.ResumeLayout(false);
            this.grpbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbox;
        private System.Windows.Forms.Label textlabel1;
        private System.Windows.Forms.TextBox Surnametxtbox;
        private System.Windows.Forms.TextBox Firstnametxtbox;
        private System.Windows.Forms.Label Agelabel;
        private System.Windows.Forms.Label Surnamelabel;
        private System.Windows.Forms.Label firstnamelabel;
        private System.Windows.Forms.CheckBox Otherscheckbox;
        private System.Windows.Forms.CheckBox iffemalecheckbox;
        private System.Windows.Forms.CheckBox ifmalecheckbox;
        private System.Windows.Forms.Label Genderlabel;
        private System.Windows.Forms.TextBox Agetxtbox;
        private System.Windows.Forms.TextBox Addresstxtbox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox IfOtherstxtbox;
        private System.Windows.Forms.TextBox Contactnumtextbox;
        private System.Windows.Forms.Label contactnumlabel;
        private System.Windows.Forms.Button Submitbtn;
    }
}

