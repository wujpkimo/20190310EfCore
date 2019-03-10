using System;
using EfcoreConsoleApp.Models;

namespace EfcoreConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon pokemon = new Pokemon()
            {
                Id = 1,
                Name = "拖哥德瑪爾"
            };

            GameDbContext db = new GameDbContext();
            db.Pokemons.Add(pokemon);
            db.SaveChanges();

            Console.WriteLine(pokemon.Name);
        }
    }
}
