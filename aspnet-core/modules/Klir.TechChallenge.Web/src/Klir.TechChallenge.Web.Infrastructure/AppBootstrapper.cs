using Klir.TechChallenge.Web.Domain.Models;
using Klir.TechChallenge.Web.Domain.Models.Entity;
using Klir.TechChallenge.Web.Infrastructure.DataContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Web.Infrastructure
{
    public static class AppBootstrapper
    {
        public static void InitServices(IServiceCollection services)
        {
            AutoInjectLayers(services);
            services.AddIdentity<Persona, Role>().AddEntityFrameworkStores<AppDbContext>();
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            ConfigureIdentity(services);
        }


        private static void AutoInjectLayers(IServiceCollection serviceCollection)
        {
            serviceCollection.Scan(scan => scan.FromCallingAssembly().AddClasses(classes => classes
                    .Where(type => type.Name.EndsWith("Repository") || type.Name.EndsWith("Service")), false)
                .AsImplementedInterfaces()
                .WithScopedLifetime());

        }
        private static void ConfigureIdentity(IServiceCollection services)
        {
            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 6;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
                options.Password.RequiredUniqueChars = 0;
                options.User.AllowedUserNameCharacters += "/";
                options.Lockout.AllowedForNewUsers = false;
                options.User.RequireUniqueEmail = true;
            });
        }
    }
}
