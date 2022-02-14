using System;

namespace Alap5
{
    class Program
    {

        /*
        Kérjünk be induláskor egy egész számot (’n’), majd ennyi darab (’n’) pozitív, páros
        számot. Amennyiben a kezelo nem ilyen számot ír be, azt hagyjuk figyelmen kívül. A
        végén adjuk meg a pozitív, páros számok közül a legnagyobbnak az értékét, és ezen
        számok összegét.         
         */
        static void Main(string[] args)
        {
            int osszeg = 0;
            int max = 0;
            int a = 0;
            int i = 0;

            Console.Write("Kérek egy egész számot: ");
            int db = int.Parse(Console.ReadLine());

            do
            {
                Console.Write("Kérem az {0}. számot: ",i+1);
                a = int.Parse(Console.ReadLine());

                if (a > 0 && a % 2 == 0) {
                    osszeg += a;
                    if (a > max) max = a;
                    i++;
                }

            } while (i<db);

            Console.WriteLine("A megadott számok összege: {0}",osszeg);
            Console.WriteLine("A számok közül a legynagyobb: {0}",max);
        }
    }
}
