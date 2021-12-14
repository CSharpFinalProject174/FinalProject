using FoodRecipeBuilder.DataObjects;
using FoodRecipeBuilder.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodRecipeBuilder.Controllers
{
    //Note:  To get db working might need to change nuget to all 3.1 and connect via sql server viewer
    [Route("api/recipes")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly RecipeMock _recipeData = new RecipeMock();
        // Issue is with default constructor vs using constructor that is being passed a value
        public readonly SQLRecipeRepository _recipeResult = new SQLRecipeRepository();

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

        [HttpPost]
        public ActionResult<RecipeModel> Add(RecipeModel recipeModel)
        {
            var recipeResult = _recipeResult.Add(recipeModel);
            // Tried to create a new sqlrec object here that could be passed something, but it didnt work
            //var  newRecipeResult = new SQLRecipeRepository(RecipeContext recipeResult);

            return Ok(recipeResult);
        }
            
    }
}
