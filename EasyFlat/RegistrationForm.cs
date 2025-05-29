using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyFlat.Classes;

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
            string email = txtEmail.Text.Trim();
            string pass = txtPass.Text;
            string name = txtName.Text.Trim();
            string phoneNumber = txtPhoneNumber.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(pass) ||
                string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Заповніть усі поля!");
                return;
            }

            if (!Regex.IsMatch(name, @"^[a-zA-Zа-яА-Я]+$"))
            {
                MessageBox.Show("Ім'я має складатися з літер!");
                return;
            }

            if (!Regex.IsMatch(phoneNumber, @"^\d+$"))
            {
                MessageBox.Show("Номер телефону має складатися лише з цифр!");
                return;
            }

            using (var context = new AppDbContext())
            {
                // Перевіряємо, чи існує користувач з таким email
                bool emailExists = context.Users.Any(u => u.Email == email);
                if (emailExists)
                {
                    MessageBox.Show("Користувач з таким email вже існує!");
                    return;
                }

                // Створюємо нового користувача
                var user = new User
                {
                    Name = name,
                    Email = email,
                    PhoneNumber = phoneNumber,
                    Type = UserType.Regular,
                };
                user.SetPassword(pass); // хешує пароль всередині методу

                context.Users.Add(user);
                context.SaveChanges(); // зберігаємо до БД

                MessageBox.Show("Реєстрація пройшла успішно!");

                AllListingsForm newForm = new AllListingsForm(user);
                newForm.Show();
                this.Hide();
            }
        }

    }
}
