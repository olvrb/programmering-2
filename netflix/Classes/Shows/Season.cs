using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netflix.Classes
{
    public class Season
    {
        public Season(List<Episode> episodes)
        {
            Episodes = episodes;
        }

        public List<Episode> Episodes { get; protected set; }
    }
}
