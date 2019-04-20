using Microsoft.EntityFrameworkCore;
using OdeToFeed.Models;

namespace OdeToFeed.Data
{
    public class OdeToFoodDbContext : DbContext
    {
        public OdeToFoodDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
