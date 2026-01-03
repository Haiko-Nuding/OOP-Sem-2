using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_07
{
    internal class Futterung
    {
        public double Gewicht { get; set; }
        public string Nahrungsmittel { get; set; }
        public Gehege Gehege { get; set; }
        public DateTime Erstellungsdatum { get; private set; }
        public Futterung(string nahrungsmittel, double gewicht)
        {
            Nahrungsmittel = nahrungsmittel;
            Gewicht = gewicht;
            Erstellungsdatum = DateTime.Now;
        }
    }
}
