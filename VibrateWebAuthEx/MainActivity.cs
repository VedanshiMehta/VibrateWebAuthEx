using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace VibrateWebAuthEx
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private Button myVibrate;
        private Button myWebAunthenticator;
        private Button myVersionTracking;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            myVibrate = FindViewById<Button>(Resource.Id.button1);
            myWebAunthenticator = FindViewById<Button>(Resource.Id.button2);
            myVersionTracking= FindViewById<Button>(Resource.Id.button3);

            myVibrate.Click += MyVibrate_Click;
            myWebAunthenticator.Click += MyWebAunthenticator_Click;
            myVersionTracking.Click += MyVersionTracking_Click;
        }

        private void MyVersionTracking_Click(object sender, System.EventArgs e)
        {
            Intent k = new Intent(Application.Context, typeof( VersionTrackingDemo));
            StartActivity(k);
        }

        private void MyWebAunthenticator_Click(object sender, System.EventArgs e)
        {
            Intent j = new Intent(Application.Context, typeof(WebAuthenticatorDemo));
            StartActivity(j);
        }

        private void MyVibrate_Click(object sender, System.EventArgs e)
        {
            Intent i = new Intent(Application.Context, typeof(VibrateDemo));
            StartActivity(i);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}