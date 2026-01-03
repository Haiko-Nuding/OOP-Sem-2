using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_09
{
    internal class Kunde
    {
        public string Name { get; set; }
        public string Adresse { get; set; }
        public Warenkorb AktuellerWarenkorb { get; } = new Warenkorb();

        public Kunde(string name, string adresse)
        {
            Name = name;
            Adresse = adresse;
        }
    }
}
