using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Art saugeTier = new Art("Säugetier");
            Tier erdmaennchen = new Tier("Erdmännchen", 2, saugeTier);
            Gehege gehege = new Gehege("200m^2", 4, 1996);
            Pfleger pfleger_haiko = new Pfleger("Haiko", "Ramuzstrasse 15", "+41 79 507 26 45");
            Futterung erdmaenchenFutterung = new Futterung("Erdmänchen Essen", 233.4);

            gehege.TierHinzufuegen(erdmaennchen);
            gehege.TierHinzufuegen(erdmaennchen);
            gehege.TierHinzufuegen(erdmaennchen);
            gehege.TierHinzufuegen(erdmaennchen);
            gehege.PflegerHinzufuegen(pfleger_haiko);

            Console.WriteLine(gehege.AnzahlTiere);
            gehege.Info();

            if (erdmaenchenFutterung.IstAelterAls3Jahre()) 
            {
                erdmaenchenFutterung = null;
            }

        }
    }
}
