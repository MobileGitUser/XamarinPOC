using Android.App;
using Android.Content.PM;
using Android.OS;
using MvvmCross.Forms.Platforms.Android.Views;
using MvvmCross.ViewModels;
using XamarinPOC.ViewModels;

namespace XamarinPOC.Droid
{
    [Activity(Label = "Xamarin.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : MvxFormsAppCompatActivity
    {
        
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);


            var startup = MvvmCross.Mvx.Resolve<IMvxAppStart>();
            startup.Start();
            InitializeForms(bundle);
        }

        public override void OnBackPressed()
        {
            base.OnBackPressed();
        }
    }
}

