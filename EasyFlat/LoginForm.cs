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

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Спробуйте знову!");
                return;
            }

            UserManager userManager = new UserManager();
            User user = userManager.LoginUser(email, pass);
            if (user == null)
            {
                MessageBox.Show("Спробуйте знову!");
                return;
            }

            MessageBox.Show($"Привіт, {user.Name}");

            // Передача поточного користувача в AllListingsForm
            AllListingsForm newForm = new AllListingsForm(user);  // Передаємо користувача
            newForm.Show();  // Відкриваємо нову форму
            this.Hide();     // Сховуємо поточну форму
        }


        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
