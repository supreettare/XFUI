using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XFormsUI
{
    public partial class Flaty : ContentPage
    {
        public Flaty()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                var t = ex.Message; 
            }           
        }
    }
}
