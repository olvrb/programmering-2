using System;

namespace Api {
    internal class Program {
        private static void Main(string[] args) {
            PokiClient client = new PokiClient();

            Pokemon poki = client.GetPokemon("ditto");
            Berry berry = client.GetBerry("1");
            Contest contest = client.GetContest("1");
            Console.WriteLine(poki.Name);
            Console.WriteLine(berry.name);
            Console.WriteLine(contest.name);
            Console.ReadLine();
        }
    }
}