using Plugin.Connectivity;
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

        public async void Login(Object sender,EventArgs e)
        {
            if (!CrossConnectivity.Current.IsConnected)
            {
                await DisplayAlert("Conexion a Internet", "Sin conexion a Internet", "Ok");
                return;
            }
            
            FirebaseConnection firebase = new FirebaseConnection();
            
            User account=await firebase.LoginAccountAsync(entry_email.Text,entry_password.Text);
            
            if (account!=null)
            {
                await DisplayAlert("Login", "Loggin Success", "Ok");
             }
            else
            {
                await DisplayAlert("Login", "Login Not Correct", "Ok");
            }
        }
	}
}