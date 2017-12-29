
using Android.App;
using Android.Widget;
using Android.OS;
using System;




namespace login
{
    [Activity(Label = "S software", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private void ButtonLogin_Click(object sender, EventArgs e) {
            
            StartActivity(typeof(LoginActivity));
        }
        
       
       

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.login);
            
            Button buttonLogin = FindViewById<Button>(Resource.Id.button1);
            buttonLogin.Click += ButtonLogin_Click;
        }
    }
}

