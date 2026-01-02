using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kaffeemaschine meineMaschine = new Kaffeemaschine();

            // Test 1: Mehrere Kaffees beziehen
            for (int i = 0; i < 11; i++)
            {
                Console.Write($"Kaffee Nr. {i + 1}: ");
                meineMaschine.KAFFEEZUBEREITEN();
            }

            // Status prüfen (Sollte anzeigen, dass der Behälter voll ist)
            meineMaschine.StatusAnzeigen();

            Console.WriteLine("Test 2: Wartung durchführen.");

            // Test 2: Wartung durchführen
            meineMaschine.SATZBEHAELTERLEEREN();
            meineMaschine.KAFFEEZUBEREITEN(); // Jetzt klappt es wieder

            meineMaschine.StatusAnzeigen();
        }
    }
}
