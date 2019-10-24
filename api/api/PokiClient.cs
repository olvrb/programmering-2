using System;
using System.Linq;
using Newtonsoft.Json;
using RestSharp;
using System.Runtime.Caching;
using System.Security.AccessControl;

namespace Api {
    internal class PokiClient {
        private readonly RestClient client;
        private static ObjectCache cache;

        public string CacheString => cache.Select(x => $"{x.Key}: {x.Value}").Aggregate((a, b) => $"{a}, {b}");

        public PokiClient() {
            client = new RestClient("https://pokeapi.co/api/v2");
            cache = MemoryCache.Default;
        }

        public T Get<T>(string resource) {
            return GetFrom<T>(resource);
        }

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
            T cacheCheck = GetCache<T>(resource);
            if (cacheCheck != null) return cacheCheck;

            RestRequest request = new RestRequest(resource);
            IRestResponse response = client.Get(request);
            T deserializedObject = JsonConvert.DeserializeObject<T>(response.Content);

            SetCache(resource, deserializedObject);
            return deserializedObject;
        }

        private static T GetCache<T>(string key) {
            return (T) cache.Get(key);
        }

        private static void SetCache<T>(string key, T value) {
            CacheItem item = new CacheItem(key, value);
            CacheItemPolicy policy = new CacheItemPolicy
            {
                AbsoluteExpiration = DateTimeOffset.Now.AddSeconds(5.0)
            };

            cache.AddOrGetExisting(item, policy);
        }
    }
}