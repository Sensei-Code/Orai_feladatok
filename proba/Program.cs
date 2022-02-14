using System;
using System.Collections.Generic;

namespace oraimunka
{
    class Program
    {
        #region FUNKCIÓK
        static double Osszeadas(double a, double b)
        {
            return a + b;
        }

        static double Kivonas(double a, double b)
        {
            return a - b;
        }

        static double Szorzas(double a, double b)
        {
            return a * b;
        }

        static double Osztas(double a, double b)
        {
            if (a != 0)
            {
                return a / b;
            }
            else return 0;
        }
        #endregion

        static void Main(string[] args)
        {
            double a = 0;
            double b = 0;
            double eredmeny = 0;
            char op = ' ';

            List<string> history = new List<string>();

            while (true)
            {
                Console.WriteLine("A={0} {1} B={2}", a, op, b);
                Console.WriteLine("={0:0.00}\n", eredmeny);

                Console.WriteLine("1) Összeadás");
                Console.WriteLine("2) Kivonás");
                Console.WriteLine("3) Szorzás");
                Console.WriteLine("4) Osztás");
                Console.WriteLine("5) Számok bevitele");
                Console.WriteLine("6) Előzmények");
                Console.WriteLine("7) Kilépés");

                Console.Write("\nKérem válasszon egy menüpontot: ");
                string input = Console.ReadLine();



                switch (input)
                {
                    case "1":
                        eredmeny = Osszeadas(a, b);
                        op = '+';
                        if (a != 0 && b != 0)
                        {
                            history.Add(String.Format("{0} + {1} = {2}", a, b, a + b));
                        }
                        Console.Clear();
                        break;

                    case "2":
                        eredmeny = Kivonas(a, b);
                        op = '-';
                        if (a != 0 && b != 0)
                        {
                            history.Add(String.Format("{0} + {1} = {2}", a, b, a + b));
                        }
                        Console.Clear();
                        break;

                    case "3":
                        eredmeny = Szorzas(a, b);
                        op = '*';
                        if (a != 0 && b != 0)
                        {
                            history.Add(String.Format("{0} * {1} = {2}", a, b, a * b));
                        }
                        Console.Clear();
                        break;

                    case "4":
                        eredmeny = Osztas(a, b);
                        op = '/';
                        if (a != 0 && b != 0)
                        {
                            history.Add(String.Format("{0} / {1} = {2}", a, b, a / b));
                        }
                        Console.Clear();
                        break;

                    case "5":
                        Console.Clear();

                        Console.Write("Kérem az 'A' számot: ");
                        a = Convert.ToInt32(Console.ReadLine());


                        Console.Write("\nKérem az 'B' számot: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        break;

                    case "6":
                        int i = 1;
                        Console.Clear();
                        if (history.Count == 0)
                        {
                            Console.WriteLine("ÜRES");
                        }
                        foreach (var item in history)
                        {
                            Console.WriteLine($"{i}) {item}");
                            i++;
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case "7":
                        Environment.Exit(0);
                        break;

                    case "clear":
                        a = 0;
                        b = 0;
                        Console.Clear();
                        break;

                    default:
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
