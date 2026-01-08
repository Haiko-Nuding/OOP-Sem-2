using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UbeungsTestGeloest
{
    internal class Computer: Geraet
    {
        public int ArbeitsspeicherGb { get; set; }
        public int SpeicherplatzGb { get; set; }

        public Computer(string sn, string hersteller, int baujahr, GeraetKategorie kategorie, Zustand zustand, int ap, int sp) 
            : base (sn, hersteller, baujahr, kategorie, zustand)
        {
            this.ArbeitsspeicherGb = ap;
            this.SpeicherplatzGb = sp;
        }

        public override string ZeigeEigenschaften()
        {
            return $"[Computer] Seriennummer {Seriennummer}, Hersteller: {Hersteller}, Baujahr: {Baujahr}, Kategorie: {Kategorie}, Zustand: {Zustand}, ArbeitsspeicherGb: {ArbeitsspeicherGb}, SpeicherplatzGb: {SpeicherplatzGb}";
        }
    }
}
