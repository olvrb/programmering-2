using System;
using System.Collections.Generic;
using System.Text;

namespace klasser_instanser
{
    class Enemy
    {
        private int maxHp = 10;
        private int hp = 10;
        public int Hp => hp;
        public Enemy Heal()
        {
            if (CanReceiveHealth()) this.hp++;
            return this;
        }
        public Enemy Damage(int i)
        {
            if (CanTakeDamage()) this.hp -= i;
            return this;
        }
        public int GenerateAttack()
        {
            return new Random().Next(2, 5);
        }

        private bool CanTakeDamage()
        {
            return this.hp >= 0;
        }
        private bool CanReceiveHealth()
        {
            return this.hp >= maxHp;
        }
        

    }
}
