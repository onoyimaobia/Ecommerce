using System.Reflection;
using System.Threading.Tasks;
using Klir.TechChallenge.Cart.Infrastructure;
using Klir.TechChallenge.Cart.Infrastructure.DatContext;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace Klir.TechChallenge.Cart.Web.Api
{

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            AppBootstrapper.InitServices(services);
            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });
            services.AddDistributedMemoryCache();
            services.AddDbContext<CartContext>(options =>
                                                 options.UseSqlServer(Configuration.GetConnectionString("Default"), b => b.MigrationsAssembly("Klir.TechChallenge.Cart.Infrastructure")));
            services.AddMediatR(Assembly.GetExecutingAssembly(), typeof(AppBootstrapper).Assembly);
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Klir.TechChallenge.Cart.Web.Api", Version = "v1" });
            });
            services.AddHttpClient();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Klir.TechChallenge.Cart.Web.Api v1"));
            }

            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
