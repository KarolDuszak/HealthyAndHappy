using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyAndHappy.Models.ModelConfiguration
{
    public class HistoryConfiguration: IEntityTypeConfiguration<History>
    {
        public void Configure(EntityTypeBuilder<History> entity)
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Recipe).IsRequired();
            entity.Property(e => e.Date).IsRequired();
            entity.Property(e => e.Kcal).IsRequired();

        }
    }
}
