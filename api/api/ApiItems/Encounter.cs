using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api
{

    public class Encounter
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Name> names { get; set; }
        public int order { get; set; }
    }
}
