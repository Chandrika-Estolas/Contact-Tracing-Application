using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing_Application
{
    public partial class Contact_Tracer : Form
    {
        public Contact_Tracer()
        {
            InitializeComponent();
        }

        private void About_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Chandrika Estolas.                                  " +
                "                                  Contract Tracer Application is an application that will help you find and add contact easily.", 
                "About Contact Tracer");
        }

        private void Help_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you want to add a contact, click the button add contact                   " +
                "    If you wnat to find a contact, click the button find contact", "Help");
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_contact_form AddContactForm = new Add_contact_form();
            AddContactForm.Show();
        }

        private void Find_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Find_Contact_form FindContactForm = new Find_Contact_form();
            FindContactForm.Show();
        }
    }
}
