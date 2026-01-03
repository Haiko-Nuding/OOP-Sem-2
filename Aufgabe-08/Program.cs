using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- Jeweils mindestens 2 Instanzen erstellen ---

            // Instanzen von Produkt
            Produkt burger = new Produkt("Cheeseburger", 12.50);
            Produkt sushi = new Produkt("Maki Set", 18.00);

            // Instanzen von Kunde (erstellt automatisch Warenkorb)
            Kunde k1 = new Kunde("Max Meier", "Hauptstrasse 1");
            Kunde k2 = new Kunde("Sarah Schmidt", "Gartenweg 5");

            // Zuweisungen (Produkte in Warenkorb)
            k1.AktuellerWarenkorb.ArtikelHinzufuegen(burger);
            k2.AktuellerWarenkorb.ArtikelHinzufuegen(sushi);

            // Instanzen von Lieferung
            Lieferung l1 = new Lieferung(1001, k1);
            Lieferung l2 = new Lieferung(1002, k2);
            l2.Status = "Unterwegs";

            Console.WriteLine($"Lieferung {l1.LieferID} für {l1.ZielKunde.Name} ist: {l1.Status}");
            Console.WriteLine($"Lieferung {l2.LieferID} für {l2.ZielKunde.Name} ist: {l2.Status}");
        }
    }
}
