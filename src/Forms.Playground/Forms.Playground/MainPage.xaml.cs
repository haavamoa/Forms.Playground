using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forms.Playground.Dribbble.Categories;
using Forms.Playground.FancyRowRemoval;
using Forms.Playground.MountainApp;
using Forms.Playground.WeatherApp;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Forms.Playground
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void NavigateToMountainApp(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new MountainPage());
        }

        private void NavigateToWeatherApp(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new WeatherPage());
        }

        private void NavigateToCategories(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new CategoriesPage());
        }
        private void NavigateToFancyRowRemoval(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new FancyRowRemovalPage());
        }
    }
}