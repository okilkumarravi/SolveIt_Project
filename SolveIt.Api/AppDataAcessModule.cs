using Autofac;
using SolveIt.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolveIt
{
    public class AppDataAccessModule : Module
    {
        private readonly IContainer _container;

        public AppDataAccessModule(IContainer container)
        {
            _container = container;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AuthenticationDao>().AsImplementedInterfaces();

        }
    }
}
