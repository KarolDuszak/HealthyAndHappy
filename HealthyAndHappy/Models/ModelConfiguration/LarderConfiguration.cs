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
            entity.HasMany(e => e.Alcohols).WithOne().HasForeignKey(k => k.Id).OnDelete(DeleteBehavior.Cascade);
            entity.HasMany(e => e.BreadsAndNoodles).WithOne().HasForeignKey(k => k.Id).OnDelete(DeleteBehavior.Cascade);
            entity.HasMany(e => e.Diaries).WithOne().HasForeignKey(k => k.Id).OnDelete(DeleteBehavior.Cascade);
            entity.HasMany(e => e.Drinks).WithOne().HasForeignKey(k => k.Id).OnDelete(DeleteBehavior.Cascade);
            entity.HasMany(e => e.DryGoods).WithOne().HasForeignKey(k => k.Id).OnDelete(DeleteBehavior.Cascade);
            entity.HasMany(e => e.OilsAndFats).WithOne().HasForeignKey(k => k.Id).OnDelete(DeleteBehavior.Cascade);
            entity.HasMany(e => e.FishAndSeafoods).WithOne().HasForeignKey(k => k.Id).OnDelete(DeleteBehavior.Cascade);
            entity.HasMany(e => e.Fruits).WithOne().HasForeignKey(k => k.Id).OnDelete(DeleteBehavior.Cascade);
            entity.HasMany(e => e.Meats).WithOne().HasForeignKey(k => k.Id).OnDelete(DeleteBehavior.Cascade);
            entity.HasMany(e => e.Nuts).WithOne().HasForeignKey(k => k.Id).OnDelete(DeleteBehavior.Cascade);
            entity.HasMany(e => e.Sauces).WithOne().HasForeignKey(k => k.Id).OnDelete(DeleteBehavior.Cascade);
            entity.HasMany(e => e.Specials).WithOne().HasForeignKey(k => k.Id).OnDelete(DeleteBehavior.Cascade);
            entity.HasMany(e => e.Spices).WithOne().HasForeignKey(k => k.Id).OnDelete(DeleteBehavior.Cascade);
            entity.HasMany(e => e.Vegetables).WithOne().HasForeignKey(k => k.Id).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
