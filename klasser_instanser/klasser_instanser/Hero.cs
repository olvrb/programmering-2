using System;
using System.Collections.Generic;
using System.Text;

namespace klasser_instanser
{
    class Hero
    {
        private int hp;
        private int xp;
        private int level;
        private int minDamage;
        private int maxDamage;
        public int Hp => hp;
        public int Xp => xp;
        public int Level => level;

        public Hero Damage(int i)
        {
            if (IsAlive()) this.hp -= i;
            return this;
        }
        public int GenerateAttack()
        {
            return new Random().Next(minDamage, maxDamage);
        }

        public bool IsAlive()
        {
            return this.IsAlive();
        }

        private bool isAlive()
        {
            return this.hp > 0;
        }
        private Hero addXp(int amount)
        {
            this.xp += amount;
            return this;
        }
    }
}
