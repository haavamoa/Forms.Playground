using Xamarin.Forms;

namespace Forms.Playground.FancyRowRemoval
{
    public class PanGestureExtension : IPanGestureExtension
    {
        public static IPanGestureExtension Instance { get; set; }

        public void ShouldRespectOtherPans(View view)
        {
            if (Instance != null)
            {
                Instance.ShouldRespectOtherPans(view);
            }
        }
    }
    public interface IPanGestureExtension
    {
        void ShouldRespectOtherPans(View view);
    }
}