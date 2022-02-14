using System;

namespace Alap4
{
    class Program
    {
        /*
         * Kérjünk be egy egész számot billentyűzetről majd soroljuk fel milyen 
         * számokkal osztható, és ha osztható egy számmal, akkor az hányszor van 
         * meg benne (átfogalmazva, hányféleképpen és hogyan írható fel két egész 
         * szám szorzataként).
         */

        static void Main(string[] args)
        {
            Console.Write("Kérek egy egész számot: ");
            int szam = int.Parse(Console.ReadLine());
            int db = 0;

            for (int i = 1; i <= szam; i++)
            {
                if (szam % i == 0) {
                    db = szam / i;
                    Console.WriteLine("A szám {0}-vel osztható. {2}={0}*{1}",i,db,szam);                
                }

            }
            
        }
    }
}
