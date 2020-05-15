using System;
using Android.Content.Res;
using Forms.Playground.WeatherApp;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Forms.Playground
{
    public partial class App : Application
    {
        public App()
        {
            DIPS.Xamarin.UI.Library.Initialize();
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());

            //Set theme
            SetColors(Application.Current.RequestedTheme);
            Application.Current.RequestedThemeChanged += (s, a) => SetColors(a.RequestedTheme);
        }

        protected override void OnStart()
        {
            //Handle theme changed
            
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        private static void SetColors(OSAppTheme oSAppTheme)
        {
            switch (oSAppTheme)
            {
                case OSAppTheme.Unspecified:
                    break;
                case OSAppTheme.Light:
                    Application.Current.Resources["DynamicGridColor"] = Application.Current.Resources["LightGridColor"];
                    Application.Current.Resources["DynamicLabelTextColor"] = Application.Current.Resources["LightLabelTextColor"];
                    break;
                case OSAppTheme.Dark:
                    Application.Current.Resources["DynamicGridColor"] = Application.Current.Resources["DarkGridColor"];
                    Application.Current.Resources["DynamicLabelTextColor"] = Application.Current.Resources["DarkLabelTextColor"];
                    break;
            }
        }
    }
}
