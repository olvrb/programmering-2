using System.Collections.Generic;

namespace netflix.Classes.Shows {
    public class Season {
        public Season(List<Episode> episodes) => Episodes = episodes;

        public List<Episode> Episodes { get; protected set; }
    }
}