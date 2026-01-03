using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_07
{
    internal class Tier
    {
        public string Name { get; set; }
        public int Alter { get; set; }
        public Art Art { get; set; }
        public Tier() { }
        public Tier(string name, int alter, Art art)
        {
            Name = name;
            Alter = alter;
            Art = art;
        }
    }
}
