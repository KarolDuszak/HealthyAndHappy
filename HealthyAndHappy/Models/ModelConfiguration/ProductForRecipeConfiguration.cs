using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyAndHappy.Models.ModelConfiguration
{
    public class ProductForRecipeConfiguration : IEntityTypeConfiguration<ProductForRecipe>
    {
        public void Configure(EntityTypeBuilder<ProductForRecipe> entity)
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired();
            entity.Property(e => e.Amount).IsRequired();
            entity.Property(e => e.Kcal).IsRequired();
            entity.Property(e => e.IdUser).IsRequired();
            entity.Property(e => e.Portion).IsRequired();
            entity.Property(e => e.PortionSize).IsRequired();
            entity.Property(e => e.IsAccepted).IsRequired();
            entity.Property(e => e.Chain).IsRequired();
            entity.Property(e => e.Carbohydrates).IsRequired();
            entity.Property(e => e.Fat).IsRequired();
            entity.Property(e => e.Proteins).IsRequired();
            entity.HasOne<Recipe>(a => a.Recipe).WithMany(b => b.Products).HasForeignKey(b => b.RecipeId);
        }
    }
}
