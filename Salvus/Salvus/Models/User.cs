using System;
using System.Collections.Generic;
using System.Text;

namespace Salvus.Models
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }


        public User(string username,string password)
        {
            this.UserName = username;
            this.Password = password;
        }

    }
}
