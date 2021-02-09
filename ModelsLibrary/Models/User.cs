using ModelsLibrary.Utilities;
using System;
using System.Collections.Generic;
using System.Text;


namespace ModelsLibrary.Models
{
    public class User : IUser
    {
        public string UserNAme { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Access { get; set; }
        public IDataAccess _dataAccess;

        public User(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

     /*   public User(string userNAme, string password, string email, int access)
        {
            UserNAme = userNAme;
            Password = password;
            Email = email;
            Access = access;
           
        }*/
        public User()
        {

        }

        public bool LogIn(string username, string password)
        {
            string sql = "SELECT * FROM users WHERE Username = @Username AND Password = @Password";

            var user = new { username = username, password = password };
            var output = _dataAccess.LoadData<User, dynamic>(sql, user);

            if (output.Count == 0)
            {
                return false;
            } else
            {
                return true;
            }
        }

        public void LogOut()
        {

        }
    }
}
