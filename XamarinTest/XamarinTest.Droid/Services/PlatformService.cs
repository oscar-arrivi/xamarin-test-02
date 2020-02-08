using Android.App;
using Android.Content;
using Android.Views.InputMethods;
using MvvmCross;
using MvvmCross.Platforms.Android;
using XamarinTest.Core.Services;

namespace XamarinTest.Droid.Services
{
    public class PlatformService : IPlatformAction
    {
        protected Activity CurrentActivity =>
            Mvx.IoCProvider.Resolve<IMvxAndroidCurrentTopActivity>().Activity;

        public void DismissKeyboard()
        {
            var currentFocus = CurrentActivity.CurrentFocus;
            if (currentFocus != null)
            {
                InputMethodManager inputMethodManager = (InputMethodManager)CurrentActivity
                                                        .GetSystemService(Context.InputMethodService);

                inputMethodManager.HideSoftInputFromWindow(currentFocus.WindowToken, HideSoftInputFlags.None);
            }
        }

    }
}
