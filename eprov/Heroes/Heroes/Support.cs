using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eprov.Heroes.Heroes
{
    class Support : Hero {
        public uint HealAmount { get; }
        public Support(string name) : base(name) {
            // Supports don't deal any damage
            Damage = 0;
            HealAmount = (uint)random.Next(0, 100);
        }

        public void HealHero(Hero hero) {
            hero.Heal(HealAmount);
        }
    }
}
