using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Rest_A_Go.Services;
using Xamarin.Forms;

namespace Rest_A_Go
{
    public class RegisterViewModel
    {
        APIServices _apiServices = new APIServices();

        public string Email { get; set; }
        public string Password { get; set; }
        
        public ICommand RegisterCommand
        {
            get
            {
                return new Command(() =>
               {
                   
               });
            }
        }
    }
}