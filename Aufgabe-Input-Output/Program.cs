using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;


namespace Aufgabe_Input_Output
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string outputPath = @"Output/book.json";
            WriteJSONFile(outputPath);
        }

        public static void ReadTextFile()
        {
            string inputTextPath = @"Input/tmp.txt";
            // Zeige das aktuelle Arbeitsverzeichnis
            Console.WriteLine("Aktuelles Arbeitsverzeichnis:");
            Console.WriteLine(Environment.CurrentDirectory);

            if (File.Exists(inputTextPath))
            {
                string content = File.ReadAllText(inputTextPath);

                Console.WriteLine(content);
                Console.WriteLine(new string('-', 10));

                List<string> contentPerRow = new List<string>(File.ReadAllLines(inputTextPath));
                foreach (string line in contentPerRow)
                {
                    Console.WriteLine(line);
                }
                string outputText = @"Output/tmp.txt";
                File.WriteAllText(outputText, inputTextPath);
            }
        }

        public static void WriteJSONFile(string outputPath)
        {
            Book book1 = new Book(1, "Titel", "Haiko", 2025);
            // Installed Nuget: System.Text.Json;
            var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(book1, jsonOptions);

            // 2. DEN STRING IN EINE DATEI SPEICHERN (Das fehlende Stück)
            string fileName = outputPath;

            // File.WriteAllText kommt aus System.IO und schreibt den String in die Datei.
            File.WriteAllText(fileName, jsonString);

            // Optionale Ausgabe zur Bestätigung:
            System.Console.WriteLine($"Datei '{fileName}' erfolgreich geschrieben.");
        }
    }
}
