using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eprov.School.Classroom
{
    public class Classroom
    {
        public string Name { get; protected set; }
        public uint MaxCapacity { get; protected set; }

        public Classroom(string name, uint maxCapacity = 30) {
            Name = name;
            MaxCapacity = maxCapacity;
        }
    }
}
