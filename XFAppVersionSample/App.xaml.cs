using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFAppVersionSample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Xamarin.Essentials.VersionTracking.Track();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
