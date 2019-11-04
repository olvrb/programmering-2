using System.Collections.Generic;

namespace netflix.Classes.Shows {
    public class Season {
        public Season(List<Episode> episodes) => this.episodes = episodes;

        private readonly List<Episode> episodes;

        public IReadOnlyList<Episode> Episodes => episodes.AsReadOnly();
    }
}