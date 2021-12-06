using FoodRecipeBuilder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodRecipeBuilder.DataObjects
{
    // Implement the interface for the the recipe objects
    public class RecipeMock : IRecipeMock
    {
        // Create enumeralble for recipe list
        public IEnumerable<RecipeModel> GetRecipes()
        {
            //Create a List of dummy recipes
            var recipes = new List<RecipeModel>
            {
                new RecipeModel { Id = 0, prepTime = 45, recipeName = "Breakfast", recipeDescription = "Bacon, eggs and toast" },
                new RecipeModel { Id = 1, prepTime = 20, recipeName = "Lunch", recipeDescription = "Turkey sandwich and chips" },
                new RecipeModel { Id = 2, prepTime = 60, recipeName = "Dinner", recipeDescription = "Pot roast with carrots and mashed potatoes" },
                new RecipeModel { Id = 3, prepTime = 5, recipeName = "snack", recipeDescription = "beef jerkey" }
            };

            return recipes;
        }
        public RecipeModel GetRecipeById(int id)
        {
            return new RecipeModel { Id = 0, prepTime = 45, recipeName = "Breakfast", recipeDescription = "Bacon, eggs and toast" };
        }
    }
}
