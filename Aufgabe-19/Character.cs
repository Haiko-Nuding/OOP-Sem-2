using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_19
{
    public abstract class Character
    {
        public string Name { get; set; }
        public int Level { get; set; }

        // Requirement: Private property used within the class
        private string SecretIdentity { get; set; }

        protected Character(string name, string secret)
        {
            Name = name;
            Level = 1;
            SecretIdentity = secret;
        }

        // Requirement: Non-virtual method (Logic is the same for everyone)
        public void RevealIdentity()
        {
            Console.WriteLine($"{Name}'s secret is: {SecretIdentity}");
        }

        // Requirement: Virtual method (Default behavior, can be overridden)
        public virtual void Attack()
        {
            Console.WriteLine($"{Name} performs a basic physical strike!");
        }

        // Abstract method (Forces subclasses to define their unique skill)
        public abstract void SpecialAbility();
    }
}
