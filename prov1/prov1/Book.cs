using System;
using System.Collections.Generic;
using System.Text;

namespace prov1
{
    class Book
    {
        public decimal Price;
        private string name;
        private decimal rarity;
        private string category;
        private decimal actualValue;
        private bool cursed;
        private Random generator;

        private static List<string> Names = new List<string> { "The Call of Ktulu", "The Thing that should not Be", "Dream no More" };
        private static List<string> Categories = new List<string> { "Horror", "Drama", "Informational" };

        public Book()
        {
            // Init new generator because... well... we need a generator instance.
            // Could obviously be initialized where it is declared ¯\_(ツ)_/¯
            // (Sorry, I'm used to Unity)
            this.generator = new Random();

            this.rarity = generator.Next(0, 100);
            this.actualValue = generator.Next(0, 100);

            // 50/50 chance of being true/false.
            this.cursed = generator.Next(0, 100) > 50;

            // Set the books total price
            this.Price = Evaluate();

            // Select random index from Names and Categories.
            this.name = Names[generator.Next(0, Names.Count)];
            this.category = Categories[generator.Next(0, Categories.Count)];
        }
        public void PrintInfo()
        {
            Console.WriteLine($@"
Name: {this.name}
Rarity: {this.rarity}
Category: {this.category}
Price: {this.Price}");
        }
        public decimal Evaluate()
        {
            decimal price = rarity * actualValue;
            return ((decimal)generator.Next(50, 150) / 100) * price;
        }

        public string GetCategory()
        {
            return this.category;
        }

        public string GetName()
        {
            return this.name;
        }

        public bool IsCursed()
        {
            if (generator.Next(0, 100) > 80)
            {
                return this.cursed;
            }
            else return !this.cursed;
        }
    }
}
