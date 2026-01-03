using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Jetzt: Eine gemeinsame Liste vom Typ der Superklasse
            List<StorageDevice> myDevices = new List<StorageDevice>();

            myDevices.Add(new HDDDrive("Seagate", 2000, 150, 140, 7200, 8.5));
            myDevices.Add(new SSDDrive("Samsung", 1000, 3500, 3000, 600, "Phoenix"));

            foreach (StorageDevice device in myDevices)
            {
                // Kein Casting ( (SSDDrive)device ) oder "is" Prüfungen mehr nötig!
                device.DisplayInfo();
                device.Benchmark();
                device.Format();
                Console.WriteLine();
            }
        }
    }
}
