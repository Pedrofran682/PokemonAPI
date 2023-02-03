using System;
using RestSharp;
using VirtualPetPokemon;
using VirtualPetPokemon.API;
using VirtualPetPokemon.TerminalInterface;


MyPokemon ChoosePokemon()
{
    Console.WriteLine(@$"==============================================================================");
    Console.WriteLine(@"
Hello! Below we have a list of Pokemons. Next to each name we have a number that 
            will represent each one.Type a number to choose your new friend!");
    MyPokemon myPokemon = new MyPokemon();

    var allPokemonsInfos = new PokemonRequest(); // Reasponsible for make the request
    Task<List<Result>> taskListOfPokemons = allPokemonsInfos.GetAllPokemonsAsync();
    // Returns the list object inside the task
    List<Result> listOfPokemons = taskListOfPokemons.Result;

    for (int index = 0; index < listOfPokemons.Count; index++)
    {
        Console.WriteLine($"{index}\t{listOfPokemons[index].name}");
    };

    Console.Write("Choose your friend! ");
    int indexMyPokemon = int.Parse(Console.ReadLine());
    // Saves the chosen pokemon info
    myPokemon.Name = listOfPokemons[indexMyPokemon].name;
    myPokemon.InfoUrl = listOfPokemons[indexMyPokemon].url;

    return myPokemon;

}

bool runGame = true;
while (runGame)
{
    #region Print Menu
    Console.WriteLine(@$"============================== Virtual Pokemon Pet ==============================");
    Console.WriteLine($@"
1 - Adoption of a Pokemon
2 - My Pokemons
3 - Quit");
    #endregion

    Pokedex myPokedex = new Pokedex();
    Console.Write("What will you do? ");
    string option = Console.ReadLine();

    switch (option)
    {
        case "1":
            MyPokemon newPokemon = ChoosePokemon();

            var pokemonInfos = new PokemonRequest();
            // To avoid multiples requests, lets define the parameters
            pokemonInfos.GetPokemonStat(newPokemon);

            var do2Pokemon = "2";
            while (do2Pokemon == "1" || do2Pokemon == "2")
            {
                Console.WriteLine(@$"==============================================================================");
                Console.Write(@"
1 - See Pomekom info.
2 - Adopt 
3 - Leave
");
                do2Pokemon = Console.ReadLine();

                if (do2Pokemon == "1") // Show Pokemon info
                {
                    newPokemon.ShowPokemonStatus();
                }
                if (do2Pokemon == "2") // Adopt Pokemon
                {
                    Console.WriteLine($"Congrats!!! You have adopted {newPokemon.Name}");
                    myPokedex.MyListOfPokemons.Add(newPokemon);
                    break;
                }
            }
            break;
        case "2":
            // Print my pokemons
            break;

        case "3":
            Console.WriteLine("Closing...");
            Thread.Sleep(1000);
            runGame = false;
            break;
    }

}

