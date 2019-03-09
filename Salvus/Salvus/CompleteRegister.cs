using Salvus.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Salvus
{
    class CompleteRegister:ContentPage
    {
        Image splashImage;
       

        public CompleteRegister()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            var sub = new AbsoluteLayout();
            splashImage = new Image
            {
                Source = "check_image.png",
                WidthRequest = 100,
                HeightRequest = 100
            };
            AbsoluteLayout.SetLayoutFlags(splashImage,
               AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(splashImage,
             new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

            sub.Children.Add(splashImage);

            this.BackgroundColor = Color.White;
            this.Content = sub;
        }

          
        
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await splashImage.ScaleTo(1, 2000); //Time-consuming processes such as initialization
         //  await splashImage.ScaleTo(0.9, 1500, Easing.Linear);
                                                // await splashImage.ScaleTo(150, 1200, Easing.Linear);

            Application.Current.MainPage = new LoginPage();    //After loading  MainPage it gets Navigated to our new Page
        }

    }
}
