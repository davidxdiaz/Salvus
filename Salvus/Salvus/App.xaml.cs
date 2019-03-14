using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Salvus
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Salvus.Views.LoginPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            //com.companyname.Salvus

        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
