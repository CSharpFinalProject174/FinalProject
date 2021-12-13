using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodRecipeBuilder.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RecipeModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    prepTime = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    recipeName = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    recipeDescription = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeModels", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecipeModels");
        }
    }
}
