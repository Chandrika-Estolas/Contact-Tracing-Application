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
    public partial class Add_contact_form : Form
    {
        public Add_contact_form()
        {
            InitializeComponent();
        }

        private void AddContact_btn_Click(object sender, EventArgs e)
        {
            String Filename = LastName_box.Text + GivenName_box.Text + MiddleInitial_box.Text +".txt";

            String Gender_Answer = "";
            if (Female_rbtn.Checked)
                Gender_Answer = "Female";
            else
            {
                if (Male_rbtn.Checked)
                    Gender_Answer = "Male";
            }


            StreamWriter outputFile;
            outputFile = File.CreateText(Filename);
            outputFile.WriteLine("Surname: " + LastName_box.Text);
            outputFile.WriteLine("Given Name: " + GivenName_box.Text);
            outputFile.WriteLine("Middle Initial: " + MiddleInitial_box.Text);
            outputFile.WriteLine("Age: " + Age.Text);
            outputFile.WriteLine("Gender: " + Gender_Answer);
            outputFile.WriteLine("Address: " + Address_box.Text);
            outputFile.WriteLine("Contact Number: " + ContactN_box.Text);
            outputFile.WriteLine("Email: " + Email_box.Text);
            outputFile.Close();

            MessageBox.Show("Your contact has been added.");

            this.Hide();
            Contact_Tracer MenuForm = new Contact_Tracer();
            MenuForm.Show();

            

        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Contact_Tracer MenuForm = new Contact_Tracer();
            MenuForm.Show();
        
        }

        private void Help_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All the information will be added and can be found by clicking the 'find contact' in the menu", "?");
        }
    }
    }

