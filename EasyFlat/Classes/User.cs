using EasyFlat.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BCrypt.Net;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyFlat.Classes
{
    public enum UserType
    {
        Regular,    // Орендодавець/Орендар
        Administrator    // Адміністратор
    }

    public class User : IEntity
    {
        public void SetPassword(string password)
        {
            this.PasswordHash = BCrypt.Net.BCrypt.HashPassword(password);
        }
        public int ID { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(150)]
        public string Email { get; set; }

        // Це було порожнє місце — видалив зайве

        [MaxLength(20)]
        public string PhoneNumber { get; set; }

        public UserType Type { get; set; }

        [MaxLength(255)]
        public string PasswordHash { get; set; }

        

        public virtual List<Listing> Listings { get; set; } = new List<Listing>();

        public User() { }

        public User(int id, string name, string email, string phoneNumber, UserType type, string passwordHash)
        {
            ID = id;
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Type = type;
            PasswordHash = passwordHash;
        }
    }

    public class PropertyUser : User // Універсальний користувач
    {
        [NotMapped] // EF Core не підтримує список рядків напряму, тому ігноруємо цю властивість в БД
        public List<string> RentalAddresses { get; set; } = new List<string>(); // Оренда

        public int PropertiesOwned { get; set; } = 0; // Здача

        public PropertyUser() : base() { }

        public PropertyUser(int id, string name, string email, string phoneNumber, string passwordHash)
            : base(id, name, email, phoneNumber, UserType.Regular, passwordHash) { } // порядок аргументів виправлено

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

        public Administrator() : base() { }

        public Administrator(int id, string name, string email, string phoneNumber, string passwordHash, string role)
            : base(id, name, email, phoneNumber, UserType.Administrator, passwordHash)
        {
            Role = role;
        }
    }

    public class UserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public User GetByEmail(string email)
        {
            return _context.Users.SingleOrDefault(u => u.Email == email);
        }

        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public void Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void Update(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }

        public void Remove(User user)
        {
            _context.Users.Remove(user);
            _context.SaveChanges();
        }
    }
}


