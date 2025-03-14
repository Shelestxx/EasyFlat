﻿using EasyFlat.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyFlat.Classes
{
    public enum UserType
    {
        Tenant,        //орендодар
        Lessor,        //Орендодавець
        Administrator
    }
    public class User : IEntity 
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
    }

    public class Tenant : User     // арендатор
    {
        public string RentalAddress { get; }

        public Tenant(int id, string name, string email, string phoneNumber, string rentalAddress)
            : base(id, name, email, phoneNumber, UserType.Tenant)
        {
            RentalAddress = rentalAddress;
        }
    }

    public class Landlord : User       //арендодатель
    {
        public int PropertiesOwned { get; }

        public Landlord(int id, string name, string email, string phoneNumber, int propertiesOwned)
            : base(id, name, email, phoneNumber, UserType.Lessor)
        {
            PropertiesOwned = propertiesOwned;
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
    }
    public class UserRepository : Repository<User> { } 
}
