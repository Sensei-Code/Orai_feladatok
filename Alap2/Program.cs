using System;

namespace Alap2
{

    /*Készítsünk programot, amely segíti a burkoló mesterek munkáját. A szükséges csempe
     * mennyiségének a kiszámításához a program kérje be a terület szelességet, valamint
     * a magasságát méterben, majd számolja ki, hogy 20cm*20cm méretű csempék eseten hány
     * darabra van szükség a munka elvégzéséhez (a plusz 10%-ot az illesztések miatt illik
     * rászámolnunk).
     */
    class Program
    {
        static void Main(string[] args)
        {
            const double csempe_terulet = 0.2 * 0.2;

            Console.WriteLine("Kérem a terület szélességét(m): ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Kérem a terület magasságát(m): ");
            int b = int.Parse(Console.ReadLine());

            double terulet = a * b;

            double darab = (terulet / csempe_terulet)* 1.1;

            Console.WriteLine("{0} db csempe szükséges!",((int)darab));

            Console.ReadLine();


        }
    }
}
