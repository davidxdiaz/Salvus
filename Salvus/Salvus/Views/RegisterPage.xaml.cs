using Firebase.Database;
using Salvus.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Salvus.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RegisterPage : ContentPage
	{
		public RegisterPage ()
		{


            InitializeComponent();
		}

        public void CreateAccount(Object sender, EventArgs e)
        {
            string _email = entry_email.Text;
            string _password = entry_password.Text;
            string _firstName = entry_firstName.Text;
            string _lastName = entry_lastName.Text;
            string _address1 = entry_address1.Text;
            string _mobile = entry_address1.Text;
            string _mobile2 = entry_mobile2.Text;
            string _phone = entry_phone.Text;
            string _phone2 = entry_phone2.Text;
            try
            {
                FirebaseConnection connection = new FirebaseConnection();
                connection.RegisterAccount(_firstName, _lastName, _email, _password, _address1, _mobile, _phone, _mobile2, _phone2);
            }catch (AppDomainUnloadedException)
            {
                DisplayAlert("Error", "No hay conexion a internet", "Ok");
            }
        }
    }
}