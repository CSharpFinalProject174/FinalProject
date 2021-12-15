using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodRecipeBuilder.Models
{
    public interface IRecipeRepository
    {
        public RecipeModel Add(RecipeModel recipe);
        public RecipeModel Delete(int id);
        public RecipeModel Get(int id);
        public RecipeModel Update(RecipeModel recipe);
        public IEnumerable<RecipeModel> GetAllRecipes();
    }
}
