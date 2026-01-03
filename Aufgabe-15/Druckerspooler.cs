using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aufgabe_15
{
    internal class Druckerspooler
    {
        private static bool gesperrt = false;


        public static void Drucken(string druckerName, string dokument)
        {
            if (gesperrt)
            {
                Console.WriteLine(
                    $"Drucker {druckerName}: Spooler ist noch gesperrt - '{dokument}' kann nicht starten."
                );
                return;
            }

            Console.WriteLine(
                $"Drucker {druckerName}: Startet Druck von '{dokument}'."
            );

            gesperrt = true;

            // Sperre nach 2 Sekunden automatisch aufheben
            new Thread(() =>
            {
                Thread.Sleep(2000);
                gesperrt = false;
            }).Start();
        }
    }
}
