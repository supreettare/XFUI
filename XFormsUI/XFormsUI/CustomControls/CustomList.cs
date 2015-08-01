using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFormsUI.CustomControls
{
    public class CustomList : ListView
    {
        

        public ObservableCollection<FoodyClass> ListDataSource
        {
            get { return (ObservableCollection<FoodyClass>)GetValue(DataSourceProperty); }
            set
            {
                SetValue(DataSourceProperty, value);
                this.ItemsSource = value;
            }
        }

        // Using a DependencyProperty as the backing store for ImageURL.  This enables animation, styling, binding, etc...
        public static readonly BindableProperty DataSourceProperty =
            BindableProperty.Create<CustomList, ObservableCollection<FoodyClass>>(x => x.ListDataSource,
            defaultValue: new ObservableCollection<FoodyClass>(),
            defaultBindingMode: BindingMode.TwoWay,
            propertyChanging: (bindable, oldValue, newValue) =>
            {
                var ctrl = (CustomList)bindable;
                ctrl.ItemsSource = newValue;
            });

    }
}
