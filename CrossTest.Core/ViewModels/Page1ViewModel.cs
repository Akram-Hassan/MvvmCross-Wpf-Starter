using MvvmCross;
using MvvmCross.ViewModels;
using MvvmCross.Navigation;
using MvvmCross.Commands;

namespace Kimo.MwwmCross.Wpf.Starter.Core.ViewModels
{
    public class Page1ViewModel: MvxViewModel
    {
        private MvxCommand command;

        public Page1ViewModel()
        {

            command = new MvxCommand(() => {
                Mvx.IoCProvider.Resolve<IMvxNavigationService>().Navigate<Page2ViewModel>();
                ;
            });
        }

        public string PageName { get; set; } = "Page 1";

        public IMvxCommand GoToPage1Command => this.command;
    }
}
