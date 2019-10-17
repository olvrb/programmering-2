using System.Collections.Generic;

namespace Api {
    public class BerryFlavor {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Language {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Name {
        public string color { get; set; }
        public Language language { get; set; }
        public string name { get; set; }
    }

    public class Contest {
        public BerryFlavor berry_flavor { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public List<Name> names { get; set; }
    }
}