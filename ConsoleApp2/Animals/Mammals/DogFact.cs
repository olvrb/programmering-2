using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp2.Animals.Mammals
{
    public class DogFact
    {
        [JsonProperty("fact")]
        public string Fact { get; set; }
    }
}
