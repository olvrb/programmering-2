using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netflix.Classes
{
    public class Title
    {
        public string Name { get; protected set; }
        public Image Poster { get; protected set; }
        public List<Rating> Ratings { get; protected set; }

        public double AverageRating => Ratings.Average(x => x.Value);


        public Title(string name, List<Rating> ratings, Image image) {
            Name = name;
            Ratings = ratings;
            Poster = image;
        }

        public void AddRating(Rating rating)
        {
            Ratings.Add(rating);
        }
    }
}
