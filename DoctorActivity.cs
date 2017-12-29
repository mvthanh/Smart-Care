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
    [Activity(Label = "DoctorActivity")]
    public class DoctorActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.doctor);

            ImageView buttonBack = FindViewById<ImageView>(Resource.Id.ButtonBackdoctor);
            buttonBack.Click += ButtonLogin_Click;
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(LoginActivity));
        }
    }
}