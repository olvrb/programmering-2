using System;
using System.Collections.Generic;
using System.Text;

namespace EqualTemperament
{
    class Scale {
        public const decimal A = 440;
        public static readonly decimal ASharp = GetNote(1);
        public static readonly decimal B = GetNote(2);
        public static readonly decimal C = GetNote(3); // B#
        public static readonly decimal CSharp = GetNote(5);
        public static readonly decimal D = GetNote(6);
        public static readonly decimal DSharp = GetNote(7);
        public static readonly decimal E = GetNote(8);
        public static readonly decimal ESharp = GetNote(9); // F
        public static readonly decimal G = GetNote(10);
        public static readonly decimal GSharp = GetNote(11);



        public static decimal GetNote(decimal i) {
           return A * (decimal) Math.Pow(2, (double) decimal.Divide(i, 12m));
        }
    }
}
