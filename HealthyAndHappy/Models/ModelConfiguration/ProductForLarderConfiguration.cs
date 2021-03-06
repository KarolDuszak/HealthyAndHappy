﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyAndHappy.Models.ModelConfiguration
{
    public class ProductForLarderConfiguration : IEntityTypeConfiguration<ProductForLarder>
    {
        public void Configure(EntityTypeBuilder<ProductForLarder> entity)
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
            entity.HasOne<Larder>(a => a.Larder).WithMany(b => b.Products).HasForeignKey(b => b.LarderId);
        }
    }
}
