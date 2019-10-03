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
                string strInput = Console.ReadLine().ToLower();

                if (strInput.Length == 0) shouldContinue = false;
                else
                {
                    char charInput = strInput[0];


                    if (charInput == 'y')
                    {
                        // Create new book and show the customer.
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
