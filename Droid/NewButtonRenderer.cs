using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using CompositeUI;
using CompositeUI.Droid;

[assembly: ExportRenderer(typeof(NewButton), typeof(NewButtonRenderer))]
namespace CompositeUI.Droid
{
    public class NewButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.SetBackgroundResource(Resource.Drawable.RoundedButton);
                Control.SetTextColor(global::Android.Graphics.Color.White);
            }
        }
    }
}

