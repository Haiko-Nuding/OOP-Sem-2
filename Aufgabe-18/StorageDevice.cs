using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_18
{
    public abstract class StorageDevice
    {
        // Gemeinsame Felder/Eigenschaften
        public string Manufacturer { get; set; }
        public int CapacityGB { get; set; }
        public double ReadSpeedMBps { get; set; }
        public double WriteSpeedMBps { get; set; }

        protected StorageDevice(string manufacturer, int capacityGB, double readSpeed, double writeSpeed)
        {
            Manufacturer = manufacturer;
            CapacityGB = capacityGB;
            ReadSpeedMBps = readSpeed;
            WriteSpeedMBps = writeSpeed;
        }

        // Gemeinsame Logik für alle
        public void Format()
        {
            Console.WriteLine($"{Manufacturer} Laufwerk ({CapacityGB}GB) wird formatiert...");
        }

        // Virtuelle Methode: Standard-Verhalten, das überschrieben werden kann
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"--- {this.GetType().Name} ---");
            Console.WriteLine($"Hersteller: {Manufacturer}, Kapazität: {CapacityGB}GB");
            Console.WriteLine($"Speed: R:{ReadSpeedMBps}MB/s | W:{WriteSpeedMBps}MB/s");
        }

        // Abstrakte Methode: Jedes Laufwerk MUSS einen Benchmark anders ausführen
        public abstract void Benchmark();
    }
}
