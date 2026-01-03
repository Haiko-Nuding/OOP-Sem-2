using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Drucker d1 = new Drucker("Drucker A");
            Drucker d2 = new Drucker("Drucker B");
            d1.Drucke("Dok1.pdf"); // Startet sofort
            d2.Drucke("Dok2.pdf"); // Wird blockiert (zu früh)
                                   // Warten wir etwas...
            System.Threading.Thread.Sleep(2500);
            d2.Drucke("Dok2.pdf"); // Jetzt erlaubt (Sperrzeit vorbei)
        }
    }
}
