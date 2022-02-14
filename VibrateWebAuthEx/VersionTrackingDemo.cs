using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Essentials;

namespace VibrateWebAuthEx
{
    [Activity(Label = "VersionTrackingDemo")]
    public class VersionTrackingDemo : Activity
    {
        private Button mButton;
        private TextView mtext1;
        private TextView mtext2;
        private TextView mtext3;
        private TextView mtext4;
        private TextView mtext5;
        private TextView mtext6;
        private TextView mtext7;
        private TextView mtext8;
        private TextView mtext9;
        private TextView mtext10;
        private TextView mtext11;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.versionTrackingDemo);
            mButton = FindViewById<Button>(Resource.Id.buttonCI);
            mtext1 = FindViewById<TextView>(Resource.Id.textViewC1);
            mtext2 = FindViewById<TextView>(Resource.Id.textViewC2);
            mtext3 = FindViewById<TextView>(Resource.Id.textViewC3);
            mtext4 = FindViewById<TextView>(Resource.Id.textViewC4);
            mtext5 = FindViewById<TextView>(Resource.Id.textViewC5);
            mtext6 = FindViewById<TextView>(Resource.Id.textViewC6);
            mtext7 = FindViewById<TextView>(Resource.Id.textViewC7);
            mtext8 = FindViewById<TextView>(Resource.Id.textViewC8);
            mtext9 = FindViewById<TextView>(Resource.Id.textViewC9);
            mtext10 = FindViewById<TextView>(Resource.Id.textViewC10);
            mtext11 = FindViewById<TextView>(Resource.Id.textViewC11);


            mButton.Click += MButton_Click;
        }

        private void MButton_Click(object sender, EventArgs e)
        {
            
            mtext1.Text = VersionTracking.IsFirstLaunchEver.ToString();
            mtext2.Text = VersionTracking.IsFirstLaunchForCurrentVersion.ToString();
            mtext3.Text = VersionTracking.IsFirstLaunchForCurrentBuild.ToString();
            mtext4.Text = VersionTracking.CurrentVersion;
            mtext5.Text = VersionTracking.CurrentBuild;
            mtext6.Text = VersionTracking.PreviousVersion;
            mtext7.Text = VersionTracking.PreviousBuild;
            mtext8.Text = VersionTracking.FirstInstalledVersion;
            mtext9.Text = VersionTracking.FirstInstalledBuild;

            var verhis = VersionTracking.VersionHistory?.FirstOrDefault();
            if (verhis != null)
            {

                mtext10.Text = verhis;

            }
            var buildhis = VersionTracking.VersionHistory?.FirstOrDefault();
            if (buildhis != null)
            {

                mtext11.Text = buildhis;

            }

            
        }
    }
}