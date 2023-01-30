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

        public async Task<List<Result>> GetAllPokemonsAsync()
        {
            var client = new RestClient("https://pokeapi.co/api/v2/pokemon/");
            var request = new RestRequest("");
            var response = await client.GetAsync(request);
            AllPokemons? result = JsonSerializer.Deserialize<AllPokemons>(response.Content);
            List<Result> list = result.results;
            return list;
        }
    }
}
