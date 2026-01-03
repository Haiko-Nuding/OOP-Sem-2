using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_10
{
    public class Lieferung : BaseEntity
    {
        public string Status { get; set; }
        public int KundeId { get; set; } // Fremdschlüssel-Referenz
    }
}
