using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var buch = new Produkt("B001", "Clean Code", 42.50m, "Bücher", 5);
            var kabel = new Produkt("E999", "USB-C Kabel", 9.90m, "Elektronik", 0);
            var stecker = new Produkt("S222", "Qi Stecker", 19.50m, "Elektronik", 4);
            var warenkorb = new Warenkorb();

            warenkorb.ProduktHinzufuegen(buch);
            buch.ZeigeLagerbestandInfo();
            buch.PruefeLagerbestand();
            warenkorb.Anzeigen();
        }
    }
}
