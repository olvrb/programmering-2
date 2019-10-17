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

        public Pokemon GetPokemon(string pokemon)
        {

            Pokemon poki = JsonConvert.DeserializeObject<Pokemon>(GetFrom($"pokemon/{pokemon}"));

            return poki;
        }

        public Berry GetBerry(string nameOrId)
        {

            Berry berry = JsonConvert.DeserializeObject<Berry>(GetFrom($"berry/{nameOrId}"));
            return berry;
        }

        public Contest GetContest(string nameOrId)
        {
            Contest contest = JsonConvert.DeserializeObject<Contest>(GetFrom($"contest-type/{nameOrId}"));
            return contest;
        }

        private string GetFrom(string req)
        {
            RestRequest request = new RestRequest(req);
            IRestResponse response = client.Get(request);
            return response.Content;
        }
    }
}
