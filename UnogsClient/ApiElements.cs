using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace UnogsClient
{
    public class ApiItem
    {
        public string netflixid { get; set; }
        public string title { get; set; }
        public string image { get; set; }
        public string synopsis { get; set; }
        public string rating { get; set; }
        public string type { get; set; }
        public string released { get; set; }
        public string runtime { get; set; }
        public string largeimage { get; set; }
        public string unogsdate { get; set; }
        public string imdbid { get; set; }
        public string download { get; set; }
    }

    public class ApiResponse
    { 
        [JsonProperty("COUNT")]
        public string Count { get; set; }
        [JsonProperty("ITEMS")]
        public List<ApiItem> Items { get; set; }
    }
}
