namespace EfcoreConsoleApp.Models
{
    public class PokemonWeakness
    {
        public int Id { get; set; }
        public int PokemonId { get; set; }

        public string Name { get; set; }
        public Pokemon Pokemon { get; set; }
    }
}