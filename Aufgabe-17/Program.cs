using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Klimaanlage erzeugen
            Klimaanlage klima = new Klimaanlage();

            // Aktuelle Temperatur setzen
            klima.AktuelleTemperatur = 20.0;

            // Zieltemperatur setzen → Modus wird automatisch angepasst
            klima.ZielTemperatur = 22.0;
            klima.StatusAnzeigen();  // Heizen

            klima.ZielTemperatur = 20.0;
            klima.StatusAnzeigen();  // Off

            klima.ZielTemperatur = 18.0;
            klima.StatusAnzeigen();  // Kuehlen
        }
    }
}
