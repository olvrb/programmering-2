using Newtonsoft.Json;
using RestSharp;

namespace Api {
    internal class PokiClient {
        private readonly RestClient client;

        public PokiClient() => client = new RestClient("https://pokeapi.co/api/v2");

        /// <summary>
        ///     Get pokemon by name or Id.
        /// </summary>
        /// <param name="nameOrId"></param>
        /// <returns></returns>
        public Pokemon GetPokemon(string nameOrId) => GetFrom<Pokemon>($"pokemon/{nameOrId}");

        /// <summary>
        ///     Get Berry by name or Id.
        /// </summary>
        /// <param name="nameOrId"></param>
        /// <returns></returns>
        public Berry GetBerry(string nameOrId) => GetFrom<Berry>($"berry/{nameOrId}");

        /// <summary>
        ///     Get contest by name or Id.
        /// </summary>
        /// <param name="nameOrId"></param>
        /// <returns></returns>
        public Contest GetContest(string nameOrId) => GetFrom<Contest>($"contest-type/{nameOrId}");

        /// <summary>
        ///     Submit GET request to resource.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="resource"></param>
        /// <returns></returns>
        private T GetFrom<T>(string resource) {
            RestRequest request = new RestRequest(resource);
            IRestResponse response = client.Get(request);
            return JsonConvert.DeserializeObject<T>(response.Content);
        }
    }
}