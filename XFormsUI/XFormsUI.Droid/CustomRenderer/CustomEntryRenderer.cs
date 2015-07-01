using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using XFormsUI.Droid.CustomRenderer;

[assembly: ExportRenderer(typeof(Entry), typeof(CustomEntryRenderer))]

namespace XFormsUI.Droid.CustomRenderer
{
    public class CustomEntryRenderer :EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null)
            {
                return;
            }

            var nativeEditTextField = (Android.Widget.EditText)this.Control;          
            
            nativeEditTextField.SetHintTextColor(Android.Graphics.Color.White);
        }
    }
}