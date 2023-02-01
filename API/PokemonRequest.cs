using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp;

namespace VirtualPetPokemon.API
{
    public class PokemonRequest
    {
        public async Task<RestResponse> requestAPIAsync(string path)
        {
            var client = new RestClient("https://pokeapi.co/api/v2/pokemon/");
            var request = new RestRequest($"{path}");
            return await client.GetAsync(request);
        }

        public async Task<List<Result>> GetAllPokemonsAsync()
        {
            var response = await requestAPIAsync("");
            AllPokemons? result = JsonSerializer.Deserialize<AllPokemons>(response.Content);
            List<Result> list = result.results;
            return list;
        }

        public async void GetPokemonStatAsync(MyPokemon pokemon)
        {
            var response = await requestAPIAsync($"{pokemon.InfoUrl}/");
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
