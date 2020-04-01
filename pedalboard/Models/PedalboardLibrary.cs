using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedalboard.Models
{
    class PedalboardLibrary : BaseEntity
    {
        // HashSet, don't want duplicates
        public HashSet<Pedalboard> Pedalboards = new HashSet<Pedalboard>();


        // Useless wrapper 
        public PedalboardLibrary Add(Pedalboard pedalboard)
        {
            Pedalboards.Add(pedalboard);

            return this;
        }
    }
}
