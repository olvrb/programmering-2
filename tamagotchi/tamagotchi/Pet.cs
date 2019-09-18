using System;
using System.Collections.Generic;
using System.Text;

namespace tamagotchi
{
    class Pet
    {
        private List<string> words;

        public Pet(string name)
        {
            this.Name = name;
        }

        public int Hunger { get; private set; }
        public int Boredom { get; private set; }
        public List<string> Words => words;
        public string Name { get; }
        public bool IsAlive { get => this.Hunger > 10 || this.Boredom > 10; }

        public void Feed()
        {
            this.Hunger--;
        }

        public void Hi()
        {
            this.Boredom--;
        }
        public void Teach()
        {
            Console.Write("teach word: ");
            words.Add(Console.ReadLine());
        }
        public void Tick()
        {
            this.Boredom++;
            this.Hunger++;
        }
        public (int, int) GetStats()
        {
            return (Hunger, Boredom);
        }
        private void ReduceBoredom(int n)
        {
            throw new NotImplementedException();
        }

        public enum Actions
        {
            Teach,
            SayHi,
            Feed
        }
    }
}
