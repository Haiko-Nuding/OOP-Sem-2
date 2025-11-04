using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bankkonto konto = new Bankkonto(1000);
            konto.Einzahlen(200);
            konto.Auszahlen(150);
            konto.ZinsGutschrift(1.5m);
            konto.SaldoAnzeigen();

            // Test 01: This should fail
            konto.Auszahlen(90000);
            konto.SaldoAnzeigen();

            // Test 02: This should work
            konto.Auszahlen(1000);
            konto.SaldoAnzeigen();

            // Test 03: Testing negative values for 'Einzahlen' function
            konto.Einzahlen(-200);
            konto.SaldoAnzeigen();

            // Test 04: Testing negative values for 'Auszahlen' function
            konto.Auszahlen(-1000);
            konto.SaldoAnzeigen();
        }
    }
}
