using System;

namespace Orai_feladatok
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem az a számot: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Kérem az b számot: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Kérem az c számot: ");
            int c = int.Parse(Console.ReadLine());

            Console.Write("Kérem az d számot: ");
            int d = int.Parse(Console.ReadLine());

            double eredmeny = (((a + b) * c / 4) / (b * b)) * a + d;

            Console.WriteLine("Az művelet eredménye: {0}",eredmeny);
        }
    }
}
