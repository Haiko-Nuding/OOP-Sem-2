using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_05
{
    internal class Gehege
    {
        private int _maximaleAnzahlTiere;
        public string Groesse { get; set; }
        public int MaximaleAnzahlTiere
        {
            get
            {
                return _maximaleAnzahlTiere;
            }
            set
            {
                if (AnzahlTiere > value)
                {
                    Console.WriteLine("Wert is zu gross");
                }
                else
                {
                    _maximaleAnzahlTiere = value;
                }
            }
        }
        public int Baujahr { get; set; }
        List<Tier> TiereListe { get; set; } = new List<Tier>();
        List<Pfleger> PflegerListe { get; set; } = new List<Pfleger>();


        public int AnzahlTiere
        {
            get
            {
                return TiereListe.Count;
            }
        }
        public Gehege() { }

        public Gehege(string groesse, int maximaleAnzahlTiere, int baujahr)
        {
            Groesse = groesse;
            MaximaleAnzahlTiere = maximaleAnzahlTiere;
            Baujahr = baujahr;
        }

        public bool TierHinzufuegen(Tier neuesTier)
        {
            if (AnzahlTiere >= MaximaleAnzahlTiere)
            {
                Console.WriteLine($"Kann Tier {neuesTier.Name} nicht hinzufügen – Gehege ist voll.");
                return false;
            }
            TiereListe.Add(neuesTier);
            return true;
        }

        public void TierLoeschen(Tier tier)
        {
            TiereListe.Remove(tier);
        }

        public void PflegerHinzufuegen(Pfleger pfleger)
        {
            PflegerListe.Add(pfleger);
        }

        public void PflegerLöschen(Pfleger pfleger)
        {
            PflegerListe.Remove(pfleger);
        }
        public void Info()
        {
            Console.WriteLine(
                $"Informationen von Gehege: \n" +
                $"Grösse: {Groesse}\n" +
                $"Maximale Anzahl Tiere: {MaximaleAnzahlTiere}\n" +
                $"Baujahr: {Baujahr}\n" +
                $"Tier Liste: {string.Join(", ", TiereListe.Select(t => t.Name))}\n" +
                $"Pfleger Liste: {string.Join(", ", PflegerListe.Select(p => p.Name))}\n" +
                $"Anzahl Tiere: {AnzahlTiere}"
                );
        }
    }
}
