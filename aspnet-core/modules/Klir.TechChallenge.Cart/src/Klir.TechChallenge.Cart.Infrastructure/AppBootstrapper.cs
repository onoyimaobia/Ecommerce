using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Klir.TechChallenge.Cart.Infrastructure
{
    public static class AppBootstrapper
    {
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
