using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_09
{
    internal class Produkt
    {
        private double _preis;
        public string Name { get; set; }

        public double Preis
        {
            get => _preis;
            set
            {
                // DATENVALIDIERUNG: Preis darf nicht negativ sein
                if (value < 0)
                {
                    Console.WriteLine($"Warnung: Ungültiger Preis für {Name}. Setze auf 0.");
                    _preis = 0;
                }
                else
                {
                    _preis = value;
                }
            }
        }

        public Produkt(string name, double preis)
        {
            Name = name;
            Preis = preis;
        }
    }
}
