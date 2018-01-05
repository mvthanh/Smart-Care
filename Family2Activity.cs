using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace login
{
    [Activity(Label = "Family2Activity")]
    public class Family2Activity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.call2);
            ImageView buttonBack = FindViewById<ImageView>(Resource.Id.ButtonBackcall2);
            buttonBack.Click += ButtonLogin_Click;
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(LoginActivity));
        }
    }
}