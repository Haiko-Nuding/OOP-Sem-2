using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UbeungsTestGeloest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Geraet> gereatListe = new List<Geraet>();

            Computer thinkPad = new Computer("computer", "lenevo", 2003, GeraetKategorie.Computer, Zustand.Neu, 16, 2000);
            Multimeter multimeter = new Multimeter("multimeter", "samsung", 2000, GeraetKategorie.Messgeraet, Zustand.Defekt, false, 20);
            Akkuschrauber akkuschrauber = new Akkuschrauber("Akkuschreiber", "Bost", 2003, GeraetKategorie.Werkzeug, Zustand.Gut, 200, true);

            gereatListe.Add(akkuschrauber);
            gereatListe.Add(multimeter);
            gereatListe.Add(thinkPad);

            foreach (var geraet in gereatListe)
            {
                Console.WriteLine(geraet.ZeigeEigenschaften());
            }

        }
    }
}
