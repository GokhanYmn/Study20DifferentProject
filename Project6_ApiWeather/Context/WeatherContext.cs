using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Project6_ApiWeather.Entities;

namespace Project6_ApiWeather.Context
{
    public class WeatherContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-3HV2966;initial catalog=Db6ProjectWeather;integrated Security=True;TrustServerCertificate=True ");
            
        }
        public DbSet<City> Cities { get; set; }
    }
}
