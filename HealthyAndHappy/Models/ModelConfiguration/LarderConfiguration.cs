using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyAndHappy.Models.ModelConfiguration
{
    public class LarderConfiguration: IEntityTypeConfiguration<Larder>
    {
        public void Configure(EntityTypeBuilder<Larder> entity)
        {
            entity.HasKey(e => e.Id);
            entity.HasOne<ApplicationUser>(e => e.User).WithOne();
            entity.HasMany(e => e.Alcohols).WithOne();
            entity.HasMany(e => e.BreadsAndNoodles).WithOne();
            entity.HasMany(e => e.Diaries).WithOne();
            entity.HasMany(e => e.Drinks).WithOne();
            entity.HasMany(e => e.DryGoods).WithOne();
            entity.HasMany(e => e.OilsAndFats).WithOne();
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
