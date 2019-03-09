using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

using System.Threading.Tasks;
using Salvus.Models;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

using Firebase.Database;
using Firebase.Database.Query;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Net.Http;




namespace Salvus.Data
{

    public class FirebaseConnection
    {
        IFirebaseClient client;

        public IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret= "LVBOQBe6mHc6dMFJux0g72Wm8p5qAL9849suOx1x",
            BasePath= "https://salvus-accounts.firebaseio.com/"
        };

        
        public FirebaseConnection()
        {
            
            client = new FireSharp.FirebaseClient(config);
           
        }

        public async Task<List<User>> GetAccountsAsync()
        {
            FirebaseResponse result;
           result = await client.GetAsync("Accounts");
           
            List<User> list_user = result.ResultAs<List<User>>();
            return list_user;
        }

        

        public async Task<User> LoginAccountAsync(string username,string password)
        {
            List<User> accounts = await this.GetAccountsAsync();
            foreach(User item in accounts)

            {
                if (item.EmailId.Equals(username) && item.Password.Equals(password))
                {
                    return item;
                }
            }
            return null;


        }
        public async void RegisterAccount(string _firstname, string _lastname,string _email, string _password,string _address1,string _mobile,string _phone,string _mobile2,string _phone2)
        {
            User data = new User
            {
                EmailId = _email,
                Password = _password,
                FirstName = _firstname,
                LastName= _lastname,
                Address1=_address1,
                Phone=_phone,
                Phone2 = _phone2,
                Mobile = _mobile,
                Mobile2 = _mobile2,

        
            };
            List<User> list=new List<User>();
            try
            {
               list= await this.GetAccountsAsync();
               list.Add(data);
            }
            catch (System.NullReferenceException e)
            {
                list = new List<User>{data};
                PushResponse  response= await client.PushAsync("Accounts", list);
            }
           
           
            await client.SetAsync("Accounts", list);
            
            
        }
    }
}
 