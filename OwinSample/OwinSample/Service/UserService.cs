using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OwinSample.Models.Service
{
    public class UserService
    {
        public User GetUserByCredentials(string Email, string Password)
        {
            if (Email!="email@domain.com"|| Password != "Password")
            {
                return null;
            }
            User user = new User()
            {
                Id = 1,
                Name="Aravind",
                Email="email@domain.com",
                Password="Password"
            };
            if (user != null)
            {
                user.Password = string.Empty;
            }
            return user;
        }
    }
}