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
    public partial class Add_contact_form : Form
    {
        public Add_contact_form()
        {
            InitializeComponent();
        }

        private void AddContact_btn_Click(object sender, EventArgs e)
        {

        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        
        }
    }
}
