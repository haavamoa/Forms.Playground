using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Forms.Playground.CascadeInputTransparent
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CascadeInputTransparentPage : ContentPage
    {
        public CascadeInputTransparentPage()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            App.Current.MainPage.DisplayAlert("Image tapped", "The image was tapped", "Ok");
        }
    }
}