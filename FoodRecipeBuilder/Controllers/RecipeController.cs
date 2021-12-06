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
    [Route("api/recipes")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly RecipeMock _recipeData = new RecipeMock();

        [HttpGet]
        public ActionResult <IEnumerable<RecipeModel>> GetAllRecipes()
        {
            var recipeItems = _recipeData.GetRecipes();

            return Ok(recipeItems);
        }

        [HttpGet("{id}")]
        public ActionResult<RecipeModel> GetRecipeById(int id)
        {
            var recipeItem = _recipeData.GetRecipeById(id);
            return Ok(recipeItem);
        }

        //private static readonly string[] Recipes = new[]
        //{
        //    "test", "test1", "test2"
        //};

        //private readonly ILogger<RecipeController> _logger; 

        //public RecipeController(ILogger<RecipeController> logger)
        //{
        //    _logger = logger;
        //}

        //[HttpGet]
        //public IEnumerable<RecipeController> Get()
        //{
        //    //return Enumerable.  .Select(i => new RecipeModel
        //    //{
        //    //    recipeName = Recipes[i]
        //    //}).toArray();
        //    //return Enumerable.Empty().Select(i => new RecipeModel
        //    //{
        //    //    recipeName = Recipes[i]
        //    //});
        //    return Enumerable.
        //}
    }
}
