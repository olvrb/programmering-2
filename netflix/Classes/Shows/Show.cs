﻿using System.Collections.Generic;
using System.Drawing;

namespace netflix.Classes.Shows {
    public class Show : Title {
        private readonly List<Season> seasons;

        public Show(string name, List<Rating> ratings, Image image, List<Season> seasons, string description = "",
            string netflixId = "") : base(name, ratings, image, description, netflixId) => this.seasons = seasons;

        public IReadOnlyList<Season> Seasons => seasons.AsReadOnly();

        public Season GetSeasonByNumber(int num) => Seasons[num];
    }
}