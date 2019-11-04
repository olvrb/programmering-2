using System.Collections.Generic;
using System.Drawing;

namespace netflix.Classes.Shows {
    public class Show : Title {
        public Show(string name, List<Rating> ratings, Image image, List<Season> seasons) : base(name, ratings, image) {
            Name = name;
            this.ratings = ratings;
            Poster = image;
            this.seasons = seasons;
        }

        private readonly List<Season> seasons;

        public IReadOnlyList<Season> Seasons => seasons.AsReadOnly();

        public Season GetSeasonByNumber(int num) => Seasons[num];
    }
}