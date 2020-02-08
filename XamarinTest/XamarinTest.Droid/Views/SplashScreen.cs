using Android.App;
using Android.Content.PM;
using MvvmCross.Platforms.Android.Views;

namespace XamarinTest.Droid.Views
{
    [Activity(
        Label = "Xamarin Test",
        MainLauncher = true,
        Theme = "@style/SplashTheme",
        NoHistory = true,
        ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen() : base(Resource.Layout.Splash_screen)
        {
        }
    }


}
