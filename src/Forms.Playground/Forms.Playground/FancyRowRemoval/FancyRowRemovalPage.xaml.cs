using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Forms.Playground.FancyRowRemoval
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FancyRowRemovalPage : ContentPage
    {
        public FancyRowRemovalPage()
        {
            InitializeComponent();
        }

        public object SelectedRemovalMethod { get; set; }

        private async void Remove(object sender, EventArgs e)
        {
            if (!(sender is View view)) return;
            if (SelectedRemovalMethod == null)
            {
                App.Current.MainPage.DisplayAlert("Missing removal method", "Please choose a removal method", "Ok");
            }
            else
            {
                switch (SelectedRemovalMethod)
                {
                    case "Fade out":
                        await FadeOut(view);
                        break;
                    case "Scale out":
                        await ScaleOut(view);
                        break;
                    case "Slide out":
                        await SlideOut(view);
                        break;
                }
            }
        }


        private async Task SlideOut(View view)
        {
            await view.TranslateTo(view.Width, 0,easing: Easing.SpringIn);
            view.Animate("RemovalAnimation", d => { view.HeightRequest = d; }, view.Height, 0);
        }

        private async Task ScaleOut(View view)
        {
            await view.ScaleTo(0, easing: Easing.SpringIn);
            view.Animate("RemovalAnimation", d => { view.HeightRequest = d; }, view.Height, 0);
        }

        private static async Task FadeOut(View view)
        {
            await view.FadeTo(0);
            view.Animate("RemovalAnimation", d => { view.HeightRequest = d; }, view.Height, 0);
        }
    }
}