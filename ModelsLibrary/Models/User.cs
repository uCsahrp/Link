using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsLibrary.Models
{
    public abstract class User : IUser
    {
        public string UserNAme { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Access { get; set; }

        public User()
        {

        }

        public void LogIn()
        {
            throw new NotImplementedException();
        }

        public void LogOut()
        {
            throw new NotImplementedException();
        }
    }
}
