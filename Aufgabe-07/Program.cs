using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Instanzen von Art
            Art saugeTier = new Art("Säugetier");
            Art reptil = new Art("Reptil");

            // 2. Instanzen von Tier
            Tier erdmaennchen = new Tier("Erdmännchen", 2, saugeTier);
            Tier loewe = new Tier("Löwe", 5, saugeTier);
            Tier leguan = new Tier("Leguan", 3, reptil);
            Tier schildkroete = new Tier("Schildkröte", 50, reptil);

            // 3. Instanzen von Pfleger
            Pfleger pfleger_haiko = new Pfleger("Haiko", "Ramuzstrasse 15", "+41 79 507 26 45");
            Pfleger pfleger_anna = new Pfleger("Anna", "Bahnhofstrasse 10", "+41 78 123 45 67");

            // 4. Instanzen von Gehege
            Gehege gehege1 = new Gehege("200m^2", 4, 1996);
            Gehege gehege2 = new Gehege("500m^2", 2, 2010);

            // Zuweisungen zu Gehege 1
            gehege1.TierHinzufuegen(erdmaennchen);
            gehege1.TierHinzufuegen(loewe);
            gehege1.PflegerHinzufuegen(pfleger_haiko);

            // Zuweisungen zu Gehege 2
            gehege2.TierHinzufuegen(leguan);
            gehege2.TierHinzufuegen(schildkroete);
            gehege2.PflegerHinzufuegen(pfleger_anna);

            // 5. Instanzen von Fütterung
            Futterung futter1 = new Futterung("Fleischmix", 5.5);
            Futterung futter2 = new Futterung("Gemüseschale", 1.2);

            futter1.Gehege = gehege1;
            futter2.Gehege = gehege2;

            // Ausgabe zur Kontrolle
            gehege1.Info();
            Console.WriteLine("-------------------------");
            gehege2.Info();

            Console.ReadLine();
        }
    }
}
