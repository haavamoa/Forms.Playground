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
    public partial class FancyDetailPage : ContentPage
    {
        public FancyDetailPage()
        {
            InitializeComponent();
        }

      
    }

    public class Item
    {
        public string Name { get; set; }
        public ImageSource ImageSource { get; set; }

        public string Text { get; set; }
    }
}