using System;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;

using RestSharp;

namespace ConsoleApp2.Animals
{
    class Dog : Mammal
    {
        public static string GetFact() {
            RestClient client = new RestClient("https://some-random-api.ml/");
            RestRequest request = new RestRequest("facts/dog");
            IRestResponse response = client.Get(request);
            Console.WriteLine(response.Content);

        }
    }
}
