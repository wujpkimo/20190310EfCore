using System;
using System.Collections.Generic;
using EfcoreConsoleApp.Models;

namespace EfcoreConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon pokemon = new Pokemon()
            {
                Name = "拖哥德瑪爾",
                Hp = 30,
                MaxHp = 50,
                BasicProperty = new PokemonBasicProperty
                {
                    Height = 10,
                    Weight = 20,
                    Category = "Roly-Poly"
                },
                Weaknesses = new List<PokemonWeakness>(){
                    new PokemonWeakness{Name="Fire"},
                    new PokemonWeakness{Name="Poly"}
                }
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
