using System;
using Xunit;
using EasyFlat;
using EasyFlat.Classes;
namespace UnitTestProject1
{
    public class UserTests
    {
        [Fact]
        public void UserInitialization_ShouldSetPropertiesCorrectly()
        {
            var user = new User(1, "Oleh", "oleh@example.com", "1234567890", UserType.Regular, "password");

            Assert.Equal(1, user.ID);
            Assert.Equal("Oleh", user.Name);
            Assert.Equal("oleh@example.com", user.Email);
            Assert.Equal("password", user.PasswordHash);
            Assert.Equal("1234567890", user.PhoneNumber);
            Assert.Equal(UserType.Regular, user.Type);
        }

        [Fact]
        public void PropertyUser_RentProperty_ShouldAddAddress()
        {
            var user = new PropertyUser(2, "Oleh", "oleh@example.com", "pass", "0987654321");

            user.RentProperty("вул. Шевченка, 10");

            Assert.Contains("вул. Шевченка, 10", user.RentalAddresses);
        }

        [Fact]
        public void PropertyUser_ListProperty_ShouldIncrementPropertiesOwned()
        {
            var user = new PropertyUser(3, "Oleh", "oleh@example.com", "pass", "1122334455");

            user.ListProperty(2);

            Assert.Equal(2, user.PropertiesOwned);
        }
    }
}