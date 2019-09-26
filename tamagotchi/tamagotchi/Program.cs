using System;

namespace tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet pet = CreatePet();
            while (pet.IsAlive)
            {
                (int hunger, int boredom) = pet.GetStats();
                Console.WriteLine($@"
Name: {pet.Name}
Boredom: {boredom}
Hunger: {hunger}
");
                switch (Console.ReadLine())
                {
                    case "feed": pet.Feed(); break;
                    case "say hi": pet.Hi(); break;
                    case "teach": pet.Teach(); break;
                    case "stats": Console.WriteLine(pet.GetStats()); break;

                    default:
                        continue;
                }
                pet.Tick();
                Console.Clear();
            }
        }


        static Pet CreatePet()
        {
            Console.Write("Choose name: ");
            return new Pet(Console.ReadLine());
        }

        static Pet.Actions GetAction()
        {
            while (true)
            {
                switch (Console.ReadLine())
                {
                    case "feed": return Pet.Actions.Feed;
                    case "say hi": return Pet.Actions.SayHi;
                    case "teach": return Pet.Actions.Teach;

                    default:
                        break;
                }
            }
        }
    }
}
