using OdeToFeed.Models;
using System.ComponentModel.DataAnnotations;

namespace OdeToFeed.ViewModels
{
    public class RestaurantEditModel
    {
        [Required, MaxLength(80)]
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
