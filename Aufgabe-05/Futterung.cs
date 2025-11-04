using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_05
{
    internal class Futterung
    {

        public double Gewicht { get; set; }
        public string Nahrungsmittel {  get; set; }
        public Gehege Gehege {  get; set; }
        public DateTime Erstellungsdatum { get; private set; }
        public Futterung() { }
        public Futterung(string nahrungsmittel, double gewicht)
        {
            Nahrungsmittel = nahrungsmittel;
            Gewicht = gewicht;
            Erstellungsdatum = DateTime.Now; // automatisch gesetzt beim Erstellen
        }

        public bool IstAelterAls3Jahre()
        {
            return (DateTime.Now - Erstellungsdatum).TotalDays > 3 * 365;
        }
    }
}
