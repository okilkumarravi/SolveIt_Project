using Autofac;
using SolveIt.Dao;
using SolveIt.Service;

namespace SolveIt
{
    public class IocBuilder 
    {
        public static IContainer Build()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<AuthenticationService>().AsImplementedInterfaces();
            builder.RegisterType<AuthenticationDao>().AsImplementedInterfaces();

            return builder.Build();
        }
    }
}
