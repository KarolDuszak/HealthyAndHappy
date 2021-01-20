using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyAndHappy.Models
{
    public class ProductForRecipe : Product
    {
        public string RecipeId { get; set; }
        //?? circular reference
        public Recipe Recipe { get; set; }
    }
}
