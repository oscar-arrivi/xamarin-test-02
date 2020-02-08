using MvvmCross;
using MvvmCross.Platforms.Android.Core;
using MvvmCross.ViewModels;
using XamarinTest.Core;
using XamarinTest.Core.Services;
using XamarinTest.Droid.Services;

namespace XamarinTest.Droid
{
    public class Setup : MvxAndroidSetup<App>
    {

        public Setup() : base()
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new App();
        }

        protected override void InitializeFirstChance()
        {
            base.InitializeFirstChance();
            Mvx.IoCProvider.RegisterType<IPlatformAction, PlatformService>();
        }
    }

}
