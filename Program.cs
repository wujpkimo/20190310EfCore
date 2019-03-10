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

            using (var context = new GameDbContext())
            {
                context.Pokemons.Add(pokemon);
                context.SaveChanges();
            }

            Console.WriteLine("新增資料完成");
        }
    }
}
