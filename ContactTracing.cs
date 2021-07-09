using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing_Form
{
    using System.IO;
    public partial class ContactTracing : Form
    {
        bool IfOthers = false;
        string Age;
        string FullName;
        string ContactNumber;
        string Address;
        public ContactTracing()
        {
            InitializeComponent();
            IfOtherstxtbox.Enabled = false; 
        }

        private void Otherscheckbox_CheckedChanged(object sender, EventArgs e)
        {
            IfOthers = true;
            if (IfOthers == true)
                IfOtherstxtbox.Enabled = true;
        }
        private void ifmalecheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (iffemalecheckbox.Checked == true)
                iffemalecheckbox.Checked = false;
            else
                Otherscheckbox.Checked = false;
        }

        private void iffemalecheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (ifmalecheckbox.Checked == true)
                ifmalecheckbox.Checked = false;
            else
                Otherscheckbox.Checked = false;
        }
        private void Submitbtn_Click(object sender, EventArgs e)
        {
            Age = Agetxtbox.Text;
            ContactNumber = Contactnumtextbox.Text;
            FullName = Firstnametxtbox.Text + Surnametxtbox;
            Address = Addresstxtbox.Text;
            StreamWriter ContactTracingForm;
            ContactTracingForm = File.CreateText(@"C:\Users\gian\Desktop\Submission");
            ContactTracingForm.WriteLine("Name:" + FullName);
            ContactTracingForm.WriteLine("Age" + Age);
            ContactTracingForm.WriteLine("Address" + Address);
            ContactTracingForm.WriteLine("ContactNumber" + ContactNumber);
            ContactTracingForm.Close();
            SaveFileDialog Save = new SaveFileDialog();
            Save.ShowDialog();
            MessageBox.Show("Your file has now been saved");

        }
    }
}
