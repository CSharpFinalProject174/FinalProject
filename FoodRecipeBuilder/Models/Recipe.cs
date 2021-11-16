using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestSharp;

namespace FoodRecipeBuilder.Models
{
    public class Recipe
    {
        public string recipeName { get; set; }
        public List<string> ingredientList { get; set; }
        RestClient client = new RestClient("https://spoonacular-recipe-food-nutrition-v1.p.rapidapi.com/food/products/classify?locale=en_us");
        RestRequest request = new RestRequest(Method.POST);
        

    }
}
