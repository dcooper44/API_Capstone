using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Capstone.Models.ApiModels;
using API_Capstone.Models.ViewModels;
using API_Capstone.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace API_Capstone.Controllers
{
    public class RecipeController : Controller
    {
        private readonly RecipesDBContext _recipesDbContext;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RecipeClient _RecipeClient;

        public RecipeController(RecipesDBContext recipesDbContext, UserManager<IdentityUser> userManager, RecipeClient RecipeClient)
        {
            _recipesDbContext = recipesDbContext;
            _userManager = userManager;
            _RecipeClient = RecipeClient;
        }
        public async Task<IActionResult> Index()
        {
            var model = new RecipeSearchViewModel();

            var response = await _RecipeClient.GetAllRecipes();
          

            var listRecipes = new List<Result>();

            foreach (var recipe in response.results)
            {
                model.Recipes.Add(recipe);
            }
            return View(model);
        }
    }
}