using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_19
{
    // --- Subclass 2: Mage ---
    public class Mage : Character
    {
        public int Mana { get; set; }

        public Mage(string name, string secret, int mana) : base(name, secret)
        {
            Mana = mana;
        }

        // Mage keeps the virtual Attack() as is, but defines SpecialAbility
        public override void SpecialAbility()
        {
            Console.WriteLine($"{Name} casts 'Fireball' costing {Mana / 2} mana!");
        }
    }
}
