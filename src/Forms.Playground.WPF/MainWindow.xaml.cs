using Xamarin.Forms;
using Xamarin.Forms.Platform.WPF;

namespace Forms.Playground.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : FormsApplicationPage
    {
        public MainWindow()
        {
            InitializeComponent();

            Xamarin.Forms.Forms.SetFlags("CarouselView_Experimental", "AppTheme_Experimental");
            global::Xamarin.Forms.Forms.Init();

            LoadApplication(new Forms.Playground.App());


        }
    }
}
