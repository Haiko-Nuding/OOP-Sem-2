using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_08
{
    internal class Warenkorb
    {
        public List<Produkt> Artikel { get; set; } = new List<Produkt>();
        public double Gesamtpreis { get; set; }

        public void ArtikelHinzufuegen(Produkt p)
        {
            Artikel.Add(p);
            Gesamtpreis += p.Preis;
        }
    }
}
