using FoodRecipeBuilder.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodRecipeBuilder.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RecipeController : Controller
    {
        private readonly IRecipeService _recipeService;

        public RecipeController(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        [HttpGet]
        [Route("Test")]
        public async Task<IActionResult> Get()
        //public async IAsyncEnumerable<RecipeModel> RecipeSummary()
        {
            var recipes = await _recipeService.GetRecipeSummary();
            return Ok(recipes);
        }
    }
}
