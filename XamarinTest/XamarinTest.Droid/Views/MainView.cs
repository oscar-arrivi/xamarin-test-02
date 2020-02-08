
using Android.App;
using Android.OS;
using Com.Airbnb.Lottie;
using MvvmCross.Platforms.Android.Views;
using XamarinTest.Core.ViewModels;

namespace XamarinTest.Droid.Views
{
    [Activity(Label = "Xamarin Test", Theme = "@style/AppTheme")]
    public class MainView : MvxActivity<MainViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.MainView);
            LottieAnimationView animationView = FindViewById<LottieAnimationView>(Resource.Id.animation_view);
            animationView.SetAnimation("lottie-world.json");
            animationView.PlayAnimation();
            var input = new InputFormFragment
            {
                ViewModel = ViewModel
            };
            FragmentManager.BeginTransaction()
                           .Replace(Resource.Id.inputFragment,input)
                           .Commit();
           
        }
    }

}
