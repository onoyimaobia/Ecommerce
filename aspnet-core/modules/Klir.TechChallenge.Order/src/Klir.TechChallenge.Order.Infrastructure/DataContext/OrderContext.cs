using Klir.TechChallenge.Order.Domain.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace Klir.TechChallenge.Order.Infrastructure.DataContext
{
    /// <summary>
    /// db context
    /// </summary>
    public class OrderContext: DbContext
    {


        public OrderContext(DbContextOptions<OrderContext> options)
            : base(options)
        {

        }


        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            var connectionStrings = Environment.GetEnvironmentVariable("CONNECTION_STRING") ?? "Server=.;Database=KlirOrder;User Id=sa;Password=onoyimaobia;TrustServerCertificate=True;";
            builder.UseSqlServer(connectionStrings);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }


    }
}
