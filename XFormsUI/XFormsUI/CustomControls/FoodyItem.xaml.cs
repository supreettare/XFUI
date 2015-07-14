using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XFormsUI.CustomControls
{
    public partial class FoodyItem : ViewCell
    {
        public FoodyItem()
        {
            InitializeComponent();
        }


        public string ImageURL
        {
            get { return (string)GetValue(ImageURLProperty); }
            set
            {
                SetValue(ImageURLProperty, value);
                this.imgFoodItem.Source = value;
            }
        }

        // Using a DependencyProperty as the backing store for ImageURL.  This enables animation, styling, binding, etc...
        public static readonly BindableProperty ImageURLProperty =
            BindableProperty.Create<FoodyItem, string>(x => x.ImageURL,
            defaultValue: "Foody1.jpg",
            defaultBindingMode: BindingMode.TwoWay,
            propertyChanging: (bindable, oldValue, newValue) =>
            {
                var ctrl = (FoodyItem)bindable;
                ctrl.imgFoodItem.Source = newValue;
            });
    }
}
