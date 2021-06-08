using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing_Application
{
    public partial class Find_Contact_form: Form
    {
        public Find_Contact_form()
        {
            InitializeComponent();
        }

        private void Help_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Input the surname, given name, and middle initial of the contact that you want to find, then click find contact.", "Help");
        }

        private void FindContact_btn_Click(object sender, EventArgs e)
        {
            String FileName = surname_box.Text + GivenName_box.Text + MiddleInitial_box.Text + ".txt";

                using (StreamReader InputFile = new StreamReader(FileName))
                {
                    while (!InputFile.EndOfStream)
                    {
                        Ouput_box.AppendText (InputFile.ReadToEnd());
                    }
                }
        }

        private void Back_btn_click(object sender, EventArgs e)
        {
            this.Hide();
            Contact_Tracer MenuForm = new Contact_Tracer();
            MenuForm.Show();
        }
    }
}
