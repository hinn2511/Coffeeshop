using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Infrastructure.Persistence;

namespace CFSM
{
    public class Program
    {
        public static void Main()
        {
            var host = CreateHostBuilder();

            
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var coffeecontext = services.GetRequiredService<CoffeeContext>();
                SeedData.Initialize(coffeecontext);
            }

            host.Run();
        }

        private static IHost CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                        .ConfigureWebHostDefaults(builder =>
                        {
                            builder.UseStartup<Startup>();
                        })
                        .Build();
        }
    }
}
