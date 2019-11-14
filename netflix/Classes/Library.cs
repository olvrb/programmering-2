using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using netflix.Classes.Movies;
using netflix.Classes.Shows;

namespace netflix.Classes {
    public class Library : List<Title> {
        public Title GetTitleByName(string name) {
            return this.First(x => x.Name == name);
        }

        public void AddTitle(Title title) {
            Add(title);
        }

        public void Populate() {
            AddTitle(new Show("Brooklyn Nine Nine",
                new List<Rating> {new Rating(10)},
                ImageFromUrl(
                    "https://m.media-amazon.com/images/M/MV5BMGU3NGYyYTYtYjIzMS00ZmUwLTlmMjAtZDhhMzFiNWI0NzNkXkEyXkFqcGdeQXVyMzQ2MDI5NjU@._V1_.jpg"),
                new List<Season> {
                    new Season(new List<Episode> {
                        new Episode("Pilot",
                            "Detective Jake Peralta is a talented, but carefree police detective at Brooklyn's ninety-ninth precinct who, along with his eclectic group of colleagues, are used to having a lax captain around the office. However, when tightly-wound Captain Ray Holt takes over, he is determined to make this dysfunctional group of detectives into the best precinct in Brooklyn.",
                            10),
                        new Episode("The Tagger",
                            "Jake thinks the graffiti case he's investigating is below him until he discovers the culprit is the deputy commissioner's son; Gina's psychic friend gets under Charles's skin.",
                            10)
                    })
                }, netflixId: "70281562")
            );
            AddTitle(new Movie("How the Grinch Stole Christmas",
                new List<Rating> {new Rating(10)},
                ImageFromUrl(
                    "http://t3.gstatic.com/images?q=tbn:ANd9GcT-oosslYzD61pdLgPVmjN53hdzb-bjBeJajr2UILlq7kQNz7jR"),
                100, "60000901"));
        }

        public static Image ImageFromUrl(string url) {
            WebClient wc = new WebClient();
            byte[] bytes = wc.DownloadData(url);
            MemoryStream ms = new MemoryStream(bytes);
            return Image.FromStream(ms);
        }
    }
}