using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netflix.Classes
{
    public class Rating
    {
        public int Value { get; private set; }

        public Rating(int value)
        {
            this.Value = value;
        }
    }
}
