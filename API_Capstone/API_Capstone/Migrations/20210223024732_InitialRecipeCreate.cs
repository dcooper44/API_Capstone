using Microsoft.EntityFrameworkCore.Migrations;

namespace API_Capstone.Migrations
{
    public partial class InitialRecipeCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Href",
                table: "FavoriteRecipes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ingredients",
                table: "FavoriteRecipes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Thumbnail",
                table: "FavoriteRecipes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Href",
                table: "FavoriteRecipes");

            migrationBuilder.DropColumn(
                name: "Ingredients",
                table: "FavoriteRecipes");

            migrationBuilder.DropColumn(
                name: "Thumbnail",
                table: "FavoriteRecipes");
        }
    }
}
