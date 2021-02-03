using Kimo.MwwmCross.Wpf.Starter.Services;

namespace UnitTestProject
{
    class MockServcie : IService
    {
        public string SayHello(string name)
        {
            return $"Hi {name}, This is hello From Mock";
        }
    }
}
