using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace Rest_A_Go
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button login, regi;
        EditText Username, Password;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);

            SetContentView(Resource.Layout.activity_main);

            login = FindViewById<Button>(Resource.Id.btnlogin);
            regi = FindViewById<Button>(Resource.Id.btnregi);
            Username = FindViewById<EditText>(Resource.Id.txtuser);
            Password = FindViewById<EditText>(Resource.Id.txtpass);

            regi.Click += (Sender, e) =>
            {
                Intent regipage = new Intent(this, typeof(RegiActivity));

                StartActivity(regipage);
            };

            login.Click += (Sender, e) =>
            {
               
            };
        }
    }
}