using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyAndHappy.Models
{
    [Flags]
    public enum Category
    {
        None = 0,
        Alcohol = 1,
        BreadAndNoodle = 2,
        Diary = 3,
        Drink = 4,
        DryGood = 5,
        FishAndSeafood = 6,
        Fruit = 7,
        Meat = 8,
        Nut = 9,
        OilAndFat = 10,
        Sauce=11,
        Special=12,
        Spice=13,
        Vegetable=14

    }
    public class Product
    {
        public string Id { get; set; }
        public int Amount { get; set; }
        public int Kcal { get; set; }
        public int Portion { get; set; }
        public int Chain { get; set; } //Jednostka miary
        public bool IsAccepted { get; set; }
        public int PortionSize { get; set; }
        public string IdUser { get; set; }
        public string Name { get; set; }
        public int Fat { get; set; }
        public int Carbohydrates { get; set; }
        public int Proteins { get; set; }
        public Category Category { get; set; }

    }
}
