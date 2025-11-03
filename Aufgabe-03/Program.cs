using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aufgabe_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // Wenn eine Taste gedrückt wird:
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true); // true = nicht anzeigen   

                    // Prüfen ob CTRL + X gedrückt wurde
                    if (key.Modifiers.HasFlag(ConsoleModifiers.Control) && key.Key == ConsoleKey.X)
                    {
                        Console.WriteLine("\nProgramm wird beendet...");
                        break; // Endlosschleife verlassen
                    }
                }

                string time = DateTime.Now.ToString("HH:mm:ss");
                Console.Write($"\rAktuelle Uhrzeit: " + time);
                Thread.Sleep(1000); // 1 Sekunde warten
            }
        }
    }
}
