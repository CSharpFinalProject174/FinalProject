using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FoodRecipeBuilder.Models
{
    public class RecipeModel
    {
        [Key]
        [Required(ErrorMessage = "This field is requaired")]
        public int Id { get; set; }
        [Column(TypeName="nvarchar(250)")]
        [Required(ErrorMessage = "This field is requaired")]
        [DisplayName("Preap Time")]
        public int prepTime { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "This field is requaired")]
        [DisplayName("Recipe Name")]
        public string recipeName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required(ErrorMessage = "This field is requaired")]
        [DisplayName("Recipe Destination")]
        public string recipeDescription { get; set; }
    }
}
