using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace EasyFlat.Classes
{
    public class UserManager
    {
        private static readonly string userFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "users.db");

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
            this.Users.Add(user);

            this.UserToFile();

            return true; 
        }

        public User LoginUser(string email, string pass)
        {
            User user = this.Users.Find(u=> u.Email == email && u.Pass == pass);
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
