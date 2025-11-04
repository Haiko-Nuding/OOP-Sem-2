using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> userTipps = getUserTipps();
            List<int> randomTipps = generateRandomTipps();

            List<int> matches = evaluateMatches(randomTipps, userTipps);

            showResuslt(matches);
        }

        static List<int> evaluateMatches(List<int> randomTipps, List<int> userTipps)
        {
            List<int> matches = new List<int>();

            List<int> tmpRandomTipps = randomTipps;
            for (int i = 0; i < userTipps.Count; i++)
            {
                if (tmpRandomTipps.Contains(userTipps[i]))
                {
                    tmpRandomTipps.Remove(userTipps[i]);
                    matches.Add(userTipps[i]);
                }
            }

            return matches;
        }

        static List<int> generateRandomTipps(int amountTipps = 6)
        {
            Random rnd = new Random();
            List<int> randomTipps = new List<int>();

            for (int i = 0; i < amountTipps; i++)
            {
                int randomNumber = rnd.Next(1, 46); // 1 to 45 inclusive
                randomTipps.Add(randomNumber);
            }

            Console.WriteLine("Es wurden folgende Zahlen gezogen: ");
            Console.WriteLine(string.Join(" ", randomTipps));

            return randomTipps;
        }

        static List<int> getUserTipps()
        {
            Console.WriteLine("Bitte geben Sie Ihre Tipps ab (1-45)");
            List<int> userTipps = new List<int>();

            for (int i = 0; i < 6; i++)
            {
                userTipps.Add(askUserTippEntry(userTipps));
            }

            return userTipps;

        }

        static int askUserTippEntry(List<int> userTipps, int start = 0, int end = 45)
        {

            int userInput;
            while (true)
            {
                Console.Write($"Tipp {userTipps.Count + 1}: ");
                string tmpUserInput = Console.ReadLine();
                if (int.TryParse(tmpUserInput, out userInput))
                {

                    if (userInput > start && userInput <= end)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Benutzer eingabe muss zwischen 1-45 sein!");
                    }

                }
                else
                {
                    Console.WriteLine("Ungültige Zahl. Versuch es erneut.");
                }
            }

            return userInput;
        }

        static void showResuslt(List<int> matches)
        {
            foreach (int match in matches)
            {
                Console.WriteLine($"Treffer: {match}");
            }

            Console.WriteLine($"Sie haben {matches.Count} Treffer erzielt.");
        }
    }
}
