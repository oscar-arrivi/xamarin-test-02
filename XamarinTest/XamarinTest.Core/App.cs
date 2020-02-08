using MvvmCross.ViewModels;
using XamarinTest.Core.ViewModels;

namespace XamarinTest.Core
{
    public class App: MvxApplication
    {
        public override void Initialize()
        {
            
            RegisterAppStart<MainViewModel>();
        }
    }
}
