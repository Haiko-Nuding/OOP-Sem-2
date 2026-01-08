using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UbeungsTestGeloest
{
    internal class Multimeter: Geraet
    {
        public bool IstDigital { get; set; }
        public int MaxSpannungVolt { get; set; }

        public Multimeter(string sn, string hersteller, int baujahr, GeraetKategorie kategorie, Zustand zustand, bool isDigital, int maxSpannungVolt) 
            : base(sn, hersteller, baujahr, kategorie, zustand)
        {
            this.IstDigital = isDigital;
            this.MaxSpannungVolt = maxSpannungVolt;
        }

        public override string ZeigeEigenschaften()
        {
            return $"[Multimeter] Seriennummer: {Seriennummer}, Hersteller: {Hersteller}, Baujahr: {Baujahr}, Kategorie: {Kategorie}, Zustand: {Zustand}, IstDigital: {IstDigital}, MaxSpannungVolt: {MaxSpannungVolt}";
        }
    }
}
