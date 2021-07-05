using Klir.TechChallenge.Product.Domain.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Product.Infrastructure.DataContext
{
    public class ProductDbContext : DbContext
    { 
        public ProductDbContext(DbContextOptions<ProductDbContext> options)
            : base(options)
        {

        }


        public DbSet<Domain.Models.Entity.Product> Products { get; set; }
        public DbSet<ProductPromo> ProductPromo { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            var connectionStrings = Environment.GetEnvironmentVariable("CONNECTION_STRING") ?? "Server=.;Database=KlirProduct;User Id=sa;Password=onoyimaobia;TrustServerCertificate=True;";
            builder.UseSqlServer(connectionStrings);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
        public async Task<bool> TrySaveChangesAsync(ILogger logger)
        {
            try
            {
                await SaveChangesAsync();

                return true;
            }
            catch (DbUpdateException e)
            {
                logger.LogError($"DB Update Exception Message >>>>> {e.Message}");
                logger.LogError($"DB Update Inner Exception Message >>>>> {e.InnerException?.Message}");
                return false;
            }
        }

    }
}
