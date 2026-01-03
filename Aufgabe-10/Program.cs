using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.Json;
using System.Text;
using System.Threading.Tasks;


namespace Aufgabe_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dateiName = "online_essen_daten.json";

            // --- 1. DATEN ERSTELLEN ---
            var daten = new Speichermodell();

            // Produkte erstellen
            var p1 = new Produkt { Id = 1, Name = "Burger", Preis = 12.0 };
            var p2 = new Produkt { Id = 2, Name = "Pizza", Preis = 15.0 };
            daten.Produkte.Add(p1);
            daten.Produkte.Add(p2);

            // Kunde erstellen und Produkte via ID zuweisen
            var k1 = new Kunde { Id = 1, Name = "Max", Adresse = "Weg 1" };
            k1.WarenkorbProduktIds.Add(1); // Bezieht sich auf Burger
            k1.WarenkorbProduktIds.Add(2); // Bezieht sich auf Pizza
            daten.Kunden.Add(k1);

            // Lieferung erstellen
            var l1 = new Lieferung { Id = 1, KundeId = 1, Status = "In Zustellung" };
            daten.Lieferungen.Add(l1);

            // --- 2. SERIALISIERUNG (Speichern) ---
            var optionen = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(daten, optionen);
            File.WriteAllText(dateiName, jsonString);

            Console.WriteLine("Objekte wurden serialisiert und gespeichert.");

            // --- 3. WIEDERHERSTELLUNG (Einlesen) ---
            string gelesenerJson = File.ReadAllText(dateiName);
            Speichermodell geladeneDaten = JsonSerializer.Deserialize<Speichermodell>(gelesenerJson);

            // --- 4. TEST DER WIEDERHERSTELLUNG ---
            Console.WriteLine("\n--- Geladene Daten aus JSON ---");
            foreach (var kunde in geladeneDaten.Kunden)
            {
                Console.WriteLine($"Kunde: {kunde.Name} hat bestellt:");
                foreach (var pId in kunde.WarenkorbProduktIds)
                {
                    // Das Produkt anhand der ID in der Liste suchen (wie ein SQL JOIN)
                    var gefundenesProdukt = geladeneDaten.Produkte.FirstOrDefault(p => p.Id == pId);
                    if (gefundenesProdukt != null)
                    {
                        Console.WriteLine($"- {gefundenesProdukt.Name} ({gefundenesProdukt.Preis} CHF)");
                    }
                }
            }

            foreach (var lieferung in geladeneDaten.Lieferungen)
            {
                var zielKunde = geladeneDaten.Kunden.FirstOrDefault(k => k.Id == lieferung.KundeId);
                Console.WriteLine($"Lieferung {lieferung.Id} für {zielKunde?.Name}: Status {lieferung.Status}");
            }

            Console.ReadKey();
        }
    }
}
