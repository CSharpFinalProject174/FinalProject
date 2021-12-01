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

// Spoonacular api call

// https://api.spoonacular.com/recipes/complexSearch?apiKey=16207a652bd845e188bed4d094963a31

// ##### Rapid Api Snippet ######

//var client = new HttpClient();
//var request = new HttpRequestMessage
//{
//    Method = HttpMethod.Post,
//    RequestUri = new Uri("https://spoonacular-recipe-food-nutrition-v1.p.rapidapi.com/food/products/classify?locale=en_us"),
//    Headers =
//    {
//        { "x-rapidapi-host", "spoonacular-recipe-food-nutrition-v1.p.rapidapi.com" },
//        { "x-rapidapi-key", "381eed07a0msh13faaa7d02dd762p1c98acjsn2a04e528d62b" },
//    },
//    Content = new StringContent("{\r\n    \"plu_code\": \"\",\r\n    \"title\": \"Kroger Vitamin A & D Reduced Fat 2% Milk\",\r\n    \"upc\": \"\"\r\n}")
//    {
//        Headers =
//        {
//            ContentType = new MediaTypeHeaderValue("application/json")
//        }
//    }
//};
//using (var response = await client.SendAsync(request))
//{
//    response.EnsureSuccessStatusCode();
//    var body = await response.Content.ReadAsStringAsync();
//    Console.WriteLine(body);
//}

// ##### Rapid Api Snippet ######
//https://api.spoonacular.com/recipes/complexSearch?apiKey=16207a652bd845e188bed4d094963a31

//{
//    "id": 716426,
//            "title": "Cauliflower, Brown Rice, and Vegetable Fried Rice",
//            "image": "https://spoonacular.com/recipeImages/716426-312x231.jpg",
//            "imageType": "jpg"
//        },