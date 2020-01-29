using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eprov.Heroes.Heroes;

namespace eprov
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Hero> heroes = new List<Hero>();

            Console.Write("Enter name for Assassin: ");
            Assassin assassin = new Assassin(Console.ReadLine());

            Console.Write("Enter name for Mage: ");
            Mage mage = new Mage(Console.ReadLine());

            Console.Write("Enter name for Support: ");
            Support support = new Support(Console.ReadLine());
            heroes.AddRange(new Hero[] { support, mage, assassin });

            foreach (Hero hero in heroes) {
                Console.WriteLine($"{hero.Name} is a {hero.GetType().Name}.");
            }

            Console.ReadKey();
        }
    }
}
