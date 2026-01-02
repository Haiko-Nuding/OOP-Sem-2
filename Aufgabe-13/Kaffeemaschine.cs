using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_13
{
    internal class Kaffeemaschine
    {

        // --- Felder (Interne Zustände) ---
        private double _aktuellerWasserstand;
        private int _aktuellerBohnenstand;
        private int _kaffeesatzZaehler;

        // --- Konfiguration (Read-only/Konstanten) ---
        private readonly double _maxWasser = 2.0;
        private readonly int _maxBohnen = 250;
        private readonly int _maxSatz = 10;
        private readonly double _wasserProKaffee = 0.2;
        private readonly int _bohnenProKaffee = 10;

        // Konstruktor
        public Kaffeemaschine()
        {
            WASSERAUFFUELLEN();
            BOHNENAUFFUELLEN();
            _kaffeesatzZaehler = 0;
        }

        public void KAFFEEZUBEREITEN()
        {
            // Verbraucht Wasser, Bohnen, erhöht Satzbehälter

            // 1. Bedingungen prüfen
            if (_aktuellerWasserstand < _wasserProKaffee)
            {
                Console.WriteLine("Fehler: Bitte Wasser auffüllen!");
            }
            else if (_aktuellerBohnenstand < _bohnenProKaffee)
            {
                Console.WriteLine("Fehler: Bitte Bohnen auffüllen!");
            }
            else if (_kaffeesatzZaehler >= _maxSatz)
            {
                Console.WriteLine("Fehler: Satzbehälter voll! Bitte leeren.");
            }
            else
            {
                // 2. Zustandsübergang ausführen
                _aktuellerWasserstand -= _wasserProKaffee;
                _aktuellerBohnenstand -= _bohnenProKaffee;
                _kaffeesatzZaehler++;

                Console.WriteLine("Kaffee wird zubereitet... Fertig!");
            }
        }

        public void WASSERAUFFUELLEN() 
        {
            // Füllt Wassertank vollständig auf
            _aktuellerWasserstand = _maxWasser;
            Console.WriteLine($"Wasserbehälter ist nun voll {_maxWasser}L.");
        }

        public void BOHNENAUFFUELLEN()
        {
            // Füllt Bohnen vollständig auf
            _aktuellerBohnenstand = _maxBohnen;
            Console.WriteLine($"Bohnenbehälter ist nun voll {_maxBohnen}g.");
        }

        public void SATZBEHAELTERLEEREN()
        {
            // Setzt Kaffeesatz-Zähler auf 0
            _kaffeesatzZaehler = 0;
            Console.WriteLine("Satzbehälter wurde geleert.");
        }

        public void StatusAnzeigen()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Wasser: {_aktuellerWasserstand:F1}L | Bohnen: {_aktuellerBohnenstand}g | Abfall: {_kaffeesatzZaehler}/{_maxSatz}");
            Console.WriteLine("------------------------------------");
        }
    }
}
