using Autofac;
using MockServer.Implementations;
using MockServer.Interfaces;
using Serilog;
using System;

namespace MockServer
{
    internal static class Program
    {
        private static IContainer _container;

        private static void CreateMenu()
        {
            var appInfo = _container.Resolve<IAppInfo>();

            Console.WriteLine($"MockServer v{appInfo.GetAppVersion()}");
            Console.WriteLine("Commands:");
            Console.WriteLine("  'start': Start mock server");
            Console.WriteLine("  'stop' : Stop mock server");
            Console.WriteLine("  'close': Close application");
        }

        private static void Main(string[] args)
        {
            LoggerFactory.CreateLogger();

            Log.Debug("Application started");

            _container = ContainerFactory.BuildIoCContainer();

            CreateMenu();

            var server = _container.Resolve<IServer>();
            while (true)
            {
                Console.Write("/> ");
                string command = Console.ReadLine();
                switch (command.ToLower())
                {
                    case "start":
                        server.StartServer();
                        break;

                    case "stop":
                        server.StopServer();
                        break;

                    case "close":
                        Log.Debug("Application closed");
                        return;
                }
            }
        }
    }
}