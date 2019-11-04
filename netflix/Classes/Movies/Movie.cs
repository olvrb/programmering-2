using System.Collections.Generic;
using System.Drawing;

namespace netflix.Classes.Movies {
    public class Movie : Title {
        public Movie(string name, List<Rating> ratings, Image image, int length) : base(name, ratings, image) {
            Name = name;
            this.ratings = ratings;
            Poster = image;
            Length = length;
        }

        public int Length { get; }
    }
}