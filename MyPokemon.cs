
namespace VirtualPetPokemon
{
    public class MyPokemon
    {
        public string Name{ get; set; }
        public string InfoUrl { get; set; }
        public int height { get; set; }
        public int weight { get; set; }
        
        // To save the abilities, create a new Object List.
        // just use get-set doesen't work
        public List<string> abilities = new List<string>(); 

        public void ShowPokemonStatus()
        {
            Console.WriteLine(@$"-----------------------------------------
Name:{this.Name}
Height:{this.height}
Weight:{this.weight}");
            foreach (var nAbility in this.abilities) Console.WriteLine($"{nAbility}\t");
        }
    }
}
