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
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class VibrateDemo : Activity
    {
        private Button myClick;
        private Button myLongClick;
        private EditText myedt;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            
            SetContentView(Resource.Layout.vibrateDemo);
            myClick = FindViewById<Button>(Resource.Id.buttonClick);
            myedt = FindViewById<EditText>(Resource.Id.edittextV);
            myLongClick = FindViewById<Button>(Resource.Id.buttonLong);

            myClick.Click += MyClick_Click;
            myLongClick.Click += MyLongClick_Click;
        }

        private void MyLongClick_Click(object sender, EventArgs e)
        {

            
            var longV = TimeSpan.FromSeconds(5);
            Vibration.Vibrate(longV);
            HapticFeedback.Perform(HapticFeedbackType.Click);
            myedt.Text = $"Long Click Performed: " + DateTime.UtcNow;

        }

        private void MyClick_Click(object sender, EventArgs e)
        {
            Vibration.Vibrate();

            HapticFeedback.Perform(HapticFeedbackType.Click);
            myedt.Text = $"Click Performed: " + DateTime.UtcNow;
        }
    }
}