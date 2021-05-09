using System;
using System.Collections.Generic;
using System.Linq;

namespace Durchschnittsrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Durchschnittsrechner V4.0.1";

            Program.Programm();

            ConsoleKeyInfo input;

            do
            {
                input = Console.ReadKey();
                if (input.Key != ConsoleKey.Enter)
                {
                    Console.Clear();
                    Program.Programm();
                }
            } while (input.Key != ConsoleKey.Enter);


        }
        static void Programm()
        {
            // Code
            int count;

            int countH;

            int gewicht;

            double result;

            List<string> Noten = new List<string>();

            List<string> Hauptfachnoten = new List<string>();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Notendurchschnittsrechner by Rafael Wickberg // GLifeDE");

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(" ");
            Console.WriteLine("Drücke A um in den Einreichungsnoten-Modus zu betreten");
            Console.WriteLine("Type C to change the language into english");
            Console.WriteLine(" ");
            Console.Write("Wie viele Hauptfächer gibt es?: ");
            var temp = Console.ReadLine();

            if (temp == "c" || temp == "C")
            {
                Program.English();
                return;
            }
            else if (temp == "a" || temp == "A")
            {
                Program.einreichnoten();
                return;
            }

            countH = Convert.ToInt32(temp);

            Console.Write("Welche Gewichtung haben die Hauptfachnoten? (Bsp. 2-fach: 2): ");
            gewicht = Convert.ToInt32(Console.ReadLine());

            Console.Write("Wie viele Nebenfächer gibt es?: ");
            count = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Cyan;

            for (int i = 0; i < countH; i++)
            {
                Console.Write("Gebe eine Hauptfachnote ein: ");
                Hauptfachnoten.Add(Console.ReadLine());
            }

            Console.ForegroundColor = ConsoleColor.DarkCyan;

            for (int i = 0; i < count; i++)
            {
                Console.Write("Gebe eine Nebenfachnote ein: ");
                Noten.Add(Console.ReadLine());
            }

            double total = Noten.Sum(x => Convert.ToDouble(x));

            double totalH = Hauptfachnoten.Sum(x => Convert.ToDouble(x));



            result = (((totalH * gewicht) + total) / (count + (countH * 2)));

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Der Durchschnitt beträgt " + Math.Round(result, 2));

            if (result >= 3)
            {
                Console.WriteLine("Nächstes Mal wird's besser!");
            }
            else
            {
                Console.WriteLine("Sehr gut, weiter so!");
            }

            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Drücken sie alles *außer* Enter um den Rechner neu zu starten. Um ihn zu beenden drücken sie Enter.");
        }

        static void English()
        {

            Console.Clear();

            // Code
            int count;

            int countHE;

            int gewicht;

            double result;

            List<string> Noten = new List<string>();

            List<string> Hauptfachnoten = new List<string>();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("*German* Grade Calculator by Rafael Wickberg // GLifeDE");

            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("How many main subjects are there?: ");
            countHE = Convert.ToInt32(Console.ReadLine());

            Console.Write("What's the weight of the main subject? (e.g. it counts 2 times: 2): ");
            gewicht = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many subsidiary subjects are there?: ");
            count = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Cyan;

            for (int i = 0; i < countHE; i++)
            {
                Console.Write("Enter a main subject grade: ");
                Hauptfachnoten.Add(Console.ReadLine());
            }

            Console.ForegroundColor = ConsoleColor.DarkCyan;

            for (int i = 0; i < count; i++)
            {
                Console.Write("Enter a subsidiary subject grade: ");
                Noten.Add(Console.ReadLine());
            }

            double total = Noten.Sum(x => Convert.ToDouble(x));

            double totalH = Hauptfachnoten.Sum(x => Convert.ToDouble(x));



            result = (((totalH * gewicht) + total) / (count + (countHE * 2)));

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("The average is " + Math.Round(result, 2));

            if (result >= 3)
            {
                Console.WriteLine("It will be better next time!");
            }
            else
            {
                Console.WriteLine("Very good, keep it up!");
            }

            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press everything *except* Enter to restart the calculator. To exit, press Enter.");
        }

        static void einreichnoten()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Wähle das zutreffende aus (1,2,3)");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("1. Mit mündlicher Prüfung (50% Einreichung, 25% Mündlich, 25% Schriftlich)");
            Console.WriteLine("2. Ohne mündlicher Prüfung (50% Einreichung, 50% Schriftlich)");
            Console.WriteLine("3. Selbst die Prozente bestimmen");

            var bestimmen = Console.ReadLine();

            if (bestimmen == "1")
            {
                Program.Müpr();
                return;
            }
            else if (bestimmen == "2")
            {
                Program.Ohmüpr();
                return;
            }
            else if (bestimmen == "3")
            {
                Program.Sebe();
                return;
            }
            else
            {
                System.Environment.Exit(1);
            }
        }

        static void Müpr()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write("Gebe deine Einreichungsnote ein: ");
            double einreichungsnote1 = Convert.ToDouble(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Red;

            Console.Write("Gebe die Note der mündlichen Prüfung ein: ");
            double müprnote = Convert.ToDouble(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.Write("Gebe die Note der schriftlichen Prüfung ein: ");
            double schrftlchnote1 = Convert.ToDouble(Console.ReadLine());

            double müpr = müprnote * 0.25 + schrftlchnote1 * 0.25 + einreichungsnote1 * 0.5;

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(" ");

            Console.WriteLine("Die Endnote beträgt " + müpr);
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Drücken sie alles *außer* Enter um den Rechner neu zu starten. Um ihn zu beenden drücken sie Enter.");
        }

        static void Ohmüpr()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write("Gebe deine Einreichungsnote ein: ");
            double einreichungsnote2 = Convert.ToDouble(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Red;

            Console.Write("Gebe die Note der schriftlichen Prüfung ein: ");
            double schrftlchnote2 = Convert.ToDouble(Console.ReadLine());

            double ohmüpr = einreichungsnote2 * 0.5 + schrftlchnote2 * 0.5;

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(" ");

            Console.WriteLine("Die Endnote beträgt " + ohmüpr);
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Drücken sie alles *außer* Enter um den Rechner neu zu starten. Um ihn zu beenden drücken sie Enter.");
        }

        static void Sebe()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write("Gebe deine Einreichungsnote ein: ");
            double einreichungsnote = Convert.ToDouble(Console.ReadLine());

            Console.Write("Wie viel Prozent zählt die Einreichungsnote? (z.b 25): ");
            double einreichungsnoteprozent = Convert.ToDouble(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Red;

            Console.Write("Gebe die Note deiner Prüfung ein: ");
            double prüfungsnote = Convert.ToDouble(Console.ReadLine());

            Console.Write("Wie viel Prozent zählt die Prüfungsnote? (z.b 25): ");
            double prüfungsnoteprozent = Convert.ToDouble(Console.ReadLine());

            double sebe = einreichungsnote * (einreichungsnoteprozent / 100) + prüfungsnote * (prüfungsnoteprozent / 100);

            Console.ForegroundColor = ConsoleColor.Green;


            Console.WriteLine(" ");

            Console.WriteLine("Die Endnote beträgt " + sebe);
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Drücken sie alles *außer* Enter um den Rechner neu zu starten. Um ihn zu beenden drücken sie Enter.");
        }
    }
}