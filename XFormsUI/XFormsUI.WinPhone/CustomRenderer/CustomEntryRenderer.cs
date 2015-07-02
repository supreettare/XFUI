using Microsoft.Phone.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WinPhone;
using XFormsUI.WinPhone.CustomRenderer;

[assembly: ExportRenderer(typeof(Entry), typeof(CustomEntryRenderer))]

namespace XFormsUI.WinPhone.CustomRenderer
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

            var nativePhoneTextBox = (PhoneTextBox)this.Control.Children[0];
            nativePhoneTextBox.Background = new SolidColorBrush(Colors.Transparent);
            nativePhoneTextBox.BorderThickness = new System.Windows.Thickness(0);

            nativePhoneTextBox.HintStyle = (System.Windows.Style)App.Current.Resources["LoginHintTextBlockStyle"];
                      
        }
    }
}
