using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyAndHappy.Models.ModelsDTO
{
    public class CategoryDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<string> IdRecipe { get; set; }
    }
}
