using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_10
{
    public class Kunde : BaseEntity
    {
        public string Name { get; set; }
        public string Adresse { get; set; }
        // Redundanzvermeidung: Nur IDs speichern, nicht die ganzen Produkt-Objekte!
        public List<int> WarenkorbProduktIds { get; set; } = new List<int>();
    }
}
