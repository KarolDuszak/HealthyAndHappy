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
            entity.Property(e => e.Kcal);
            entity.Property(e => e.Description).IsRequired();
            entity.Property(e => e.IsAccepted).IsRequired();
            entity.Property(e => e.Category).IsRequired();
            entity.Property(e => e.imageByteArray);
            entity.Property(e => e.Carbohydrates);
            entity.Property(e => e.Fat);
            entity.Property(e => e.Proteins);
            entity.HasOne<ApplicationUser>(e => e.Maker).WithOne();
            entity.HasMany(e => e.Alcohols).WithOne().HasForeignKey(k=>k.Id);
            entity.HasMany(e => e.BreadsAndNoodles).WithOne().HasForeignKey(k => k.Id);
            entity.HasMany(e => e.Diaries).WithOne().HasForeignKey(k => k.Id);
            entity.HasMany(e => e.Drinks).WithOne().HasForeignKey(k => k.Id);
            entity.HasMany(e => e.DryGoods).WithOne().HasForeignKey(k => k.Id);
            entity.HasMany(e => e.OilsAndFats).WithOne().HasForeignKey(k => k.Id);
            entity.HasMany(e => e.FishAndSeafoods).WithOne().HasForeignKey(k => k.Id);
            entity.HasMany(e => e.Fruits).WithOne().HasForeignKey(k => k.Id);
            entity.HasMany(e => e.Meats).WithOne().HasForeignKey(k => k.Id);
            entity.HasMany(e => e.Nuts).WithOne().HasForeignKey(k => k.Id);
            entity.HasMany(e => e.Sauces).WithOne().HasForeignKey(k => k.Id);
            entity.HasMany(e => e.Specials).WithOne().HasForeignKey(k => k.Id);
            entity.HasMany(e => e.Spices).WithOne().HasForeignKey(k => k.Id);
            entity.HasMany(e => e.Vegetables).WithOne().HasForeignKey(k => k.Id);

        }
    }
}
