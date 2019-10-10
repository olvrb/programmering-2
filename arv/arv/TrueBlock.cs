using System;
using System.Collections.Generic;
using System.Text;

namespace arv
{
    class TrueBlock : Block
    {
        public TrueBlock()
        {
            this.fallThrough = true;
        }
    }
}
