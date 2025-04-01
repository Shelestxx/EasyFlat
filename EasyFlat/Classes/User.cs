using EasyFlat.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BCrypt.Net;

namespace EasyFlat.Classes
{
    public enum UserType
    {
        Regular,    // Орендодавець/Орендар
        Administrator    // Адміністратор
    }

    public class User : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }
        public string PhoneNumber { get; set; }
        public UserType Type { get; set; }
        public string PasswordHash { get; private set; }

        public User(int id, string name, string email, string pass, string phoneNumber, UserType type)
        {
            ID = id;
            Name = name;
            Email = email;
            Pass = pass;
            PhoneNumber = phoneNumber;
            Type = type;
        }
    }

    public class PropertyUser : User // Універсальний користувач
    {
        public List<string> RentalAddresses { get; set; } = new List<string>(); // Оренда
        public int PropertiesOwned { get; set; } = 0; // Здача

        public PropertyUser(int id, string name, string email, string pass, string phoneNumber)
            : base(id, name, email, pass, phoneNumber, UserType.Regular) { }

        // Оренда об'єкта
        public void RentProperty(string address)
        {
            RentalAddresses.Add(address);
            MessageBox.Show($"Орендовано об'єкт за адресою: {address}", "Оренда", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Здача об'єкта
        public void ListProperty(int properties)
        {
            PropertiesOwned += properties;
            MessageBox.Show($"Додано {properties} об'єкт(ів) нерухомості", "Здача нерухомості", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    public class Administrator : User
    {
        public string Role { get; }

        public Administrator(int id, string name, string email, string pass, string phoneNumber, string role)
            : base(id, name, email, pass, phoneNumber, UserType.Administrator)
        {
            Role = role;
        }
    }

    public class UserRepository : Repository<User> { }
}