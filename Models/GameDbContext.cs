using Microsoft.EntityFrameworkCore;

namespace EfcoreConsoleApp.Models
{
    public class GameDbContext : DbContext
    {
        public DbSet<Pokemon> Pokemons { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=game.db");
        }
    }
}