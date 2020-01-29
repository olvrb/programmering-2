using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eprov.Heroes.Heroes
{
    public class Assassin : Hero
    {
        public Assassin(string name) : base(name) {

        }
        // When an assasin attacks, kill the enemy if their Hp < Damage, else do nothing
        public override void Attack(Hero enemy) {
            if (enemy.Hp < Damage) enemy.Kill();
        }
    }

    public class SuperAssassin : Assassin {
        public SuperAssassin(string name) : base(name) {

        }

        // An assassin will always kill whatever it attacks
        public override void Attack(Hero enemy) {
            enemy.Kill();
        }
    }

    public class SuperSuperAssassin : SuperAssassin {
        public SuperSuperAssassin(string name) : base(name) {

        }

        // An assassin will always kill everyone, no implemented
        public override void Attack(Hero enemy)
        {
            throw new NotImplementedException();
        }
    }
}
