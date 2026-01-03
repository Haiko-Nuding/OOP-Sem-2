using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_09
{
    internal class Warenkorb
    {
        public List<Produkt> Artikel { get; private set; } = new List<Produkt>();

        // BERECHNETER WERT: Summiert die Preise der Artikel-Liste
        public double Gesamtpreis
        {
            get
            {
                return Artikel.Sum(p => p.Preis);
            }
        }

        public void ArtikelHinzufuegen(Produkt p) => Artikel.Add(p);
    }
}
