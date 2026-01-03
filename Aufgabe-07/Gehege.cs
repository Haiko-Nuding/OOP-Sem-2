using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_07
{
    internal class Gehege
    {
        private int _maximaleAnzahlTiere;
        public string Groesse { get; set; }
        public int MaximaleAnzahlTiere
        {
            get => _maximaleAnzahlTiere;
            set
            {
                if (AnzahlTiere > value) Console.WriteLine("Wert ist zu klein für aktuellen Bestand");
                else _maximaleAnzahlTiere = value;
            }
        }
        public int Baujahr { get; set; }
        public List<Tier> TiereListe { get; set; } = new List<Tier>();
        public List<Pfleger> PflegerListe { get; set; } = new List<Pfleger>();

        public int AnzahlTiere => TiereListe.Count;

        public Gehege() { }
        public Gehege(string groesse, int maximaleAnzahlTiere, int baujahr)
        {
            Groesse = groesse;
            MaximaleAnzahlTiere = maximaleAnzahlTiere;
            Baujahr = baujahr;
        }

        public bool TierHinzufuegen(Tier neuesTier)
        {
            if (AnzahlTiere >= MaximaleAnzahlTiere) return false;
            TiereListe.Add(neuesTier);
            return true;
        }

        public void PflegerHinzufuegen(Pfleger pfleger) => PflegerListe.Add(pfleger);

        public void Info()
        {
            Console.WriteLine($"Gehege ({Groesse}, Baujahr {Baujahr})");
            Console.WriteLine($"Tiere: {string.Join(", ", TiereListe.Select(t => t.Name))}");
            Console.WriteLine($"Pfleger: {string.Join(", ", PflegerListe.Select(p => p.Name))}");
        }
    }
}
