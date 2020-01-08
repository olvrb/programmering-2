using System.Collections.Generic;

namespace netflix.Elements.Shows {
    public class Season {
        private readonly List<Episode> episodes;
        public Season(List<Episode> episodes) => this.episodes = episodes;

        // Read-only list because we don't want anyone to add manually.
        public IReadOnlyList<Episode> Episodes => episodes.AsReadOnly();
    }
}