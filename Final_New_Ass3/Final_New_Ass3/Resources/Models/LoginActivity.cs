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
using Xamarin.Forms;

namespace Final_New_Ass3.Resources
{
    [Activity(Label = "LoginActivity")]
    public class LoginActivity : Activity
    {
        TextView username, password;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_main);

            username = FindViewById<TextView>(Resource.Id.txtuser);
            password = FindViewById<TextView>(Resource.Id.txtpass);
        }
        private void btnlogin_clicked(object sender, EventArgs e)
        {
           
        }
    }
}