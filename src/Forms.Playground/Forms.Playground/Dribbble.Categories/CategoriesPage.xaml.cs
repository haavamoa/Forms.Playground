using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Forms.Playground.Dribbble.Categories
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CategoriesPage : ContentPage
    {
        public CategoriesPage()
        {
            InitializeComponent();
        }

        private void CarouselView_OnCurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
        {
            if (!(e.CurrentItem is Category category)) return;
            string startColor = string.Empty;
            string endColor = string.Empty;
            switch (category.Name)
            {

                case "Space":
                    startColor = "#FEAE06";
                    endColor = "#FF5274";
                    break;
                case "Relief":
                    startColor = "#FD0BF4";
                    endColor = "#F20095";
                    break;
                case "Nature":
                    startColor = "#0C9FFF";
                    endColor = "#0C9FFF";
                    break;
                case "Take off":
                    startColor = "#A2FFAE";
                    endColor = "#18D0F2";
                    break;
            }

            backgroundPancake.BackgroundGradientStartColor = Color.FromHex(startColor);
            backgroundPancake.BackgroundGradientEndColor = Color.FromHex(endColor);
        }
    }
}