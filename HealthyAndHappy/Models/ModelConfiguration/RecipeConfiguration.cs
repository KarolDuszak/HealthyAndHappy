using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyAndHappy.Models.ModelConfiguration
{
    public class RecipeConfiguration : IEntityTypeConfiguration<Recipe>
    {
        public void Configure(EntityTypeBuilder<Recipe> entity)
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired();
            entity.Property(e=>e.PreprationTime).IsRequired();
            entity.Property(e => e.Kcal).IsRequired();
            entity.Property(e => e.Description).IsRequired();
            entity.Property(e => e.IdUser).IsRequired();
            entity.Property(e => e.Name).IsRequired();
            entity.Property(e => e.Name).IsRequired();

        }
    }
}
