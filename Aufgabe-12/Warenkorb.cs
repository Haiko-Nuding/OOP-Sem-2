using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_12
{
    internal class Warenkorb
    {
        List<Produkt> Produkte = new List<Produkt>();
        public Warenkorb() { }

        public void ProduktHinzufuegen(Produkt produkt) 
        {
            bool isInWarenkorb = false;
            foreach (Produkt item in Produkte)
            {
                if (item.Artikelnummer == produkt.Artikelnummer)
                {
                    isInWarenkorb = true;
                    Console.WriteLine($"Produkt {produkt.Artikelnummer} ist bereits im Warenkorb.");
                    break;
                }
            }
            if (!isInWarenkorb) 
            {
                if (produkt.AufLager())
                {
                    Produkte.Add(produkt);
                    produkt.VerringereLagerbestand(1);
                    Console.WriteLine($"Produkt {produkt.Artikelnummer} hinzugefügt.");
                }
                else
                {
                    Console.WriteLine($"Produkt nicht auflager, konnte nicht hinzugefügt werden.");
                }
            }
        }

        public void Entfernen(string artikelnummer)
        {
            bool foundMatch = false;
            foreach (Produkt item in Produkte)
            {
                if (item.Artikelnummer == artikelnummer) 
                {
                    Produkte.Remove(item);
                    foundMatch = true;
                    item.ErweitereLagerbestand(1);
                    Console.WriteLine($"Produkt mit der Artikelnummer {artikelnummer} wurde entfernt.");
                    break;
                }
            }

            if (!foundMatch) 
            {
                Console.WriteLine($"Produkt mit der Artikelnummer {artikelnummer} wurde nicht im Warenkorb gefunden.");
            }

        }

        public void Anzeigen(bool mitPreise = true)
        {
            Console.WriteLine(new String('=', 40));
            Console.WriteLine($"Es sind folgende Artikel im Warenkorb:");
            Console.WriteLine(new String('=', 40));
            foreach (Produkt item in Produkte)
            {
                Console.WriteLine($"Produkt Name: {item.Name}");
                if (mitPreise) 
                {
                    Console.WriteLine($"Produkt Preis: {item.Preis} CHF");
                }
                Console.WriteLine(new String('-', 40));

            }
        }

    }
}
