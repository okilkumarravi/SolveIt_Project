using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System.IO;

namespace SolveIt
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = Host.CreateDefaultBuilder(args)
                            .UseServiceProviderFactory(new AutofacServiceProviderFactory())
                            .ConfigureWebHostDefaults(webHostBuilder => {
                                webHostBuilder
                                      .UseStartup<Startup>();
                            }).Build();

            host.Run();
        }
    }
}
