using API_Capstone.Models.DALModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace API_Capstone.Services
{
    public class RecipesDBContext : IdentityDbContext
    {

        public RecipesDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<RecipeFavoritesDAL> FavoriteRecipes { get; set; }

    }
}
