using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_15
{
    internal class Drucker
    {
        private string name;

        public Drucker(string name) 
        {
            this.name = name;
        }

        public void Drucke(string dokument) 
        {
            Druckerspooler.Drucken(name, dokument);
        }


    }
}
