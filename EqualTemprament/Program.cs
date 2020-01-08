using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EqualTemperament
{
    class Program
    {
        static void Main(string[] args) {
            List<(int, int)> cmaj = new List<(int, int)> {
                (3, 1000),
                (3, 1000),
                (5, 1000),
                (7, 1000),
                (8, 1000),
                (10, 1000),
                (12, 1000),
                (14, 1000),
                (15, 1000)
            };

            List<(int, int)> lick = new List<(int, int)> {
                ((int) Scale.C, 500),
                ((int) Scale.D, 500),
                ((int) Scale.E, 500),
                ((int) Scale.G, 500),
                ((int) Scale.D, 500),
                ((int) Scale.ASharp, 250),
                ((int) Scale.C, 1000)
            };

            List<(int, int)> lick2 = new List<(int, int)> {
                ((int) Scale.C, 250),
                ((int) Scale.D, 250),
                ((int) Scale.DSharp, 250),
                ((int) Scale.ESharp, 250),
                ((int) Scale.D, 250),
                ((int) Scale.ASharp, 200),
                ((int) Scale.C, 500)
            };


            foreach ((int key, int value) in lick2) {
                
                Console.Beep(key, value);
                Thread.Sleep(1);
            }


            int C = (int)Scale.GetNote(3);
            int E = (int) Scale.GetNote(7);
            int G = (int) Scale.GetNote(10);



            Console.WriteLine(Scale.ASharp);

            Console.WriteLine(E);

            Console.WriteLine(G);


            Console.ReadLine();
        }
    }
}
