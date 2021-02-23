using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API_Capstone.Models.DALModels
{
    public class RecipeFavoritesDAL
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Identity(1, 1)
        public string FavoriteID { get; set; }
        public string UserId { get; set; }

        public string Title { get; set; }
        public string Href { get; set; }
        public string Ingredients { get; set; }
        public string Thumbnail { get; set; }

    }
}
