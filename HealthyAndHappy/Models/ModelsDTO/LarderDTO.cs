﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyAndHappy.Models.ModelsDTO
{
    public class LarderDTO
    {
        public string Id { get; set; }
        public List<Meat> Meats { get; set; }
        public List<Vegetable> Vegetables { get; set; }
        public List<Fruit> Fruits { get; set; }
        public List<Diary> Diaries { get; set; }
        public List<Carbohydrate> Carbohydrates { get; set; }
        public List<DryGood> DryGoods { get; set; }
        public List<Fat> Fats { get; set; }
        public List<Alcohol> Alcohols { get; set; }
        public List<Spice> Spices { get; set; }
        public List<FishAndSeafood> FishAndSeafoods { get; set; }
        public List<Nut> Nuts { get; set; }
        public List<Drink> Drinks { get; set; }
        public List<Sauce> Sauces { get; set; }
        public List<Special> Specials { get; set; }
    }
}
