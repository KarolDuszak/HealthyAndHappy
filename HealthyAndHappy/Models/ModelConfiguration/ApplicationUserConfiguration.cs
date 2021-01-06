using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthyAndHappy.Models;

namespace HealthyAndHappy.Models.ModelConfiguration
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> entity)
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.UserName).IsRequired();
            entity.Property(e => e.Email).IsRequired();
            entity.Property(e => e.PasswordHash).IsRequired();
            entity.Property(e => e.IsAdmin).IsRequired();
            entity.HasMany(e => e.Histories).WithOne().HasForeignKey(k=>k.Id).OnDelete(DeleteBehavior.Cascade);
            entity.HasMany(e => e.FavouriteRecipes).WithOne().HasForeignKey(k => k.Id);
            entity.HasOne(e => e.Larder).WithOne(i=>i.User).HasForeignKey<Larder>(k=>k.Id);

        }
    }
}
