namespace EfcoreConsoleApp.Models
{
    public class PokemonBasicProperty
    {
        public int id { get; set; }

        public int PokemonId { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string Category { get; set; }
        public Pokemon Pokemon { get; set; }
    }
}