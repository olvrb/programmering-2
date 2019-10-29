using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netflix.Classes
{
    public class Show : Title
    {
        public List<Season> Seasons { get; protected set; }

        public Show(string name, List<Rating> ratings, Image image, List<Season> seasons) : base(name, ratings, image)
        {
            Name = name;
            Ratings = ratings;
            Poster = image;
            Seasons = seasons;
        }
    }
}
