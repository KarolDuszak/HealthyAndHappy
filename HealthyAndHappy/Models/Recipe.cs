﻿using System;
using System.Collections.Generic;
using System.IO;
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
        public ApplicationUser Maker { get; set; }
        public string Description { get; set; }
        public Categories Category { get; set; }
        public int Fat { get; set; }
        public int Carbohydrates { get; set; }
        public int Proteins { get; set; }
        public byte[] imageByteArray { get; set; }
        //?? circular reference
        public List<ProductForRecipe> Products { get; set; }

    }
}
