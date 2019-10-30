using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netflix.Classes
{
    public class Episode
    {
        public Episode(string name, string description, int length)
        {
            this.Length = length;
            this.Name = name;
            this.Description = description;
        }

        public int Length { get; }
        public string Name { get; }
        public string Description { get; }
    }
}
