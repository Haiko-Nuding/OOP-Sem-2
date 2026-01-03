using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Character> party = new List<Character>();
            party.Add(new Warrior("Thorin", "Afraid of spiders", 50));
            party.Add(new Mage("Gandalf", "Lost his keys once", 100));
            party.Add(new Rogue("Valeera", "Secretly loves knitting"));

            foreach (var hero in party)
            {
                hero.Attack();          // Polymorphism in action
                hero.SpecialAbility();   // Every hero does something different
                hero.RevealIdentity();  // Using the private field via public method
                Console.WriteLine();
            }
        }
    }
}
