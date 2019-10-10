using System;
using System.Collections.Generic;
using System.Text;

namespace arv
{
    class FalseBlock : Block
    {
        public FalseBlock()
        {
            this.fallThrough = false;
        }
    }
}
