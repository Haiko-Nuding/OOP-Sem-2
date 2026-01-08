using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UbeungsTestGeloest
{
    internal class Akkuschrauber : Geraet
    {
        public int DrehmomentNm { get; set; }
        public bool HatSchlagfunktion { get; set; }
        public Akkuschrauber(string sn, string hersteller, int baujahr, GeraetKategorie kategorie, Zustand zustand, int drehM, bool hatF) 
            : base(sn, hersteller, baujahr, kategorie, zustand)
        {
            this.DrehmomentNm = drehM;
            this.HatSchlagfunktion = hatF;
        }

        public override string ZeigeEigenschaften()
        {
            return $"[Akkuschrauber] Seriennummer: {Seriennummer}, Hersteller: {Hersteller}, Baujahr: {Baujahr}, Kategorie: {Kategorie}, Zustand: {Zustand}, DrehmomentNm: {DrehmomentNm}, HatSchlagfunktion: {HatSchlagfunktion}";
        }
    }
}
