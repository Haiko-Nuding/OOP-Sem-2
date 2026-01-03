using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum Modus
{
    Heizen,
    Off,
    Kuehlen
}

namespace Aufgabe_17
{
    internal class Klimaanlage
    {
        private double zielTemperatur;

        // Aktuelle Temperatur
        public double AktuelleTemperatur { get; set; }

        // ZielTemperatur mit Logik für Modus
        public double ZielTemperatur
        {
            get => zielTemperatur;
            set
            {
                zielTemperatur = value;
                // Modus automatisch setzen
                if (AktuelleTemperatur < zielTemperatur)
                {
                    Modus = Modus.Heizen;
                }
                else if (AktuelleTemperatur > zielTemperatur)
                {
                    Modus = Modus.Kuehlen;
                }
                else
                {
                    Modus = Modus.Off;
                }
            }
        }

        // Aktueller Modus
        public Modus Modus { get; private set; }

        // 3️⃣ Methode: Status anzeigen
        public void StatusAnzeigen()
        {
            Console.WriteLine("Aktuelle Temperatur: " + AktuelleTemperatur + "°C");
            Console.WriteLine("Zieltemperatur: " + ZielTemperatur + "°C");
            Console.WriteLine("Modus: " + Modus);
            Console.WriteLine(); // Leerzeile für Übersicht
        }
    }
}
