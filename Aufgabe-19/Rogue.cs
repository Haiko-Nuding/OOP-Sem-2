using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_19
{
    public class Rogue : Character
    {
        public Rogue(string name, string secret) : base(name, secret) { }

        public override void Attack()
        {
            Console.WriteLine($"{Name} stabs quickly with twin daggers!");
        }

        public override void SpecialAbility()
        {
            Console.WriteLine($"{Name} vanishes into the shadows (Stealth)!");
        }
    }
}
