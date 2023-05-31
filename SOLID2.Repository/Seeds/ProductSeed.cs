using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SOLID2.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID2.Repository.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData
                (
                 new Product
                 {
                     Id = 1,
                     Name = "Taş Baskı Siyah Zeytin",
                     CategoryId = 1,
                     Price = 250,
                     Stock = 999,
                 },
                 new Product
                 {
                     Id = 2,
                     Name = "Edremit Yeşil  Zeytin",
                     CategoryId = 2,
                     Price = 250,
                     Stock = 999,
                 },
                 new Product
                 {
                     Id = 3,
                     Name = "Taş Bask Zeytin Yağı",
                     CategoryId = 3,
                     Price = 250,
                     Stock = 999,
                 }
                );
        }
    }
}
