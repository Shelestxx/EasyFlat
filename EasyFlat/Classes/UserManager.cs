using System;
using System.Linq;
using BCrypt.Net;
using Microsoft.EntityFrameworkCore;

namespace EasyFlat.Classes
{
    public class UserManager
    {
        public int GenerateUserId()
        {
            using (var db = new AppDbContext())
            {
                if (!db.Users.Any())
                    return 1;

                return db.Users.Max(u => u.ID) + 1;
            }
        }

        public bool AddUser(User user)
        {
            using (var db = new AppDbContext())
            {
                // Перевірка чи існує користувач з таким email
                if (db.Users.Any(u => u.Email == user.Email))
                {
                    return false;
                }

                // Хешування пароля
                user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(user.PasswordHash);
                user.PasswordHash = null; // більше не зберігаємо звичайний пароль

                db.Users.Add(user);
                db.SaveChanges();
                return true;
            }
        }

        public User LoginUser(string email, string pass)
        {
            using (var db = new AppDbContext())
            {
                User user = db.Users.FirstOrDefault(u => u.Email == email);

                if (user == null)
                {
                    Console.WriteLine("User not found!");
                    return null;
                }

                bool isPasswordCorrect = BCrypt.Net.BCrypt.Verify(pass, user.PasswordHash);

                if (!isPasswordCorrect)
                {
                    return null;
                }

                return user;
            }
        }

    }
}
