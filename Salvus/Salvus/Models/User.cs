using System;
using System.Collections.Generic;
using System.Text;

namespace Salvus.Models
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }


     
    

        public bool checkAccount()
        {
            if (this.UserName.Equals("") || this.Password.Equals(""))
            {
                return false;
            }else if (existAccount())
            {
                
            }
            return false;
        }

        private bool existAccount()
        {
            return false;
        }
    }
}
