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
    public class ApplicationDbContext: IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
            { }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Larder> Larder { get; set; }
        public DbSet<Recipe> Recipe { get; set; }
        public DbSet<Message> Message { get; set; }
        public DbSet<History> History { get; set; }
        public DbSet<Meat> Meat { get; set; }
        public DbSet<FishAndSeafood> FishAndSeafood { get; set; }
        public DbSet<Spice> Spice { get; set; }
        public DbSet<Alcohol> Alcohol { get; set; }
        public DbSet<OilAndFat> OilAndFat { get; set; }
        public DbSet<Vegetable> Vegetable { get; set; }
        public DbSet<Fruit> Fruit { get; set; }
        public DbSet<Sauce> Sauce { get; set; }
        public DbSet<Diary> Diary { get; set; }
        public DbSet<DryGood> DryGood { get; set; }
        public DbSet<Drink> Drink { get; set; }
        public DbSet<Special> Special { get; set; }
        public DbSet<Nut> Nut { get; set; }
        public DbSet<BreadAndNoodle> breadAndNoodle { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ApplicationUserConfiguration());
            builder.ApplyConfiguration(new AlcoholConfiguration());
            builder.ApplyConfiguration(new BreadAndNoodleConfiguration());
            builder.ApplyConfiguration(new DiaryConfiguration());
            builder.ApplyConfiguration(new DrinkConfiguration());
            builder.ApplyConfiguration(new DryGoodConfiguration());
            builder.ApplyConfiguration(new FishAndSeafoodConfiguration());
            builder.ApplyConfiguration(new FruitConfiguration());
            builder.ApplyConfiguration(new HistoryConfiguration());
            builder.ApplyConfiguration(new LarderConfiguration());
            builder.ApplyConfiguration(new MeatConfiguration());
            builder.ApplyConfiguration(new MessageConfiguration());
            builder.ApplyConfiguration(new NutConfiguration());
            builder.ApplyConfiguration(new OilAndFatConfiguration());
            builder.ApplyConfiguration(new RecipeConfiguration());
            builder.ApplyConfiguration(new SauceConfiguration());
            builder.ApplyConfiguration(new SpecialConfiguration());
            builder.ApplyConfiguration(new SpiceConfiguration());
            builder.ApplyConfiguration(new VegetableConfiguration());
            base.OnModelCreating(builder);
        }
    }
}
