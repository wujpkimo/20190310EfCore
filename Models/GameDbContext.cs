using Microsoft.EntityFrameworkCore;

namespace EfcoreConsoleApp.Models
{
    public class GameDbContext : DbContext
    {
        DbSet<Pokemon> Pokemons { get; set; }
    }
}