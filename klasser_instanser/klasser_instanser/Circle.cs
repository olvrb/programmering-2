using System;
using System.Collections.Generic;
using System.Text;

namespace klasser_instanser
{
    class Circle
    {
        private int x;
        private int y;
        private int radius;

        public int X => x;
        public int Y => y;
        public int Radius => radius;
        public decimal Area => (decimal)(Math.PI * Math.Pow(radius, 2));
        public decimal Circumference => (decimal)(Math.PI * 2 * radius);
        public void MoveTo(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
