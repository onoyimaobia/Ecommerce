using Klir.TechChallenge.Web.Domain.Models.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Web.Infrastructure.DataContext
{
    public class AppDbContext: IdentityDbContext<Persona, Role, Guid>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
           : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionStrings = Environment.GetEnvironmentVariable("CONNECTION_STRING") ?? "Server=.;Database=klirUser;User Id=sa;Password=onoyimaobia;TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(connectionStrings);
        }
        public DbSet<ImageSlider> ImageSliders { get; set; }
       
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
