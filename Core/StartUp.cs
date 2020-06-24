using Autofac;
using Core.Common;

namespace Core
{
    public static class StartUp
    {
        public static IMainLoop Create()
        {
            var container = InitInjection();

            var app = container.Resolve<IMainLoop>();
            
            return app;
        }

        private static IContainer InitInjection()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MainLoop>().As<IMainLoop>();
            builder.RegisterType<Logger>().As<ILogger>();
            builder.RegisterType<Routine>().As<IRoutine>();
            var container = builder.Build();

            return container;
        }
    }
}