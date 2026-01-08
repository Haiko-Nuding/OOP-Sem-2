using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UbeungsTestGeloest
{
    internal class Geraet
    {
        public string Seriennummer { get; set; }
        public string Hersteller { get; set; }
        public int Baujahr { get; set; }

        public GeraetKategorie Kategorie { get; set; } = GeraetKategorie.Messgeraet;
        public Zustand Zustand { get; set; } = Zustand.Gut;

        public Geraet(string sn, string hersteller, int baujahr, GeraetKategorie kategorie, Zustand zustand)
        {
            this.Seriennummer = sn;
            this.Hersteller = hersteller;
            this.Baujahr = baujahr;
            this.Kategorie = kategorie;
            this.Zustand = zustand;
        }

        public virtual string ZeigeEigenschaften()
        {
            return $"[Geraet] Seriennummer: {Seriennummer}, Hersteller: {Hersteller}, Baujahr: {Baujahr}, Kategorie: {Kategorie}, Zustand: {Zustand}";
        }
    }
}
