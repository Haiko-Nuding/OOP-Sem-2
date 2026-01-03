using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_08
{
    internal class Produkt
    {
        public string Name { get; set; }
        public double Preis { get; set; }

        public Produkt(string name, double preis)
        {
            Name = name;
            Preis = preis;
        }
    }
}
