using Chromely.Core;

namespace ChromelyActions
{
    class Program
    {
        static void Main(string[] args)
        {
            // basic example of the application builder
            AppBuilder
            .Create()
            .UseApp<MyChromelyApp>()
            .Build()
            .Run(args);
        }
    }
}
