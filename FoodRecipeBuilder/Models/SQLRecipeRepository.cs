using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodRecipeBuilder.Models
{
    public class SQLRecipeRepository : IRecipeRepository
    {
        private readonly RecipeContext context;

        public SQLRecipeRepository(RecipeContext context)
        {
            this.context = context;
        }

        public RecipeModel Add(RecipeModel recipe)
        {
            context.RecipeModels.Add(recipe);
            context.SaveChanges();
            return recipe;
        }

        public RecipeModel Delete(int id)
        {
            RecipeModel recipe = context.RecipeModels.Find(id);
            if (recipe != null)
            {
                context.RecipeModels.Remove(recipe);
            }
            return recipe;
        }

        public IEnumerable<RecipeModel> GetAllRecipes()
        {
            return context.RecipeModels;
        }

        public RecipeModel Get(int id)
        {
            return context.RecipeModels.Find(id);
        }

        public RecipeModel Update(RecipeModel recipeChanges)
        {
            var recipe = context.RecipeModels.Attach(recipeChanges);
            recipe.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return recipeChanges;
        }
    }
}
