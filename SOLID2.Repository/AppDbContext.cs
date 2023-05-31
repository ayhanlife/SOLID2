using Microsoft.EntityFrameworkCore;
using SOLID2.Core.Entity;
using System.Reflection;

namespace SOLID2.Repository
{
    public class AppDbContext : DbContext
    {
        //DbContextOptions startup tarafondan vericem için burdakı custr.
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductFeature> ProductFeatures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());




            modelBuilder.Entity<ProductFeature>().HasData(new ProductFeature()
            {
                Id = 1,
                Color = "Kırmızı",
                Height = 50,
                Width = 50,
                ProductId = 1
            },
            new ProductFeature()
            {
                Id = 2,
                Color = "Yeşil",
                Height = 50,
                Width = 50,
                ProductId = 2
            }

            );
        }

    }
}