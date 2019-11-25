﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace UnogsClient {
    // More or less generated by http://json2csharp.com/
    public class ApiItem {
        [JsonProperty("netflixid")]
        public string NetflixId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("synopsis")]
        public string Synopsis { get; set; }

        [JsonProperty("rating")]
        public string Rating { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("released")]
        public string Released { get; set; }

        [JsonProperty("runtime")]
        public string Runtime { get; set; }

        [JsonProperty("largeimage")]
        public string LargeImage { get; set; }

        [JsonProperty("unogsdate")]
        public string UnogsDate { get; set; }

        [JsonProperty("imdbid")]
        public string ImdbId { get; set; }

        [JsonProperty("download")]
        public string Download { get; set; }
    }

    public class ApiResponse {
        [JsonProperty("COUNT")]
        public string Count { get; set; }

        [JsonProperty("ITEMS")]
        public List<ApiItem> Items { get; set; }
    }
}