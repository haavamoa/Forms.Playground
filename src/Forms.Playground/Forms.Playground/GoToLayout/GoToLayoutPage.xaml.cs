using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Forms.Playground.GoToLayout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GoToLayoutPage : ContentPage
    {
        public GoToLayoutPage()
        {
            InitializeComponent();
        }

        private void ChangeState(object sender, EventArgs e)
        {
            var rnd = new Random();
            var index = rnd.Next(0, 3);
            if(index == 0)
            {
                TheItem.LayoutTo(FirstState.Bounds);
            }
            if(index == 1)
            {
                TheItem.LayoutTo(SecondState.Bounds);
            }

            if(index == 2)
            {
                TheItem.LayoutTo(ThirdState.Bounds);
            }
            
        }
    }
}