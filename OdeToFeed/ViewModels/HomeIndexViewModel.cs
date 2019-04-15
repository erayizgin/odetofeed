using OdeToFeed.Models;
using System.Collections.Generic;

namespace OdeToFeed.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Restaurant> Restaurants { get; set; }
        public string CurrentMessage { get; set; }
    }
}
