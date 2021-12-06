using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodRecipeBuilder.Models
{
    public class RecipeModel
    {
        public int Id { get; set; }
        public int prepTime { get; set; }
        public string recipeName { get; set; }
        public string recipeDescription { get; set; }
    }
}
