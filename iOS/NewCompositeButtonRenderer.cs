using System;
using Xamarin.Forms;
using CompositeUI;
using CompositeUI.iOS;

[assembly: ExportRenderer(typeof(NewCompositeButton), typeof(NewCompositeButtonRenderer))]
namespace CompositeUI.iOS
{
    public class NewCompositeButtonRenderer
    {
        string theFilename, theText;
        bool onTheLeft;

        public NewCompositeButtonRenderer()
        {
        }

        public NewCompositeButtonRenderer(string text, string filename, bool left)
        {
            theFilename = filename;
            theText = text;
            onTheLeft = left;
        }
    }
}

