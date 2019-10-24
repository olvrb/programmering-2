using System;
using System.Linq;
using System.Threading;

namespace Api {
    internal class Program {
        private static void Main(string[] args) {
            PokiClient client = new PokiClient();

            Pokemon poki = client.GetPokemon("ditto");

            

            Berry berry = client.GetBerry("1");
            Contest contest = client.GetContest("1");
            Contest contest2 = client.GetContest("1");
            Contest contest3 = client.GetContest("1");

            Console.WriteLine(poki.Name);
            Console.WriteLine(berry.name);
            Console.WriteLine(contest.name);
            Console.WriteLine(client.CacheString);
            Thread.Sleep(5500);
            Console.Write(client.CacheString);
            Console.ReadLine();
        }
    }
}