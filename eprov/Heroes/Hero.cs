using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eprov
{
    public class Hero
    {
        // ReSharper disable once InconsistentNaming
        protected Random random = new Random();
        public Hero(string name) {
            // Set name and generate a random damage amount.
            Name = name;
            Damage = (uint)random.Next(0, 100);
        }

        // uint so Hp doesn't go below 0
        public uint Hp { get; protected set; }
        public string Name { get; protected set; }
        public uint Damage { get; protected set; }

        // Helper getter to see if Hero is dead
        public bool Dead => Hp == 0;

        public void Kill() {
            Hp = 0;
        }

        // Deal damage only if not dead.
        public void DealDamage(uint amount) {
            if (Dead) return;
            Hp -= amount;
        }

        public void Heal(uint amount) {
            Hp += amount;
        }

        public virtual void Attack(Hero enemy) {

        }
    }
}
