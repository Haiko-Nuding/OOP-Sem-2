using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Aufgabe-01: Variablen
            // Description: Notieren Sie drei gültige Deklarationen für primitive Datentypen

            // 1. Einfache Variablendeklaration
            int age;

            // 2. Mehrere Variablen gleichen Typs deklarieren
            int pageNumber, total;

            // 3. Deklaration mit gleichzeitiger Initialisierung
            int counter = 0;

            // Aufgabe 01: Schreiben Sie ein Programm, welches aus der Eingabe des Geburtsdatums das Alter in Tagen berechnet!
            int userDay;
            int userMonth;
            int userYear;

            int daysOfmonth = 31; // used to know how many day the month has, default value is 31
            Func<int, bool> userDayCondition = (input) => input > 0 && input <= daysOfmonth;
            Func<int, bool> userMonthCondition = (input) => input > 0 && input <= 12;
            Func<int, bool> userYearhCondition = (input) => input > 1900 && input <= DateTime.Now.Year;

            string requestMessageDay = "Bitte Tag des Geburtstags eingeben: ";
            string requestMessageMonth = "Bitte Monat des Geburtstags eingeben: ";
            string requestMessageYear = "Bitte Jahr des Geburtstags eingeben: ";

            string errMessageDay = "Bitte gib einen realistischen Tag ein.";
            string errMessageMonth = "Bitte gib einen realistischen Monat ein.";
            string errMessageYear = "Bitte gib ein realistisches jahr ein.";


            userDay = userInputValidiator(userDayCondition, requestMessageDay, errMessageDay);
            userMonth = userInputValidiator(userMonthCondition, requestMessageMonth, errMessageMonth);
            userYear = userInputValidiator(userYearhCondition, requestMessageYear, errMessageYear);

            int tmpDaysOfmonth = DateTime.DaysInMonth(userYear, userMonth);

            if (userDay > tmpDaysOfmonth)
            {
                Console.WriteLine($"Im Jahr {userYear} und Monat {userMonth}, gab es nur {tmpDaysOfmonth}.");
                Console.WriteLine("Bitte Einagbe für Tag des Geburtstags neu eingeben");
                daysOfmonth = tmpDaysOfmonth;
                userDay = userInputValidiator(userDayCondition, requestMessageDay, errMessageDay);
            }

            
            DateTime userBirthDay = new DateTime(userYear, userMonth, userDay);
            DateTime today = DateTime.Today;

            // Differenz berechnen
            TimeSpan difference = today - userBirthDay;

            // Anzahl Tage
            int daysPassed = difference.Days;
            Console.WriteLine($"Du bist {daysPassed} Tage alt.");
        }

        static int userInputValidiator(Func<int, bool> condition, string requestMessage ,string errMessage)
        {
            int userInput;
            while (true)
            {
                Console.Write(requestMessage);
                string inputBirthDay = Console.ReadLine();

                // Prüfen, ob die Eingabe eine gültige Zahl ist
                if (int.TryParse(inputBirthDay, out userInput))
                {
                    // Basis Tag validierun
                    if (condition(userInput))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine(errMessage);
                    }
                }
                else
                {
                    Console.WriteLine("Ungültige Zahl. Versuch es erneut.");
                }
            }

            return userInput;
        }

    }
}
