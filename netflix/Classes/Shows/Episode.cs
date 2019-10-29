using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netflix.Classes
{
    public class Episode
    {
        public Episode(int length)
        {
            this.Length = length;
        }

        public int Length { get; }
    }
}
