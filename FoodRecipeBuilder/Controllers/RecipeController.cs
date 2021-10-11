using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodRecipeBuilder.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RecipeController:ControllerBase
    {
        private readonly IRecipeService _recipeService;

        public RecipeController(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        [HttpGet]
        public async Task<IActionResult> RecipeSummary()
        {
            var recipes = await _recipeService.GetRecipeSummary();
            return Ok(recipes);
        }
    }
}
