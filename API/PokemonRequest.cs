using System.Text.Json;
using RestSharp;

namespace VirtualPetPokemon.API
{
    public class PokemonRequest
    {
        public async Task<RestResponse> requestAPIAsync(string path)
        {
            var client = new RestClient("https://pokeapi.co/api/v2/pokemon/");
            var request = new RestRequest($"{path}");
            var response =  await client.GetAsync(request);
            return response;
        }

        public async Task<List<Result>> GetAllPokemonsAsync()
        {
            var response = await requestAPIAsync("");
            AllPokemons? result = JsonSerializer.Deserialize<AllPokemons>(response.Content);
            List<Result> list = result.results;
            return list;
        }

        public void GetPokemonStat(MyPokemon pokemon)
        {
            var taskResponse = requestAPIAsync($"{pokemon.Name}/");
            var response = taskResponse.Result;
            PokemonStats? allInfo = JsonSerializer.Deserialize<PokemonStats>(response.Content);

            pokemon.weight = allInfo.weight;
            pokemon.height = allInfo.height;
            foreach (var nAbility in allInfo.abilities)
            {
                pokemon.abilities.Add(nAbility.ability.name);
            }

        }


    }
}
