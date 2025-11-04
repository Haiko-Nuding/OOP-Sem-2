using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_05
{
    internal class Pfleger
    {
        public string Name { get; set; }
        public string Adresse { get; set; }
        public string Notallnummer { get; set; }

        public Pfleger() { }
        public Pfleger(string name, string adresse, string notfallnummer) {
            Name = name;
            Adresse = adresse;
            Notallnummer = notfallnummer;
        }
    }
}
