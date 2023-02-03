namespace VirtualPetPokemon.JsonTemplateClass
{
    public class MyPokemon
    {
        public string Name { get; set; }
        public string InfoUrl { get; set; }
        public int height { get; set; }
        public int weight { get; set; }

        // To save the abilities, create a new Object List.
        // just use get-set doesen't work
        public List<string> abilities = new List<string>();

        public void ShowPokemonStatus()
        {
            Console.WriteLine($"==============================================================================");
            Console.WriteLine(@$"Name:{Name}
Height:{height}
Weight:{weight}");
            foreach (var nAbility in abilities) Console.Write($"{nAbility}\t");
            Console.WriteLine("");

        }
    }
}
