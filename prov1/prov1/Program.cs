using System;

namespace prov1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool shouldContinue = true;
            while (shouldContinue)
            {

                // Rather than nesting ifs... or creating methods. Recursion!
                // Default is no.
                Console.Write("Buy book? (y/N): ");
                string inp = Console.ReadLine().ToLower();

                if (inp.Length == 0) shouldContinue = false;
                else
                {
                    char c = inp[0];


                    if (c == 'y')
                    {
                        Book book = new Book();
                        Console.WriteLine($"Here is book: ");
                        book.PrintInfo();
                    }
                    else shouldContinue = false;
                }
            }
        }
    }
}
