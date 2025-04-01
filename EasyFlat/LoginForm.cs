using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using EasyFlat.Classes;

namespace EasyFlat
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string pass = txtPass.Text;

            if (email == null || email == "" | pass == null || pass == "" ) 
            {
                MessageBox.Show("Please try again");
                return;
            }

            UserManager userManager = new UserManager();
            User user = userManager.LoginUser(email, pass);
            if (user == null)
            {
                MessageBox.Show("Please try again");
                return;
            }

            MessageBox.Show($"Hello, {user.Name}");
        }
    }
}
