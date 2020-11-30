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
            entity.Property(e => e.Meats).IsRequired();
            entity.Property(e => e.Vegetables).IsRequired();
            entity.Property(e => e.Fruits).IsRequired();
            entity.Property(e => e.Diaries).IsRequired();
            entity.Property(e => e.IdUser).IsRequired();
            entity.Property(e => e.Carbohydrates).IsRequired();
            entity.Property(e => e.DryGoods).IsRequired();
            entity.Property(e => e.Fats).IsRequired();
            entity.Property(e => e.Alcohols).IsRequired();
            entity.Property(e => e.Spices).IsRequired();
            entity.Property(e => e.Specials).IsRequired();
            entity.Property(e => e.FishAndSeafoods).IsRequired();
            entity.Property(e => e.Nuts).IsRequired();
            entity.Property(e => e.Drinks).IsRequired();
            entity.Property(e => e.Sauces).IsRequired();
        }
    }
}
