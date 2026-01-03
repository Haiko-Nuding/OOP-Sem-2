using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_10
{
    public class Speichermodell
    {
        public List<Produkt> Produkte { get; set; } = new List<Produkt>();
        public List<Kunde> Kunden { get; set; } = new List<Kunde>();
        public List<Lieferung> Lieferungen { get; set; } = new List<Lieferung>();
    }
}
