using System;

namespace _01_Szamologep
{
    class Program
    {
        //FELADAT: A projektkönyvtárban található pdf állomány leírja
        static void Main(string[] args)
        {
            double a = 2;
            double b = 3;
            int menu = 0;

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
                    case 1:{
                            if (a == 0 || b == 0)
                            {
                                Console.WriteLine("Még nem adtál meg számokat!");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("A = {0}\tB = {1}\tA két szám összege {2}! ({0}+{1}={2})", a, b, a + b);
                                Console.ReadLine();
                            }
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
