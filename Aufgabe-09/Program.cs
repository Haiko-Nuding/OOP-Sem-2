using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instanzen erstellen
            Produkt burger = new Produkt("Cheeseburger", 12.50);
            Produkt gratisBeilage = new Produkt("Pommes", -5.00); // Testet Validierung

            Kunde k1 = new Kunde("Max Meier", "Hauptstrasse 1");
            k1.AktuellerWarenkorb.ArtikelHinzufuegen(burger);
            k1.AktuellerWarenkorb.ArtikelHinzufuegen(gratisBeilage);

            // Ausgabe Berechneter Wert
            Console.WriteLine($"Gesamtpreis für {k1.Name}: {k1.AktuellerWarenkorb.Gesamtpreis} CHF");

            // Lieferung und Trigger testen
            Lieferung l1 = new Lieferung(1001, k1);
            l1.Status = "Geliefert"; // Löst den Trigger aus

            Console.ReadKey();
        }
    }
}
