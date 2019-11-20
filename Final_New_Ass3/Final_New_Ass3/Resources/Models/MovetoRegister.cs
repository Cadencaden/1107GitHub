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
using Android.Support.V7.App;

namespace Final_New_Ass3.Resources.Models
{
    [Activity(Label = "MovetoRegister")]
    public class MovetoRegister : Activity
    {
        Button regi;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

           
            // Create your application here
        }
        private void btnregi_clicked(object sender, EventArgs e)
        {
             SetContentView(Resource.Layout.Register);
        }
    }
}