using System;

namespace arv
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example usage
            Block b = new FalseBlock();
            Block c = new TrueBlock();
            Console.WriteLine($"{b.x} {b.y}");
            Console.WriteLine("Hello World!");
        }
    }
}
