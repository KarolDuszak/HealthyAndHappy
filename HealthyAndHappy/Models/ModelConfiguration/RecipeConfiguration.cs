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
            entity.HasMany(e => e.Alcohols).WithOne();
            entity.HasMany(e => e.Carbohydrates).WithOne();
            entity.HasMany(e => e.Diaries).WithOne();
            entity.HasMany(e => e.Drinks).WithOne();
            entity.HasMany(e => e.DryGoods).WithOne();
            entity.HasMany(e => e.Fats).WithOne();
            entity.HasMany(e => e.FishAndSeafoods).WithOne();
            entity.HasMany(e => e.Fruits).WithOne();
            entity.HasMany(e => e.Meats).WithOne();
            entity.HasMany(e => e.Nuts).WithOne();
            entity.HasMany(e => e.Sauces).WithOne();
            entity.HasMany(e => e.Specials).WithOne();
            entity.HasMany(e => e.Spices).WithOne();
            entity.HasMany(e => e.Vegetables).WithOne();

        }
    }
}
