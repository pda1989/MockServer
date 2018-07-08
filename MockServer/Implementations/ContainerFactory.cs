using Autofac;

namespace MockServer.Implementations
{
    public static class ContainerFactory
    {
        public static IContainer BuildIoCContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<AppInfo>().AsImplementedInterfaces().SingleInstance();
            builder.RegisterType<MockWebServer>().AsImplementedInterfaces().SingleInstance();
            return builder.Build();
        }
    }
}