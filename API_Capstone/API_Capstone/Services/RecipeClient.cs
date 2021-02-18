using API_Capstone.Models.ApiModels;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace API_Capstone.Services
{
    public class RecipeClient
    {
        private readonly HttpClient _client;

        public RecipeClient(HttpClient client)
        {
            _client = client;
        }

        public async Task<RecipesResponseModel> GetAllRecipes(int pageNumber)
        {
            return await GetAsync<RecipesResponseModel>(pageNumber);
        }

        //private async Task<T> GetAsync<T>(string endPoint)
        //{
        //    // Post    -  Insert    -  Create
        //    // Get     -  Select    -  Read
        //    // Put     -  Update    -  Update
        //    // Delete  -  Delete    -  Delete


        //    var response = await _client.GetAsync(endPoint);

        //    if (response.IsSuccessStatusCode)
        //    {

        //        var content = await response.Content.ReadAsStreamAsync();



        //        var model = await JsonSerializer.DeserializeAsync<T>(content);

        //        return model;
        //    }
        //    else
        //    {
        //        throw new HttpRequestException("The API returned bad response");
        //    }
        //}

        private async Task<T> GetAsync<T>(int pageNumber)
        {
            // Post    -  Insert    -  Create
            // Get     -  Select    -  Read
            // Put     -  Update    -  Update
            // Delete  -  Delete    -  Delete


            var response = await _client.GetAsync($"?p={pageNumber}");

            if (response.IsSuccessStatusCode)
            {

                var content = await response.Content.ReadAsStreamAsync();



                var model = await JsonSerializer.DeserializeAsync<T>(content);

                return model;
            }
            else
            {
                throw new HttpRequestException("The API returned bad response");
            }
        }
    }
}
