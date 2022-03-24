using System;
using System.IO;
using System.Collections.Generic;

namespace Helsinki1952
{
    class Eredmeny
    {
        public int helyezes;
        public int sportolok;
        public string sportag;
        public string versenyszam;    
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Eredmeny> eredmenyek = new List<Eredmeny>();
            string file = "helsinki.txt";
            string[] sor;            
            StreamReader sr = new StreamReader(file);
            
            while (sr.EndOfStream == false)
            {
                sor = sr.ReadLine().Split(' ');

                Eredmeny eredmeny = new Eredmeny();

                eredmeny.helyezes = int.Parse(sor[0]);
                eredmeny.sportolok = int.Parse(sor[1]);
                eredmeny.sportag = sor[2];
                eredmeny.versenyszam = sor[3];

                eredmenyek.Add(eredmeny);            
            }
            sr.Close();

            //3. Feladat
            Console.WriteLine("3. feladat:");
            Console.WriteLine("Pontszerző helyezések száma: {0}",eredmenyek.Count);

            //4. Feladat
            int arany = 0;
            int ezust = 0;
            int bronz = 0;
            foreach (var item in eredmenyek)
            {
                if (item.helyezes == 1) arany++;
                else if (item.helyezes == 2) ezust++;
                else if (item.helyezes == 3) bronz++;
            }

            Console.WriteLine("4. Feladat:");
            Console.WriteLine("Arany: {0}", arany);
            Console.WriteLine("Ezüst: {0}", ezust);
            Console.WriteLine("Bronz: {0}", bronz);
            Console.WriteLine("Összesen: {0}", arany+ezust+bronz);

            //5. Feladat
            int[] pontok = new int[6] {7, 5, 4, 3, 2, 1};
            int osszespont = 0;

            foreach (var item in eredmenyek)
            {
                osszespont += pontok[item.helyezes - 1];
            }

            Console.WriteLine("5. Feladat:");
            Console.WriteLine("Olimpiai pontok száma: {0}",osszespont);

            //6. Feladat
            int tornaermek = 0;
            int uszasermek = 0;
            foreach (var item in eredmenyek)
            {
                if (item.helyezes >= 3 && item.sportag == "úszás") uszasermek++;
                else if (item.helyezes >= 3 && item.sportag == "torna") tornaermek++;
            }

            if (uszasermek > tornaermek) 
                Console.WriteLine("Úszás sportágban szereztek több érmet");
            else if (tornaermek > uszasermek)
                Console.WriteLine("Torna sportágban szereztek több érmet");
            else
                Console.WriteLine("Egyenlő volt az érmek száma");

            //7. feladat



            Console.ReadLine();

        }
    }
}
