using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_18
{
    public class HDDDrive : StorageDevice
    {
        public int Rpm { get; set; }
        public double SeekTimeMs { get; set; }

        public HDDDrive(string manufacturer, int capacityGB, double readSpeed, double writeSpeed, int rpm, double seekTime)
            : base(manufacturer, capacityGB, readSpeed, writeSpeed)
        {
            Rpm = rpm;
            SeekTimeMs = seekTime;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo(); // Ruft Basis-Infos auf
            Console.WriteLine($"HDD Specs: {Rpm} RPM, Zugriffszeit: {SeekTimeMs}ms");
        }

        public override void Benchmark()
        {
            Console.WriteLine($"HDD Benchmark: Sequentielles Lesen bei {Rpm} RPM gestartet...");
        }
    }
}
