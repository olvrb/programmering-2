using System;
using System.Collections.Generic;
using System.Text;

namespace klasser_instanser
{
    class Rectangle
    {
        private decimal width;
        private decimal height;
        public decimal Width => width;
        public decimal Height => height;
        public decimal Circumference => (height * 2) + (width * 2);
        public decimal Area => height * width;
    }
}
