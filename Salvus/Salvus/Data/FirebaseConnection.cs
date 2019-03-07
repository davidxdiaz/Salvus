using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Salvus.Models;

namespace Salvus.Data
{
    public class FirebaseConnection
    {
        /*FirebaseClient client;
        public FirebaseConnection()
        {
           client = new FirebaseClient("https://salvus-accounts.firebaseio.com/");
        }

        public async Task<List<User>> getAccounts()
        {
            var accounts = (await this.client
                .Child("salvus-accounts")
                .OnceAsync<User>())
                .Select(item =>
                    new User
                    {
                        UserName = item.Object.UserName,
                        Password = item.Object.Password

                    }
                    ).ToList();

            return accounts;

        }

        public async Task<User> LoginAccount(string username,string password)
        {
            var accounts = await this.getAccounts();
            foreach(var item in accounts)
            {
                if (item.UserName.Equals(username) && item.Password.Equals(password))
                {
                    User account =new User{
                        UserName = username,
                        Password = password
                    };
                 
                    return account;
                }
            }
            return null;


        }
     */   
    }
}
 