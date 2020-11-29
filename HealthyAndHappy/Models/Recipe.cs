using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyAndHappy.Models
{

    //Categories enum contain information about assigment to cattegory
    //for example number 5 means that meal will contain all and under500Kcal categorry
    [Flags]
    public enum Categories
    {
        None = 0b_0000_0000,            //0
        All = 0b_0000_0001,             //1
        Under200Kcal = 0b_0000_0010,    //2
        Under500Kcal = 0b_0000_0100,    //4
        More500Kcal = 0b_0000_1000,     //8
        NoMeat = 0b_0001_0000,          //16
        HighProtein = 0b_0010_0000,     //32
    }
    public class Recipe
    {
        public string Id { get; set; }
        public int PreprationTime { get; set; }
        public string Name { get; set; }
        public int Kcal { get; set; }
        public bool IsAccepted { get; set; }
        public string IdUser { get; set; }
        public string Description { get; set; }
        public Categories Category { get; set; }
        public Macro Macro { get; set; }
        public List<Meat> Meats { get; set; }
        public List<Vegetable> Vegetables { get; set; }
        public List<Fruit> Fruits { get; set; }
        public List<Diary> Diaries { get; set; }
        public List<Carbohydrate> Carbohydrates { get; set; }
        public List<DryGood> DryGoods { get; set; }
        public List <Fat> Fats { get; set; }
        public List <Alcohol> Alcohols { get; set; }
        public List <Spice> Spices { get; set; }
        public List <FishAndSeafood> FishAndSeafoods { get; set; }
        public List <Nut> Nuts { get; set; }
        public List <Drink> Drinks { get; set; }
        public List <Sauce> Sauces { get; set; }
        public List <Special> Specials { get; set; }

    }
}
