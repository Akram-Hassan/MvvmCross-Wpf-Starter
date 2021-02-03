using Kimo.MwwmCross.Wpf.Starter.Core.ViewModels;
using Kimo.MwwmCross.Wpf.Starter.Services;
using MvvmCross;
using MvvmCross.ViewModels;

namespace Kimo.MwwmCross.Wpf.Starter.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            Mvx.IoCProvider.RegisterType<IService, Service>();

            RegisterAppStart<Page1ViewModel>();
        }
    }
}
