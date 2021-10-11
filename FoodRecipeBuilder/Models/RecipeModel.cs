using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodRecipeBuilder.Models
{
    public class RecipeModel
    {
        private double _id { get; set; }
        private string _title { get; set; }

        private string? _image { get; set; }
        private string? _imageType { get; set; }

    }
}
