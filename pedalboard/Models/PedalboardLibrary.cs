using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedalboard.Models
{
    class PedalboardLibrary : BaseEntity
    {
        public HashSet<Pedalboard> Pedalboards = new HashSet<Pedalboard>();

        public PedalboardLibrary Add(Pedalboard pedalboard)
        {
            Pedalboards.Add(pedalboard);

            return this;
        }
    }
}
