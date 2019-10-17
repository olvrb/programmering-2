using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api
{
    class PokiClient
    {
        private RestClient client;
        public PokiClient()
        {
            client = new RestClient("https://pokeapi.co/api/v2");
        }

        public Pokemon GetPokemon(string nameOrId) => GetFrom<Pokemon>($"pokemon/{nameOrId}");

        public Berry GetBerry(string nameOrId) => GetFrom<Berry>($"berry/{nameOrId}");

        public Contest GetContest(string nameOrId) => GetFrom<Contest>($"contest-type/{nameOrId}");

        private T GetFrom<T>(string req)
        {
            RestRequest request = new RestRequest(req);
            IRestResponse response = client.Get(request);
            return JsonConvert.DeserializeObject<T>(response.Content);
        }
        
    }
}
