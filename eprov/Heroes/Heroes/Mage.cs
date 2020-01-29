using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eprov.Heroes.Heroes
{
    public class Mage : Hero
    {
        public Mage(string name) : base(name) {

        }
        // When a Mage attacks, deal damage equal to Damage
        public override void Attack(Hero enemy) {
            enemy.DealDamage(Damage);
        }
    }
}
