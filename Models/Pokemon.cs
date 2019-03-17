using System;
using System.ComponentModel.DataAnnotations;
using System.Collections;
using System.Collections.Generic;

namespace EfcoreConsoleApp.Models
{
    public class Pokemon
    {
        public Pokemon()
        {
            Weaknesses = new HashSet<PokemonWeakness>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Hp { get; set; }
        public int MaxHp { get; set; }

        public PokemonBasicProperty BasicProperty { get; set; }

        public ICollection<PokemonWeakness> Weaknesses { get; set; }
    }
}