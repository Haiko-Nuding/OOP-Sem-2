using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_08
{
    internal class Lieferung
    {
        public int LieferID { get; set; }
        public string Status { get; set; } // z.B. "In Vorbereitung", "Geliefert"
        public Kunde ZielKunde { get; set; }

        public Lieferung(int id, Kunde kunde)
        {
            LieferID = id;
            ZielKunde = kunde;
            Status = "In Vorbereitung";
        }
    }
}
