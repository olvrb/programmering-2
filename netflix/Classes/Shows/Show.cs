using System.Collections.Generic;
using System.Drawing;

namespace netflix.Classes.Shows {
    public class Show : Title {
        public Show(string name, List<Rating> ratings, Image image, List<Season> seasons) : base(name, ratings, image) {
            Name = name;
            Ratings = ratings;
            Poster = image;
            Seasons = seasons;
        }

        public List<Season> Seasons { get; protected set; } = new List<Season>();

        public Season GetSeasonByNumber(int num) => Seasons[num];
    }
}