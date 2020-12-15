using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyAndHappy.Models.ModelConfiguration
{
    public class VegetableConfiguration : IEntityTypeConfiguration<Vegetable>
    {
        public void Configure(EntityTypeBuilder<Vegetable> entity)
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
        }
    }
}
