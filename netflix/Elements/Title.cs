using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using UnogsClient;

namespace netflix.Elements {
    public class Title {
        protected List<Rating> ratings;

        public Title(string name, List<Rating> ratings, Image image, string description = "", string netflixId = "") {
            Name = name;
            this.ratings = ratings;
            Thumbnail = image;
            Description = description;
            NetflixId = netflixId;
        }

        public Title(string name) {
            // Create new Title by fetching data from the Netflix API.
            UnogsClient.UnogsClient client = new UnogsClient.UnogsClient();
            // Fetch data from unogs api
            ApiItem item = client.GetTitleByName(name);
            
            Name = item.Title;
            ratings = new List<Rating> {new Rating(decimal.Parse(item.Rating, CultureInfo.InvariantCulture))};
            Thumbnail = Library.ImageFromUrl(item.Image);
            NetflixId = item.NetflixId;
            Description = item.Synopsis;
        }

        // Description of title
        public string Description { get; protected set; }

        // Display name
        public string Name { get; protected set; }

        // Display thumbnail
        public Image Thumbnail { get; protected set; }

        // Netflix ID, allows us to give the user a clickable link
        public string NetflixId { get; protected set; }


        // Read-only list, since we don't want anyone to add manually.
        public IReadOnlyList<Rating> Ratings => ratings.AsReadOnly();

        public decimal AverageRating => Ratings.Count > 0 ? Ratings.Average(x => x.Value) : 0;

        public void AddRating(Rating rating) {
            ratings.Add(rating);
        }
    }
}