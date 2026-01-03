using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_19
{
    public class Warrior : Character
    {
        public int ArmorStrength { get; set; }

        public Warrior(string name, string secret, int armor) : base(name, secret)
        {
            ArmorStrength = armor;
        }

        public override void Attack()
        {
            Console.WriteLine($"{Name} swings a massive broadsword!");
        }

        public override void SpecialAbility()
        {
            Console.WriteLine($"{Name} uses 'Shield Bash' with {ArmorStrength} power!");
        }
    }
}
