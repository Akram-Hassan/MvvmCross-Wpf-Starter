namespace Kimo.MwwmCross.Wpf.Starter.Services
{
    public class Service : IService
    {
        public string SayHello(string name)
        {
            return $"Hello: {name}";
        }
    }
}