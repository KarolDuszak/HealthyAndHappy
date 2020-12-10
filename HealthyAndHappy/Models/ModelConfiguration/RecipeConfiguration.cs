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
            entity.Property(e => e.IsAccepted).IsRequired();
            entity.Property(e => e.Category).IsRequired();
            entity.Property(e => e.Macro).IsRequired();
            entity.Property(e => e.imageByteArray);
            entity.HasOne<ApplicationUser>(e => e.Maker);
            entity.HasMany(e => e.Alcohols);
            entity.HasMany(e => e.Carbohydrates);
            entity.HasMany(e => e.Diaries);
            entity.HasMany(e => e.Drinks);
            entity.HasMany(e => e.DryGoods);
            entity.HasMany(e => e.Fats);
            entity.HasMany(e => e.FishAndSeafoods);
            entity.HasMany(e => e.Fruits);
            entity.HasMany(e => e.Meats);
            entity.HasMany(e => e.Nuts);
            entity.HasMany(e => e.Sauces);
            entity.HasMany(e => e.Specials);
            entity.HasMany(e => e.Spices);
            entity.HasMany(e => e.Vegetables);

        }
    }
}
