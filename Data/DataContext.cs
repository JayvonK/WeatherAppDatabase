using Microsoft.EntityFrameworkCore;
using WeatherAppDatabase.Models;

namespace WeatherAppDatabase.Data;

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Favorites> Favorites { get; set; }
    }
