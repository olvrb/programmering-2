using System.Collections.Generic;
using System.Drawing;

namespace netflix.Classes.Movies {
    public class Movie : Title {
        public Movie(string name, List<Rating> ratings, Image image, int length, string netflixId = "") : base(name,
            ratings, image, netflixId: netflixId) => Length = length;

        public int Length { get; }
    }
}