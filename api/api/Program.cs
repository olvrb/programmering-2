using System;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;


namespace api
{
    class Program
    {
        static void Main(string[] args)
        {
            RestClient client = new RestClient("https://pokeapi.co/api/v2/");
            RestRequest request = new RestRequest("pokemon/ditto");
            IRestResponse response = client.Get(request);
            Pokemon poki = JsonConvert.DeserializeObject<Pokemon>(response.Content);
            Console.WriteLine(poki.name);
            Console.ReadLine();
        }
    }
}
