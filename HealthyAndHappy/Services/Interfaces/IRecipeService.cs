using HealthyAndHappy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyAndHappy.Services.Interfaces
{
    public interface IRecipeService
    {
        List<Recipe> GetAllRecipes();
        List<Recipe> GetRecipesForCategory(Category catregory);
        Recipe GetRecipeDetail(string Id);
        bool AddRecipe();
        
    }
}
