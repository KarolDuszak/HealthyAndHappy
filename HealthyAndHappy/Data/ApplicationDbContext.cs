using HealthyAndHappy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using HealthyAndHappy.Models.ModelConfiguration;

namespace HealthyAndHappy.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
            { }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Larder> Larder { get; set; }
        public DbSet<Recipe> Recipe { get; set; }
        public DbSet<Message> Message { get; set; }
        public DbSet<History> History { get; set; }      
        public DbSet<ProductForLarder> ProductsForLarder { get; set; }
        public DbSet<ProductForRecipe> ProductsForRecipe { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ApplicationUserConfiguration());
            builder.ApplyConfiguration(new HistoryConfiguration());
            builder.ApplyConfiguration(new LarderConfiguration());
            builder.ApplyConfiguration(new MessageConfiguration());
            builder.ApplyConfiguration(new RecipeConfiguration());
            builder.ApplyConfiguration(new ProductForLarderConfiguration());
            builder.ApplyConfiguration(new ProductForRecipeConfiguration());

            base.OnModelCreating(builder);
        }
    }
}
