using System;

namespace Alap3
{

    /*
     * Készítsünk programot, amely dinnyék csomagolásához végez számításokat. A dinnyéket
     * szalaggal kell átkötni úgy, hogy kétszer körbe érje őket, es a masni készítéséhez
     * számolunk még 60 cm-t. A program kérje be a dinnye átmérőjét, és a dinnyék számát!
     * Számítsa ki, es írja a képernyőre, hogy n dinnye csomagolásához hány méter szalagra
     * van szükség. A megoldáshoz szükséged lehet a kör kerületének kiszámítására aminek
     * képlete: (d * π) (átmérő * 3,14).
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem adja megy, a dinnyék számát: ");
            int db = int.Parse(Console.ReadLine());

            Console.Write("Kérem adja meg a dinnyék átmérőjét (cm): ");
            int atmero = int.Parse(Console.ReadLine());

            double szalag = (atmero * Math.PI) * 2 + 60;

            Console.WriteLine("Egy dinnye csomagolásához {0} cm, szalag szükséges",Math.Round(szalag,1));
            Console.WriteLine("A {0} db dinnye csomagolásához összesen {1} cm szalag szükséges!",db,Math.Round(db*szalag,1));


        }
    }
}
