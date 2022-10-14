using Microsoft.EntityFrameworkCore;
using Practice.Entities;

namespace Practice.Data
{
    public class AppDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = C:/Users/HP/OneDrive/Desktop/DesignPatterns/PATTERNS/Creational Patterns/Factory Method/Practice/app.db");
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Boat> Boats { get; set; }
        public DbSet<Motorcycle> Motorcycles { get; set; }

    }
}