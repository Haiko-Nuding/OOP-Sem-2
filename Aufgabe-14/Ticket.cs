using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_14
{
    internal class Ticket
    {
        private static int _ticketCount = 0;

        public string EventName { get; set; }
        public double Price { get; set; }

        public Ticket(string eventName, double price)
        {
            EventName = eventName;
            Price = price;

            _ticketCount++;
        }

        public static int GetTicketCount()
        {
            return _ticketCount;
        }
    }
}
