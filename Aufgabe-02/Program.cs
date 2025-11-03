using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte Geben Sie einen Satz ein!");
            string[] words = Console.ReadLine().Split(' ');

            int longestWordPosition = 1;
            int longestWordLength = words[0].Length;
            string longestWord = words[0];
            int position = 1; 
            foreach (string word in words)
            {

                if (word.Length > longestWordLength) {
                    longestWord = word;
                    longestWordLength = word.Length;
                    longestWordPosition = position;
                }
                position += word.Length; // Positon nach Char, wenn man Positon nach Wort will einfach: position ++;
            }

            Console.WriteLine($"Postion längstes Wort:{longestWordPosition}");
            Console.WriteLine($"Länge längstes Wort:{longestWordLength}");
            Console.WriteLine($"Das längste Wort lautet '{longestWord}'");

        }
    }
}
