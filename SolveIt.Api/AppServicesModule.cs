using Autofac;
using SolveIt.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolveIt
{
    public class AppServicesModule : Module
    {
        private readonly IContainer _container;
        public AppServicesModule(IContainer container)
        {
            _container = container;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new AppDataAccessModule(_container));

            builder.RegisterType<AuthenticationService>().AsImplementedInterfaces();
        }

        public static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();

            return builder.Build();
        }
    }
}
