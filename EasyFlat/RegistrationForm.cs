using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyFlat
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string pass = txtPass.Text;

            if (email == null || email == "")
            {
                MessageBox.Show("email Failed is required");
            }
            if (pass == null || pass == "")
            {
                MessageBox.Show("Password Failed is required");
            }
        }
    }
}
