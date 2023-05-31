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
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData
                (
                 new Category { Id = 1, Name = "Siyah Zeytin" },
                 new Category { Id = 2, Name = "Yeşil  Zeytin" },
                 new Category { Id = 3, Name = "Zeytin Yağı" }
                );
        }
    }
}
