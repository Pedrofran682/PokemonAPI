using RestSharp;
using System.Text.Json;
using VirtualPetPokemon.API;

namespace VirtualPetPokemon.TerminalInterface
{
    public  class Menu
    {
        public  bool flag { get; private set; }

        public  void StartMenu()
        {

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    ChoosePokemonAsync();
                    break;
                case "2":
                    MyPokemons();
                    break;
                case "3":
                    Console.WriteLine("Closing...");
                    Thread.Sleep(1000);
                    break;

            }

            Console.ReadKey();
        }

        public  bool CloseGame()
        {
            return false;
        }

        public  void MyPokemons()
        {
            throw new NotImplementedException();
        }

        public async Task<int> ChoosePokemonAsync()
        {
            Console.WriteLine(@"
Hello! Below we have a list of Pokemons. Next to each name we have a number that 
            will represent each one.Type a number to choose your new friend!");

            var allPokemonsInfos = new PokemonRequest();
            var listOfPokemons = await allPokemonsInfos.GetAllPokemonsAsync();

            for (int index = 0; index < listOfPokemons.Count; index++)
            {
                Console.WriteLine($"{index + 1}\t{listOfPokemons[index].name}");
            };
            int indexMyPokemon = int.Parse(Console.ReadLine());
            return indexMyPokemon;

        }


    }
}
