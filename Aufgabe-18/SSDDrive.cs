using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_18
{
    public class SSDDrive : StorageDevice
    {
        public int Tbw { get; set; } // Terabytes Written
        public string Controller { get; set; }

        public SSDDrive(string manufacturer, int capacityGB, double readSpeed, double writeSpeed, int tbw, string controller)
            : base(manufacturer, capacityGB, readSpeed, writeSpeed)
        {
            Tbw = tbw;
            Controller = controller;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"SSD Specs: Controller: {Controller}, Lebensdauer: {Tbw} TBW");
        }

        public override void Benchmark()
        {
            Console.WriteLine($"SSD Benchmark: Random IOPS Test auf {Controller} Controller...");
        }
    }
}
