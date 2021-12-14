using FoodRecipeBuilder.DataObjects;
using FoodRecipeBuilder.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace FoodRecipeBuilder.Controllers
{
    [Route("api/recipes")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly RecipeMock _recipeData = new RecipeMock();
        public readonly IRecipeRepository _repository;

        // api GET for all recipes
        [HttpGet]
        public ActionResult<IEnumerable<RecipeModel>> GetAllRecipes()
        {
            var recipeItems = _recipeData.GetRecipes();

            return Ok(recipeItems);
        }

        // api GET for recipe by id
        [HttpGet("{id}")]
        public ActionResult<RecipeModel> GetRecipeById(int id)
        {
            var recipeItem = _recipeData.GetRecipeById(id);
            return Ok(recipeItem);
        }
    }
}
