using API_Capstone.Models.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Capstone.Models.ViewModels
{
    public class RecipeSearchViewModel
    {
        public List<Result> Recipes  { get; set; }

        public int currentPageNumber { get; set; }

        public int nextPageNumber { get; set; }
        public int previousPageNumber { get; set; }

        public int itemNumber { get; set; }
    }

  
}
