﻿using Foundation;
using UIKit;
using Xamarin.Forms;

namespace CompositeUI.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            App.DeviceWindowSize = new Size(UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height);
            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}

