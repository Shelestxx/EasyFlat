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
            string email = txtEmail.Text;
            string pass = txtPass.Text;
            string name = txtName.Text;
            string phoneNumber = txtPhoneNumber.Text;
           

            if (email == null || email == "" | pass == null || pass == "" | name == null || name == "" | phoneNumber == null || phoneNumber == "")
            {
                MessageBox.Show("Спробуйте знову");
            }
            // Валидация имени: только буквы
            if (!Regex.IsMatch(name, @"^[a-zA-Zа-яА-Я]+$"))
            {
                MessageBox.Show("Ім'я має складатися з літер!");
                return;
            }

            // Валидация номера телефона: только цифры
            if (!Regex.IsMatch(phoneNumber, @"^\d+$"))
            {
                MessageBox.Show("Номер телефону має складатися з цифер!");
                return;
            }
            UserManager userManager = new UserManager();
            int generatedId = userManager.GenerateUserId();    

            User user = new User(generatedId, name, email, pass, phoneNumber, UserType.Regular);

            if (userManager.AddUser(user))
            {
                MessageBox.Show("Реєстрація пройшла успішно!");
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Користувач вже зареєстрований!");
            }

            AllListingsForm newForm = new AllListingsForm(user); // Создаем экземпляр Form2
            newForm.Show(); // Открываем Form2
            this.Hide(); // Скрываем Form1 (чтобы можно было вернуться)

        }
    }
}
