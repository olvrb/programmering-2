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
            PokiClient client = new PokiClient();

            Pokemon poki = client.GetPokemon("ditto");
            Berry berry = client.GetBerry("1");
            Contest contest = client.GetContest("1");
            Console.WriteLine(berry.name);
            Console.WriteLine(contest.name);
            Console.ReadLine();
        }
    }
}
