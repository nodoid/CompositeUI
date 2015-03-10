using CompositeUI;
using CompositeUI.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using System.Linq;
using Android.Graphics;
using Android.Views;
using Java.Lang;
using System;
using Android.Graphics.Drawables;

[assembly: ExportRenderer(typeof(NewCompositeButton), typeof(NewCompositeButtonRenderer))]
namespace CompositeUI.Droid
{
    public class NewCompositeButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                var draw = Resources.GetDrawable(GetResourceIdFromFilename(App.filename));
                var other = Resources.GetDrawable(Android.Resource.Drawable.ButtonStar);
                Control.SetBackgroundResource(Resource.Drawable.RoundedButton);
                Control.SetCompoundDrawables(draw, other, other, other);
                Control.SetTextColor(Android.Graphics.Color.Black);
                Control.Text = App.text;
            }
        }

        public int GetResourceIdFromFilename(string filename)
        {
            var fn2 = filename.Replace('-', '_');
            fn2 = fn2.Split('.').ToArray()[0];
            var res = Resources.GetIdentifier(fn2, "drawable", Android.App.Application.Context.ApplicationInfo.PackageName);
            return res;
        }
    }
}

