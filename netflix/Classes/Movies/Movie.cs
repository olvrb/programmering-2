using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netflix.Classes
{
    public class Movie : Title
    {
        public int Length { get; }

        public Movie(string name, List<Rating> ratings, Image image, int length) : base(name, ratings, image)
        {
            Name = name;
            Ratings = ratings;
            Poster = image;
            Length = length;
        }
    }
}
