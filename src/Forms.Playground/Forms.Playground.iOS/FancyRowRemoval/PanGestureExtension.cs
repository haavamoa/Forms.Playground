using System.Linq;
using Forms.Playground.FancyRowRemoval;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

namespace Forms.Playground.iOS.FancyRowRemoval
{
    public class PanGestureExtension : IPanGestureExtension
    {
        public void ShouldRespectOtherPans(View view)
        {
            var renderer = Platform.GetRenderer(view);
            var uiView = renderer.NativeView;
            foreach (var uiViewGestureRecognizer in uiView.GestureRecognizers)
            {
                if (uiViewGestureRecognizer is UIPanGestureRecognizer panGestureRecognizer)
                {
                    panGestureRecognizer.ShouldRecognizeSimultaneously = (recognizer, gestureRecognizer) =>
                    {
                        return true;
                    };
                }
            }
        }
    }
}