using System.Collections.Generic;

namespace netflix.Classes.Shows {
    public class Season {
        private readonly List<Episode> episodes;
        public Season(List<Episode> episodes) => this.episodes = episodes;

        public IReadOnlyList<Episode> Episodes => episodes.AsReadOnly();
    }
}