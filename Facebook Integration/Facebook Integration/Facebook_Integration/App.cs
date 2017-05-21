using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook_Integration.Views;
using Xamarin.Forms;

namespace Facebook_Integration
{
    public class App : Application
    {
        public App()
        {
            

            MainPage = new NavigationPage(new Login());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
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
