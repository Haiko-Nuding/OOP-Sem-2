using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_09
{
    internal class Lieferung
    {
        private string _status;

        // READONLY EIGENSCHAFT: Die ID kann nach der Erstellung nicht mehr geändert werden
        public int LieferID { get; }

        public string Status
        {
            get => _status;
            set
            {
                _status = value;
                // TRIGGER: Wenn der Status auf "Geliefert" gesetzt wird, erfolgt eine Konsolenmeldung
                if (_status == "Geliefert")
                {
                    OnGeliefertTrigger();
                }
            }
        }

        public Kunde ZielKunde { get; set; }

        public Lieferung(int id, Kunde kunde)
        {
            LieferID = id;
            ZielKunde = kunde;
            _status = "In Vorbereitung";
        }

        private void OnGeliefertTrigger()
        {
            Console.WriteLine($"TRIGGER: Benachrichtigung an {ZielKunde.Name} gesendet: Essen ist da!");
        }
    }
}
