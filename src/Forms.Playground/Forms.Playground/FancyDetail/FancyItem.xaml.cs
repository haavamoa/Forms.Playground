using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Forms.Playground.FancyDetail
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FancyItem : ContentView
    {
        public FancyItem()
        {
            InitializeComponent();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            if (!(sender is View view))
            {
                return;
            }


            if (!(Parent is StackLayout stackLayt))
                return;
            view.LayoutTo(((View)stackLayt.Parent).Bounds, 600);
            

            foreach (var child in stackLayt.Children)
            {
                if (child.BindingContext == BindingContext)
                    continue;
                child.FadeTo(0);
            }
        }
    }
}