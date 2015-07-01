using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms.Platform.iOS;
using XFormsUI.iOS.CustomRenderer;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(Entry), typeof(CustomEntryRenderer))]

namespace XFormsUI.iOS.CustomRenderer
{
    public class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null)
            {
                return;
            }

            var nativeTextField = this.Control;
            //nativeTextField.Layer.BorderWidth = 1;
            //nativeTextField.Layer.CornerRadius = 3;
            //nativeTextField.Layer.BorderColor = UIColor.White.CGColor;
            nativeTextField.AdjustsFontSizeToFitWidth = true;
            nativeTextField.AttributedPlaceholder = new NSAttributedString(
             nativeTextField.Placeholder,
             foregroundColor: UIColor.White);
        }
    }
}