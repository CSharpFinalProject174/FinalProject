using FoodRecipeBuilder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodRecipeBuilder.DataObjects
{
    // Create the interface for Mock recipes
    public interface IRecipeMock
    {
        IEnumerable<RecipeModel> GetRecipes();
        RecipeModel GetRecipeById(int id);
    }
}
