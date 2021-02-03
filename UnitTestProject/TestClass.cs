using Kimo.MwwmCross.Wpf.Starter.Core.ViewModels;
using Kimo.MwwmCross.Wpf.Starter.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MvvmCross.Base;
using MvvmCross.Core;
using MvvmCross.Navigation;
using MvvmCross.Tests;
using MvvmCross.ViewModels;
using MvvmCross.Views;

namespace UnitTestProject
{

    [TestClass]
    public class TestClass : MvxIoCSupportingTest
    {
        protected MockDispatcher MockDispatcher
        {
            get;
            private set;
        }

        protected IMvxNavigationService MockNavService
        {
            get;
            private set;
        }

        protected override void AdditionalSetup()
        {
            MockServcie theMock = new MockServcie();
            Ioc.RegisterSingleton<IService>(theMock);

            // for navigation
            MockDispatcher = new MockDispatcher();
            Ioc.RegisterSingleton<IMvxViewDispatcher>(MockDispatcher);
            Ioc.RegisterSingleton<IMvxMainThreadDispatcher>(MockDispatcher);

            // for navigation parsing
            Ioc.RegisterSingleton<IMvxStringToTypeParser>(new MvxStringToTypeParser());
        }

        [TestMethod]
        public void TestServices()
        {
            base.Setup();
            var message = Ioc.Resolve<IService>().SayHello("Koki");
            Assert.AreEqual("Hi Koki, This is hello From Mock", message);
        }
    }
}