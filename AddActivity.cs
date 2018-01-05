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
            buttonBack.Click += ButtonBack_Click;

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
            StartActivity(typeof(SettingActivity));
           
        }
        private void Logout_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(LogoutActivity));
           
        }
        private void Guild_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(GuildActivity));
            
        }
        private void History_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(HistoryActivity));
           
        }
        
        private void Note_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(NoteActivity));
           
        }
        private void Map_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(MapActivity));
            
        }
        private void Remind_Click(object sender, EventArgs e)
           
        {
            StartActivity(typeof(RemindActivity));
        }
          
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(LoginActivity));
        }

    }
    
}