using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vorbereitung_Test_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bankkonto = new Bankkonto();
            bankkonto.Passwort = "1";

            var bankkontoHaiko = new Bankkonto();
            bankkontoHaiko.Passwort = "0123456789";
        }
    }
}
