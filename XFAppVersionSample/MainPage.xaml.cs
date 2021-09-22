using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace XFAppVersionSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            current.Text = $"{VersionTracking.CurrentBuild} {VersionTracking.CurrentVersion}";
            previous.Text = $"{VersionTracking.PreviousBuild} {VersionTracking.PreviousVersion}";

            if (VersionTracking.IsFirstLaunchForCurrentBuild)
                isNew.Text = "New Version";
        }
    }
}
