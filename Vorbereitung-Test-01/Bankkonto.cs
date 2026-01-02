using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vorbereitung_Test_01
{
    internal class Bankkonto
    {
        private string passwort;

        public string BenutzerName { get; set; }

        public string Passwort
        {
            set 
            {
                if (value.Length >= 10)
                {
                    passwort = value;
                    Console.WriteLine("Passwort wurde gesetzt.");
                }
                else
                {
                    Console.WriteLine("Passwort muss mindestens 10 Zeichen lang sein.");
                }
            }
        }

        public Bankkonto() { }

        public Bankkonto(string benutzerName) 
        {
            BenutzerName = benutzerName;   
        }
    }
}
