using FoodRecipeBuilder.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FoodRecipeBuilder.Services
{
    public class RecipeService:IRecipeService
    {
        public async Task<List<RecipeModel>> GetRecipeSummary()
        {
            using (var client = GetClient())
            {
                var response = await client.GetAsync("recipes/complexSearch?apiKey=16207a652bd845e188bed4d094963a31");
                if (response.IsSuccessStatusCode)
                {
                    var resContent = JsonConvert.DeserializeObject<RecipeModelList>(await response.Content.ReadAsStringAsync());
                }
                throw new NotImplementedException();
            }
        }
        private HttpClient GetClient()
        {
            var client = new HttpClient()
            {
                BaseAddress = new Uri("https://api.spoonacular.com/")
            };
            return client;
        }
    }
}

public interface IRecipeService
{
    Task<List<RecipeModel>> GetRecipeSummary();
}

//https://api.spoonacular.com/recipes/complexSearch?apiKey=16207a652bd845e188bed4d094963a31

//{
//    "id": 716426,
//            "title": "Cauliflower, Brown Rice, and Vegetable Fried Rice",
//            "image": "https://spoonacular.com/recipeImages/716426-312x231.jpg",
//            "imageType": "jpg"
//        },