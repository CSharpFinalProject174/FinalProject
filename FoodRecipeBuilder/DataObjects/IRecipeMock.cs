using FoodRecipeBuilder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodRecipeBuilder.DataObjects
{
    public interface IRecipeMock
    {
        IEnumerable<RecipeModel> GetRecipes();
        RecipeModel GetRecipeById(int id);
    }
}
