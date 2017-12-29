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
    [Activity(Label = "AddActivity")]
    public class AddActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.task);

            TextView buttonBack = FindViewById<TextView>(Resource.Id.ButtonBacktask);
            buttonBack.Click += ButtonLogin_Click;

            LinearLayout map = FindViewById<LinearLayout>(Resource.Id.map);
            map.Click += Map_Click;

            LinearLayout remind = FindViewById<LinearLayout>(Resource.Id.remind);
            remind.Click += Remind_Click;

            LinearLayout note = FindViewById<LinearLayout>(Resource.Id.note);
            note.Click += Note_Click;

            LinearLayout history = FindViewById<LinearLayout>(Resource.Id.history);
            history.Click += History_Click;

            LinearLayout guild = FindViewById<LinearLayout>(Resource.Id.guild);
            guild.Click += Guild_Click;

            LinearLayout setting = FindViewById<LinearLayout>(Resource.Id.setting);
            setting.Click += Setting_Click;

            LinearLayout logout = FindViewById<LinearLayout>(Resource.Id.logout);
            logout.Click += Logout_Click;
        }
        private void Setting_Click(object sender, EventArgs e)
        {
            SetContentView(Resource.Layout.setting);
            ImageView buttonBack = FindViewById<ImageView>(Resource.Id.ButtonBacksetting);
            buttonBack.Click += ButtonLogin_Click;
        }
        private void Logout_Click(object sender, EventArgs e)
        {
            SetContentView(Resource.Layout.login);

            Button buttonLogin = FindViewById<Button>(Resource.Id.button1);
            buttonLogin.Click += ButtonLogin_Click;

        }
        private void Guild_Click(object sender, EventArgs e)
        {
            SetContentView(Resource.Layout.guild);
            ImageView buttonBack = FindViewById<ImageView>(Resource.Id.ButtonBackguild);
            buttonBack.Click += ButtonLogin_Click;
        }
        private void History_Click(object sender, EventArgs e)
        {
            SetContentView(Resource.Layout.history);
            ImageView buttonBack = FindViewById<ImageView>(Resource.Id.ButtonBackhistory);
            buttonBack.Click += ButtonLogin_Click;
        }

       

        private void Note_Click(object sender, EventArgs e)
        {
            SetContentView(Resource.Layout.note);
            ImageView buttonBack = FindViewById<ImageView>(Resource.Id.ButtonBacknote);
            buttonBack.Click += ButtonLogin_Click;
        }
        private void Map_Click(object sender, EventArgs e)
        {
            SetContentView(Resource.Layout.map);
            ImageView buttonBack = FindViewById<ImageView>(Resource.Id.ButtonBackmap);
            buttonBack.Click += ButtonLogin_Click;
        }
        private void Remind_Click(object sender, EventArgs e)
        {
            SetContentView(Resource.Layout.remind);
            ImageView buttonBack = FindViewById<ImageView>(Resource.Id.ButtonBackremind);
            buttonBack.Click += ButtonLogin_Click;
        }
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(LoginActivity));
        }

    }
    
}