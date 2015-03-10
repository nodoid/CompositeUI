using System;

using Xamarin.Forms;

namespace CompositeUI
{
    public class App : Application
    {
        public static Size DeviceWindowSize { get; set; }

        public static string text { get; set; }

        public static string filename { get; set; }

        public static bool onTheLeft { get; set; }

        public App()
        {
            // The root page of your application
            MainPage = new Login();
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

