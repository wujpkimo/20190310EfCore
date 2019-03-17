using Microsoft.EntityFrameworkCore;

namespace EfcoreConsoleApp.Models
{
    public class GameDbContext : DbContext
    {
        //DbSet內需放入單數類別，物件則需用複數(s)
        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<PokemonBasicProperty> PokemonBasicProperties { get; set; }

        public DbSet<PokemonWeakness> PokemonWeaknesses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=game.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Pokemon>()
                .HasOne<PokemonBasicProperty>(p => p.BasicProperty)
                .WithOne(b => b.Pokemon)
                .HasForeignKey<PokemonBasicProperty>(b => b.PokemonId);

            modelBuilder
                .Entity<Pokemon>()
                .HasMany<PokemonWeakness>(p => p.Weaknesses)
                .WithOne(w => w.Pokemon)
                .HasForeignKey(w => w.PokemonId);
        }
    }
}