using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net; 


namespace EasyFlat.Classes
{
    public class UserManager
    {
        private const string userFilePath = "../../users.db";
        private List<User> Users { get; set; }

        public UserManager() 
        {
            this.ReadUsersFrimFile();
        }

        public int GenerateUserId()
        {
            if (Users.Count == 0)
                return 1; // Якщо список порожній, перший ID буде 1

            return Users.Max(u => u.ID) + 1; // Беремо максимальний ID + 1
        }

        public bool AddUser(User user)
        {
            if(this.Users.Any(u => u.Email == user.Email))
            {
                return false;
            }

            user.Pass = BCrypt.Net.BCrypt.HashPassword(user.Pass);

            this.Users.Add(user);

            this.UserToFile();

            return true; 
        }

        public User LoginUser(string email, string pass)
        {
            // 1. Знаходимо користувача ТІЛЬКИ за email
            User user = this.Users.Find(u => u.Email == email);

            // 2. Якщо користувача не знайдено
            if (user == null)
            {
                Console.WriteLine("User not found!");
                return null;
            }

            // 3. Перевіряємо пароль через BCrypt
            bool isPasswordCorrect = BCrypt.Net.BCrypt.Verify(pass, user.Pass);


            if (!isPasswordCorrect)
            {
                return null;
            }

            return user;
        }


        private void ReadUsersFrimFile()
        {
            if (File.Exists(userFilePath))
            {
                string fileContents = File.ReadAllText(userFilePath);
                this.Users = Newtonsoft.Json.JsonConvert.DeserializeObject<List<User>>(fileContents);
            }
            else
            {
                this.Users = new List<User>();
            }
        }
        private void UserToFile()
        {
            string fileContents = Newtonsoft.Json.JsonConvert.SerializeObject(this.Users);
            File.WriteAllText(userFilePath, fileContents);
        }

    }
}
