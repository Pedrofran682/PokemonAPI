using System;
using RestSharp;
using VirtualPetPokemon;
using VirtualPetPokemon.TerminalInterface;

var client = new RestClient("https://pokeapi.co/api/v2/pokemon/");
var request = new RestRequest("");
var response = await client.GetAsync(request);

//AllPokemons? result = JsonSerializer.Deserialize<AllPokemons>(response.Content);

//Console.WriteLine(@$"============================== Virtual Pokemon Pet ==============================");

//Console.WriteLine(@"Hello! Below we have a list of Pokemons. Next to each name we have a number that 
//will represent each one.Type a number to choose your new friend!");

//for (int index = 0; index < result.results.Length; index++)
//{
//    Console.WriteLine($"{index + 1}\t{result.results.ToList()[index].name}");
//}

//int indexPokemon = int.Parse(Console.ReadLine());
//MyPokemon pokemon = new MyPokemon();
//pokemon.name = result.results.ToList()[indexPokemon - 1].name;


//Console.Clear();
//Console.WriteLine(@$"============================== Virtual Pokemon Pet ==============================");
//Console.WriteLine(@$"Nice!! You choose {pokemon.name}, a very strong Pokemon. It's abilites are:");



//request = new RestRequest($"{indexPokemon}/");
//response = await client.GetAsync(request);
//PokemonStats? pickPokemoninfo = JsonSerializer.Deserialize<PokemonStats>(response.Content);


//foreach (var item in pickPokemoninfo.abilities)
//{
//    item.ShowAbility();
//}
Menu gameMenu = new Menu();



while (gameMenu.gameRunnig)
{
    gameMenu.StartMenu();



}


//Console.WriteLine(pickPokemoninfo.abilities.ToList()[1].ability.name);




