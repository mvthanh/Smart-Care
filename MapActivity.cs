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
    [Activity(Label = "MapActivity")]
    public class MapActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.map);
            ImageView buttonBack = FindViewById<ImageView>(Resource.Id.ButtonBackmap);
            buttonBack.Click += ButtonBack_Click;
        }
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(AddActivity));
        }
    }
}