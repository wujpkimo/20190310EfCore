using Microsoft.EntityFrameworkCore;

namespace EfcoreConsoleApp.Models
{
    public class GameDbContext : DbContext
    {
        //DbSet內需放入單數類別，物件則需用複數(s)
        public DbSet<Pokemon> Pokemons { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=game.db");
        }
    }
}