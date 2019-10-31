using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace netflix.Classes {
    public class Title {
        public Title(string name, List<Rating> ratings, Image image) {
            Name = name;
            Ratings = ratings;
            Poster = image;
        }

        public string Name { get; protected set; }
        public Image Poster { get; protected set; }
        public List<Rating> Ratings { get; protected set; }

        public double AverageRating => Ratings.Average(x => x.Value);

        public void AddRating(Rating rating) {
            Ratings.Add(rating);
        }
    }
}