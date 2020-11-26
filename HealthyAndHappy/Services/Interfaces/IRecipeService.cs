using HealthyAndHappy.Models;
using HealthyAndHappy.Models.ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyAndHappy.Services.Interfaces
{
    public interface IRecipeService
    {
        RecipesDTO GetAllRecipes();
        RecipesDTO GetRecipesForCategory(CategoryDTO category);
        RecipeDTO GetRecipeDetail(RecipeDTO recipe);
        ResponseDTO  AddRecipe(RecipeDTO recipe);
        ResponseDTO ReportRecipe(RecipeDTO recipe);
        
    }
}
