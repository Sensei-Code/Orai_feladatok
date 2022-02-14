using System;
using System.Collections.Generic;

namespace _01_Szamologep
{
    class Program
    {
        //FELADAT: A projektkönyvtárban található pdf állomány leírja
        static void Main(string[] args)
        {

            double a = 0;
            double b = 0;
            int menu = 0;
            string sor;
            List<string> elozmeny = new List<string>();

            do
            {
                Console.Clear();
                Console.WriteLine("A = {0}\tB = {1}\n",a,b);
                Console.WriteLine("1. Összeadás");
                Console.WriteLine("2. Kivonás");
                Console.WriteLine("3. Szorzás");
                Console.WriteLine("4. Osztás");
                Console.WriteLine("5. Számok bevitele");
                Console.WriteLine("6. Előzmények");
                Console.WriteLine("7. Kilépés\n");
                Console.Write("Kérem válasszon egy menüpontot: ");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    
                    case 1:
                        {
                            if (a == 0 || b == 0)
                            {
                                Console.WriteLine("Valamelyik szám nulla!");
                                Console.ReadLine();
                            }
                            else
                            {
                                sor = String.Format("A = {0}\tB = {1}\tA két szám összege {2}! ({0}+{1}={2})", a, b, a+b);
                                Console.WriteLine(sor);
                                elozmeny.Add(sor);
                                
                                Console.ReadLine();
                            }
                            break;
                        }

                    case 2:
                        {
                            if (a == 0 || b == 0)
                            {
                                Console.WriteLine("Valamelyik szám nulla!");
                                Console.ReadLine();
                            }
                            else
                            {
                                sor = String.Format("A = {0}\tB = {1}\tA két szám különbsége {2}! ({0}-{1}={2})", a, b, a - b);
                                elozmeny.Add(sor);
                                Console.WriteLine(sor);
                                Console.ReadLine();
                            }
                            break;
                        }

                    case 3:
                        {
                            if (a == 0 || b == 0)
                            {
                                Console.WriteLine("Valamelyik szám nulla!");
                                Console.ReadLine();
                            }
                            else
                            {
                                sor = String.Format("A = {0}\tB = {1}\tA két szám szorzata {2}! ({0}*{1}={2})", a, b, a * b);
                                Console.WriteLine(sor);
                                elozmeny.Add(sor);
                                Console.ReadLine();
                            }
                            break;
                        }

                    case 4:
                        {
                            if (a == 0 || b == 0)
                            {
                                Console.WriteLine("Valamelyik szám nulla!");
                                Console.ReadLine();
                            }
                            else
                            {
                                sor = String.Format("A = {0}\tB = {1}\tA két szám hányadosa {2}! ({0}/{1}={2})", a, b, a / b);
                                Console.WriteLine(sor);
                                elozmeny.Add(sor);
                                Console.ReadLine();
                            }
                            break;
                        }

                    case 5:
                        {
                            Console.Write("\n\nKérem az A számot: ");
                            a = double.Parse(Console.ReadLine());
                            Console.Write("Kérem az B számot: ");
                            b = double.Parse(Console.ReadLine());

                            break;
                        }
                    case 6:
                        {
                            Console.Clear();
                            foreach (var item in elozmeny)
                            {
                                Console.WriteLine(item);
                            }
                            Console.ReadLine();
                            break;
                        }

                    default:
                        Console.WriteLine("Hibás menüpont!");
                        break;
                }

            } while (menu!=7);


           
        }
    
    }
}
