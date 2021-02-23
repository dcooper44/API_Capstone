using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Capstone.Models.ApiModels
{
    public class RecipesResponseModel
    {
        public string title { get; set; }
        public float version { get; set; }
        public string href { get; set; }
        public Result[] results { get; set; }

    }



    public class Result
    {
        public string title { get; set; }
        public string Href { get; set; }
        public string Ingredients { get; set; }
        public string Thumbnail { get; set; }
    }

}
