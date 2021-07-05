using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;

namespace Klir.TechChallenge.Order.Infrastructure
{
    /// <summary>
    ///  extracted class used for service resgistration
    /// </summary>
    public static class AppBootstrapper
    {
        /// <summary>
        /// register services
        /// </summary>
        /// <param name="services"></param>
        public static void InitServices(IServiceCollection services)
        {
            AutoInjectLayers(services);
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }


        private static void AutoInjectLayers(IServiceCollection serviceCollection)
        {
            serviceCollection.Scan(scan => scan.FromCallingAssembly().AddClasses(classes => classes
                    .Where(type => type.Name.EndsWith("Repository") || type.Name.EndsWith("Service")), false)
                .AsImplementedInterfaces()
                .WithScopedLifetime());

        }
    }
}
