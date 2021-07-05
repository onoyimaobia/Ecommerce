using Klir.TechChallenge.Cart.Domain.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System;

namespace Klir.TechChallenge.Cart.Infrastructure.DatContext
{
    public class CartContext: DbContext
    {
   
        public CartContext(DbContextOptions<CartContext> options)
            : base(options)
        {

        }


        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            var connectionStrings = Environment.GetEnvironmentVariable("CONNECTION_STRING") ?? "Server=.;Database=KlirCart;User Id=sa;Password=onoyimaobia;TrustServerCertificate=True;";
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
