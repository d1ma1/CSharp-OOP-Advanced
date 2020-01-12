namespace Google
{
    public class Pokemon
    {
        public string PokemonName { get; set; }
        public string Element { get; set; }
        public int Health { get; set; }

        public Pokemon(string pokemonName, string element)
        {
            this.PokemonName = pokemonName;
            this.Element = element;
        }

        public override string ToString()
        {
            return $"{PokemonName} {Element}";
        }
    }
}
