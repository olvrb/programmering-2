using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netflix.Classes
{
    public class Library
    {
        private List<Title> Titles { get; } = new List<Title>();

        public Title GetTitleByName(string name)
        {
            return Titles.First(x => x.Name == name);
        }

        public void AddTitle(Title title)
        {
            this.Titles.Add(title);
        }

        public List<Title> GetTitles()
        {
            return this.Titles;
        }
    }
}
