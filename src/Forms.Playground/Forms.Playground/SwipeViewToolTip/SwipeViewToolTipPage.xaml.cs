using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Forms.Playground.SwipeViewToolTip
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SwipeViewToolTipPage : ContentPage
    {
        public SwipeViewToolTipPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            await Task.Delay(1500);
            NameSwipeView.Open(OpenSwipeItem.LeftItems);
            await Task.Delay(1500);
            NameSwipeView.Close();
        }
    }
}