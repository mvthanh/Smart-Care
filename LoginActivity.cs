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
    [Activity(Label = "LoginActivity")]
    public class LoginActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.menu);

            ImageView beat = FindViewById<ImageView>(Resource.Id.beat);
            beat.Click += Beat_Click;
            ImageView doctor = FindViewById<ImageView>(Resource.Id.doctor);
            doctor.Click += Doctor_Click;
            ImageView pressure = FindViewById<ImageView>(Resource.Id.blood);
            pressure.Click += Pressure_Click;
            ImageView family1 = FindViewById<ImageView>(Resource.Id.family1);
            family1.Click += Family1_Click;
            ImageView family2 = FindViewById<ImageView>(Resource.Id.family2);
            family2.Click += Family2_Click;
            ImageView tempera = FindViewById<ImageView>(Resource.Id.tempera);
            tempera.Click += Temperature_Click;
            ImageView buttonAdd = FindViewById<ImageView>(Resource.Id.add);
            buttonAdd.Click += buttonAdd_Click;

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(AddActivity));
        }

        private void Beat_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(HeartBeatActivity));
            
        }
        private void Doctor_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(DoctorActivity));
        }
        private void Pressure_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(BloodPressureActivity));
            
        }
        
        private void Family1_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(Family1Activity));
            
        }
        private void Family2_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(Family2Activity));
            
        }
        private void Temperature_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(TemperatureActivity));
           
        }
        private void ButtonLogin_Click(object sender, EventArgs e)
        {

            StartActivity(typeof(LoginActivity));
        }
    }
}