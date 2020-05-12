using System;
using Forms.Playground.AppThemeColor;
using Forms.Playground.CascadeInputTransparent;
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

        private async void NavigateToAppThemeColor(object sender, EventArgs e) => await Navigation.PushAsync(new AppThemeColorPage());

        private async void NavigateToCategories(object sender, EventArgs e) => await Navigation.PushAsync(new CategoriesPage());

        private async void NavigateToFancyRowRemoval(object sender, EventArgs e) => await Navigation.PushAsync(new FancyRowRemovalPage());

        private async void NavigateToMountainApp(object sender, EventArgs e) => await Navigation.PushAsync(new MountainPage());

        private async void NavigateToWeatherApp(object sender, EventArgs e) => await Navigation.PushAsync(new WeatherPage());
        private async void NavigateToCascadeInputTransparent(object sender, EventArgs e) => await Navigation.PushAsync(new CascadeInputTransparentPage());
    }
}