﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Capstone.Models.ApiModels;
using API_Capstone.Models.DALModels;
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
        public async Task<IActionResult> Index(int pageNumber)
        {
            var model = new RecipeSearchViewModel();

            model.Recipes = new List<Result>();

            var response = await _RecipeClient.GetAllRecipes(pageNumber);         

            

            foreach (var recipe in response.results)
            {
                model.Recipes.Add(recipe);
            }

            model.currentPageNumber = pageNumber;
            model.nextPageNumber = pageNumber + 1;
            model.previousPageNumber = pageNumber - 1;

            return View(model);
        }
        public async Task<IActionResult> Search(string searchInfo, string searchType)
        {
            var pageNumber = 1;
            var itemNumber = 0;
            
            var model = new RecipeSearchViewModel();

            model.Recipes = new List<Result>();

            if (!String.IsNullOrEmpty(searchInfo))
            {
                //if(searchType == "AllRecipes")
                //{
                    do
                    {
                        var response = await _RecipeClient.GetAllRecipes(pageNumber);
                        foreach (var recipe in response.results)
                        {
                            
                            if (recipe.title.Contains(searchInfo, StringComparison.OrdinalIgnoreCase)) 
                            {
                            itemNumber += 1;
                                model.Recipes.Add(recipe);
                            }
                        }
                    
                        pageNumber= pageNumber + 1;
                        
                    }
                    while (pageNumber < 100);                   
                //}

                
            }model.itemNumber = itemNumber;
            return View( model);
        }
        public IActionResult AddToFavorites(string recipeTitle)
        {
            var dbModel = new RecipeFavoritesDAL();

            dbModel.Title = recipeTitle;

            dbModel.UserId = _userManager.GetUserId(User);

            _recipesDbContext.FavoriteRecipes.Add(dbModel);
            _recipesDbContext.SaveChanges();

            return View();
        }
        public async Task<IActionResult> ViewFavorties()
        {
            foreach (var recipe in _recipesDbContext.FavoriteRecipes)
            {
                Search(recipe.Title, "AllRecipes", _userManager.GetUserId(User));

                
            }
            return View();
        }   

        public async Task<IActionResult> Search(string recipeTitle, string searchType, string userId)
        {
            var pageNumber = 1;
            var itemNumber = 0;

            var model = new RecipeSearchViewModel();

            model.Recipes = new List<Result>();

            if (!String.IsNullOrEmpty(recipeTitle))
            {
                //if(searchType == "AllRecipes")
                //{
                do
                {
                    var response = await _RecipeClient.GetAllRecipes(pageNumber);
                    foreach (var recipe in response.results)
                    {

                        if (recipe.title.Contains(recipeTitle, StringComparison.OrdinalIgnoreCase))
                        {
                            itemNumber += 1;
                            model.Recipes.Add(recipe);
                        }
                    }

                    pageNumber = pageNumber + 1;

                }
                while (pageNumber < 100);
                //}


            }
            model.itemNumber = itemNumber;
            return 
                //TODO: return single recipe, send to view favorite, save to list there
        }
    }
}
