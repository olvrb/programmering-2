﻿using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using netflix.Classes.Movies;
using netflix.Classes.Shows;

namespace netflix.Classes {
    public class Library {
        private List<Title> Titles { get; } = new List<Title>();

        public Title GetTitleByName(string name) {
            return Titles.First(x => x.Name == name);
        }

        public void AddTitle(Title title) {
            Titles.Add(title);
        }

        public List<Title> GetTitles() => Titles;

        public void Populate() {
            AddTitle(new Show("Brooklyn Nine Nine",
                new List<Rating> {new Rating(10)},
                ImageFromUrl(
                    "https://m.media-amazon.com/images/M/MV5BMGU3NGYyYTYtYjIzMS00ZmUwLTlmMjAtZDhhMzFiNWI0NzNkXkEyXkFqcGdeQXVyMzQ2MDI5NjU@._V1_.jpg"),
                new List<Season> {
                    new Season(new List<Episode> {
                        new Episode("Pilot",
                            "Detective Jake Peralta is a talented, but carefree police detective at Brooklyn's ninety-ninth precinct who, along with his eclectic group of colleagues, are used to having a lax captain around the office. However, when tightly-wound Captain Ray Holt takes over, he is determined to make this dysfunctional group of detectives into the best precinct in Brooklyn.",
                            10)
                    })
                }));
            AddTitle(new Movie("How the Grinch Stole Christmas",
                new List<Rating> {new Rating(10)},
                ImageFromUrl(
                    "http://t3.gstatic.com/images?q=tbn:ANd9GcT-oosslYzD61pdLgPVmjN53hdzb-bjBeJajr2UILlq7kQNz7jR"),
                100));
        }

        private Image ImageFromUrl(string url) {
            WebClient wc = new WebClient();
            byte[] bytes = wc.DownloadData(url);
            MemoryStream ms = new MemoryStream(bytes);
            return Image.FromStream(ms);
        }
    }
}