using System;

namespace WhileCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n--- Mini-Taschenrechner ---");
                Console.WriteLine("\nErste Zahl (oder 'q' zum Beenden):");
                string input1 = Console.ReadLine();

                if (input1.ToLower() == "q")
                {
                    break;
                }

                Console.WriteLine("Zweite Zahl:");
                string input2 = Console.ReadLine();

                Console.WriteLine("Welche Rechenart? (+, -, *, /)");
                string operatorInput = Console.ReadLine();

                try
                {
                    int zahl1 = int.Parse(input1);
                    int zahl2 = int.Parse(input2);
                    double ergebnis = 0;

                    if (operatorInput == "+")
                        ergebnis = zahl1 + zahl2;
                    else if (operatorInput == "-")
                        ergebnis = zahl1 - zahl2;
                    else if (operatorInput == "*")
                        ergebnis = zahl1 * zahl2;
                    else if (operatorInput == "/")
                    {
                        if (zahl2 == 0)
                        {
                            Console.WriteLine("Division durch 0 ist nicht erlaubt.");
                            continue;
                        }
                        ergebnis = (double)zahl1 / zahl2;
                    }
                    else
                    {
                        Console.WriteLine("Ungültiger Operator.");
                        continue;
                    }

                    Console.WriteLine("Ergebnis: " + ergebnis);

                }
                catch (FormatException)
                {
                    Console.WriteLine("Bitte nur ganze Zahlen eingeben.");
                }
            }

            Console.WriteLine("Taschenrechner beendet");
        }
    }
}
