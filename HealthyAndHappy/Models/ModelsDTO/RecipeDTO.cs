using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace HealthyAndHappy.Models.ModelsDTO
{
    public class RecipeDTO
    {
        public string Id { get; set; }
        public int PreprationTime { get; set; }
        public string Name { get; set; }
        public int Kcal { get; set; }
        public bool IsAccepted { get; set; }
        public string IdUser { get; set; }
        public string Description { get; set; }
        public Categories Category { get; set; }
        public int Fat { get; set; }
        public int Carbohydrates { get; set; }
        public int Proteins { get; set; }
        public byte[] imageByteArray { get; set; }
        public List<ProductForRecipe> Products { get; set; }

    }
}
