using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace My_first_app
{
    [Activity(Label = "My_first_app", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate {
            button.Text = string.Format("{0} clicks!", count++); };

            Button button2 = FindViewById<Button>(Resource.Id.mybutton2);
            var text = "Very looong click";
            button2.LongClick += delegate {
                button2.Text = text;
            };
            
        }
    }
}

