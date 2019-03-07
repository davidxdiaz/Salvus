using Salvus.Data;
using Salvus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Salvus.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
		}

        public void Login(Object sender,EventArgs e)
        {
            
           // FirebaseConnection firebase = new FirebaseConnection();
            //Task<User> account=firebase.LoginAccount(entry_email.Text, entry_password.Text);
            
         //   if (account != null)
         //   {
                DisplayAlert("Login","Loggin Success","Ok");
         ///   }
         //   else
          //  {
         //       DisplayAlert("Login", "Login Not Correct", "Ok");
         //   }
        }

        private async void initRegister(object sender, EventArgs args)
        {
            var register= new RegisterPage();
            //await Navigation.PushAsync(register);
            App.Current.MainPage = new NavigationPage(register);
        }
    }
}