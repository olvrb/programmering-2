﻿using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace netflix.Classes {
    public class Title {
        public Title(string name, List<Rating> ratings, Image image, string description = "") {
            Name = name;
            this.ratings = ratings;
            Poster = image;
            Description = description;
        }

        public string Description { get; protected set; }
        public string Name { get; protected set; }
        public Image Poster { get; protected set; }
        protected List<Rating> ratings;

        public IReadOnlyList<Rating> Ratings => ratings.AsReadOnly();

        public double AverageRating => Ratings.Count > 0 ? Ratings.Average(x => x.Value) : 0;

        public void AddRating(Rating rating) {
            ratings.Add(rating);
        }
    }
}