using Autofac;
using QE_Intern_Technical_Assignment.Data;
using QE_Intern_Technical_Assignment.Services;

namespace QE_Intern_Technical_Assignment.Configuration
{
    public class IoCSetup
    {
        public static IContainer Configure()
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterType<SortingService>().As<ISortingService>();
            containerBuilder.RegisterType<DataRepository>().As<IDataRepository>();
            return containerBuilder.Build();
        }
    }

}
