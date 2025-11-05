using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_12
{
    internal class Produkt
    {
        public string Artikelnummer { get; set; }
        public string Name { get; set; }
        public decimal Preis { get; set; }
        public string Kategorie { get; set; }
        private int _lagerbestand;

        public Produkt(string artikelnummer, string name, decimal preis, string kategorie, int laggerbestand) 
        {
            Artikelnummer = artikelnummer;
            Name = name;
            Preis = preis;
            Kategorie = kategorie;
            _lagerbestand = laggerbestand;
        }

        public void VerringereLagerbestand(int veringerung) 
        {
            if (_lagerbestand >= veringerung && veringerung > 0)
            {
                _lagerbestand -= veringerung;
            }
            else 
            {
                Console.WriteLine("Ungültige Verringerung des Lagerbestands.");
            }
        }

        public void ErweitereLagerbestand(int erweiterung)
        {
            if (erweiterung > 0)
            {
                _lagerbestand += erweiterung;
            }
            else
            {
                Console.WriteLine("Ungültige Erweiterung des Lagerbestands.");
            }
        }

        public void ZeigeLagerbestandInfo() 
        {
            Console.WriteLine($"Lagerbestand von Artikel {Name} beträgt: {_lagerbestand}");
        }

        public bool AufLager()
        {
            return _lagerbestand > 0;
        }

        public void PruefeLagerbestand() 
        {
            if (AufLager()) 
            {
                Console.WriteLine($"Produkt ist im Lager verfügbar.");
            }
            else
            {
                Console.WriteLine($"Produkt ist nicht im Lager verfügbar.");
            }
           
        }
    }
}
