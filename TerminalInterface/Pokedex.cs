using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualPetPokemon.JsonTemplateClass;

namespace VirtualPetPokemon.TerminalInterface
{
    public class Pokedex
    {
        public List<MyPokemon> MyListOfPokemons = new List<MyPokemon>();


        public void ShowMyPokemons()
        {
            Console.WriteLine("List of your Pokemons:");
            var nthPokemon = 1;
            if (MyListOfPokemons.Count == 0)
            {
                Console.WriteLine("\nYou don't have a Pokemon yet. Press any key to continue.");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                foreach (var pokemon in MyListOfPokemons)
                {
                    Console.WriteLine($"{nthPokemon}º\t{pokemon.Name}");
                    nthPokemon++;   
                }
            }
        }
    }


}
