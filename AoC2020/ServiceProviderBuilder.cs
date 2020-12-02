using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace AoC2020
{
    public static class ServiceProviderBuilder
    {
        public static IServiceProvider GetServiceProvider()
        {
            var configuration = new ConfigurationBuilder()
                .AddUserSecrets<Program>()
                .Build();

            var services = new ServiceCollection();
            services.Configure<CookieSettings>(configuration.GetSection("Cookies"));

            return services.BuildServiceProvider();
        }
    }
}
