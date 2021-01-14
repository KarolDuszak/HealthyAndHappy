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
        }
    }
}
