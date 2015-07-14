using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XFormsUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            this.MainPage = new Foody();
        }

        protected override void OnStart()
        {
            base.OnStart();
        }

        /// <summary>
        /// The on sleep.
        /// </summary>
        protected override void OnSleep()
        {
            base.OnSleep();
        }

        /// <summary>
        /// The on resume.
        /// </summary>
        protected override void OnResume()
        {
            base.OnResume();
        }
    }
}
