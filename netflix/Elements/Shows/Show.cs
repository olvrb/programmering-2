using System.Collections.Generic;
using System.Drawing;

namespace netflix.Elements.Shows {
    public class Show : Title {
        private readonly List<Season> seasons;

        // Call base constructor with all required params
        public Show(string name, List<Rating> ratings, Image image, List<Season> seasons, string description = "",
            string netflixId = "") : base(name, ratings, image, description, netflixId) => this.seasons = seasons;

        // Read-only list because we don't want anyone to add manually.
        public IReadOnlyList<Season> Seasons => seasons.AsReadOnly();

        public Season GetSeasonByNumber(int num) => Seasons[num];
    }
}