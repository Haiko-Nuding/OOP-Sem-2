using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_11
{
    internal class Bankkonto
    {
        private decimal _saldo;

        public Bankkonto(decimal startGuthaben)
        {
            _saldo = startGuthaben;
            Console.WriteLine($"Konto eröffnet mit Startguthaben: {startGuthaben} CHF");
        }

        public void Einzahlen(decimal betrag)
        {
            if (betrag > 0)
            {
                _saldo += betrag;
                Console.WriteLine($"{betrag} CHF wurde eingezahlt.");
            }
            else 
            {
                Console.WriteLine($"Einzahlung fehlgeschlagen. Bitte geben Sie einen positiven betrag ein.");
            }
        }

        public void Auszahlen(decimal betrag)
        {
            if (betrag >= 0)
            {
                if (betrag <= _saldo)
                {
                    _saldo -= betrag;
                    Console.WriteLine($"{betrag} CHF wurde ausgezahlt.");
                }
                else
                {
                    Console.WriteLine($"Nicht genügend Saldo. Bitte einen anderen Betrag eingeben.");
                }
                
            }
            else 
            {
                Console.WriteLine($"Auszahlung fehlgeschlagen. Bitte geben Sie einen positiven betrag ein.");
            }
        }

        public void ZinsGutschrift(decimal zinssatzProzent)
        {
            decimal zins = _saldo * (zinssatzProzent / 100m);
            Console.WriteLine($"Zinsen ({zinssatzProzent}%): {zins} CHF wurden gutgeschrieben.");
            _saldo += zins;
        }

        public void SaldoAnzeigen() 
        {
            Console.WriteLine($"Ihr Saldo beträgt: {_saldo}");
        }
    }
}
