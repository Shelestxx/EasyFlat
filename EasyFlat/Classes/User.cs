using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyFlat.Classes
{
    public enum UserType
    {
        Tenant,        // Арендатор
        Lessor,        // Арендодатель
        Administrator
    }

    public class User
    {
        public int ID { get; }
        public string Name { get; }
        public string Email { get; }
        public string PhoneNumber { get; }
        public UserType Type { get; }

        public User(int id, string name, string email, string phoneNumber, UserType type)
        {
            ID = id;
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Type = type;
        }

        // Полиморфный метод
        public virtual string DisplayInfo()
        {
            return $"ID: {ID}, Имя: {Name}, Email: {Email}, Телефон: {PhoneNumber}, Тип: {Type}";
        }
    }

    public class Tenant : User     // Арендатор
    {
        public string RentalAddress { get; }

        public Tenant(int id, string name, string email, string phoneNumber, string rentalAddress)
            : base(id, name, email, phoneNumber, UserType.Tenant)
        {
            RentalAddress = rentalAddress;
        }

        public override string DisplayInfo()
        {
            return base.DisplayInfo() + $", Адрес аренды: {RentalAddress}";
        }
    }

    public class Landlord : User       // Арендодатель
    {
        public int PropertiesOwned { get; }

        public Landlord(int id, string name, string email, string phoneNumber, int propertiesOwned)
            : base(id, name, email, phoneNumber, UserType.Lessor)
        {
            PropertiesOwned = propertiesOwned;
        }

        public override string DisplayInfo()
        {
            return base.DisplayInfo() + $", Количество объектов: {PropertiesOwned}";
        }
    }

    public class Administrator : User
    {
        public string Role { get; }

        public Administrator(int id, string name, string email, string phoneNumber, string role)
            : base(id, name, email, phoneNumber, UserType.Administrator)
        {
            Role = role;
        }

        public override string DisplayInfo()
        {
            return base.DisplayInfo() + $", Роль: {Role}";
        }
    }
}
