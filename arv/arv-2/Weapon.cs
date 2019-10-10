using System;
using System.Collections.Generic;
using System.Text;

namespace arv_2
{
    class Weapon
    {
        protected int minDamage;
        protected int maxDamage;
        public int GetDamage()
        {
            return new Random().Next(minDamage, maxDamage);
        }
        public void PrintStats()
        {
            
        }
    }
}
