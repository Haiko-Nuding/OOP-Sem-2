using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_16
{
    internal class FilePrinter
    {
        // Build it:  csc FilePrinter.cs
        // TEST IT: FilePrinter.exe TestFile.txt TOP 1
        static void Main(string[] args)
        {

            if (args.Length == 0)
            {
                PrintUsage("Fehler: Keine Parameter angegeben.");
                return;
            }

            
            if (args.Length != 1 && args.Length != 3)
            {
                PrintUsage("Fehler: Ungültige Parameteranzahl.");
                return;
            }

            string fileName = args[0];

            
            if (!File.Exists(fileName))
            {
                Console.Error.WriteLine($"Fehler: Datei existiert nicht: {fileName}");
                return;
            }

            int? top = null;

            // 4️⃣ Optional: TOP n prüfen
            if (args.Length == 3)
            {
                if (!args[1].Equals("TOP", StringComparison.OrdinalIgnoreCase))
                {
                    PrintUsage("Fehler: Erwartet 'TOP <Zahl>'.");
                    return;
                }

                if (!int.TryParse(args[2], out int n) || n < 0)
                {
                    PrintUsage("Fehler: Nach TOP muss eine gültige Zahl folgen.");
                    return;
                }

                top = n;
            }

           
            PrintFile(fileName, top);
        }

        static void PrintFile(string fileName, int? top)
        {
            int lineCount = 0;

            foreach (string line in File.ReadLines(fileName))
            {
                Console.WriteLine(line);
                lineCount++;

                if (top.HasValue && lineCount >= top.Value)
                    break;
            }
        }

        static void PrintUsage(string message)
        {
            Console.Error.WriteLine(message);
            Console.Error.WriteLine("Beispielaufrufe:");
            Console.Error.WriteLine("  FilePrinter <Dateiname>");
            Console.Error.WriteLine("  FilePrinter <Dateiname> TOP <Zahl>");
        }
    }
}
