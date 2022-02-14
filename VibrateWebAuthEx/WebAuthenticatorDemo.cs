using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Webkit;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Essentials;

namespace VibrateWebAuthEx
{


    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]


    public class WebAuthenticatorDemo : Activity
    {
   
        private Button buttonclickme;
        //private WebView webView;
        private TextView textView;
       
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.webauthenticationDemo);

            buttonclickme = FindViewById<Button>(Resource.Id.buttonClickWA);
           // webView = FindViewById<WebView>(Resource.Id.webView1);
            textView = FindViewById<TextView>(Resource.Id.textViewWA);

            buttonclickme.Click += Buttonclickme_Click;


        }



        private void Buttonclickme_Click(object sender, EventArgs e)
        {

            WebCall();


        }
     

        private async void WebCall()
        {
            var callbackUrl = new Uri(WebConfig.Callback);
            var loginUrl = new Uri("http://www.facebook.com/login.php");

            var authenticationResult = await WebAuthenticator.AuthenticateAsync(loginUrl, callbackUrl);

            var accessToken = authenticationResult?.AccessToken;
            {
                textView.Text = $"Welcome Here: {accessToken}";

            }
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }


   
}