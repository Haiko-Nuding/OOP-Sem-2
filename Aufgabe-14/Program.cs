using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Erstellen von Instanzen
            Ticket t1 = new Ticket("Konzert", 45.00);
            Ticket t2 = new Ticket("Kino", 15.00);
            Ticket t3 = new Ticket("Fussballspiel", 30.00);

            // Auslesen über die statische Methode
            Console.WriteLine($"Anzahl verkaufter Tickets: {Ticket.GetTicketCount()}");
        }
    }
}
