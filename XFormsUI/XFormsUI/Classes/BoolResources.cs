using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFormsUI.Classes
{
    public static class BoolResources
    {
        public static readonly bool ShouldShowBoxView = Device.OnPlatform(true, false, true); 
    }
}
