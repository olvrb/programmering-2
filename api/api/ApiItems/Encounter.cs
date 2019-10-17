using System.Collections.Generic;

namespace Api {
    public class Encounter {
        public int id { get; set; }
        public string name { get; set; }
        public List<Name> names { get; set; }
        public int order { get; set; }
    }
}