using System;
using System.Collections.Generic;
using System.IO;

namespace Ultrabalaton
{
    class Versenyzo
    {
        public string nev;
        public int rajtszam;
        public string kategoria;
        public string ido;
        public int befejezes;
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Versenyzo> versenyzok = new List<Versenyzo>();
            string file = "ub2017egyeni.txt";
            string[] sor;
            StreamReader sr = new StreamReader(file);
            sr.ReadLine();
            while (sr.EndOfStream == false)
            {
                sor = sr.ReadLine().Split(';');
                Versenyzo v = new Versenyzo();
                v.nev = sor[0];
                v.rajtszam = int.Parse(sor[1]);
                v.kategoria = sor[2];
                v.ido = sor[3];
                v.befejezes = int.Parse(sor[4]);

                versenyzok.Add(v);
            }
            sr.Close();

            //3. feladat
            Console.WriteLine("3. feladat: Egyéni indulók: {0} fő",versenyzok.Count);

            //4. feladat
            int no_szamlalo = 0;
            foreach (var item in versenyzok)
            {
                if (item.kategoria == "Noi" && item.befejezes == 100)
                    no_szamlalo++;
            }

            Console.WriteLine("4. feladat: Célba érkező női sportolók: {0} fő",no_szamlalo);

            //5. feladat
            Console.Write("5. feladat: Kérem a sportoló nevét: ");
            string be_nev = Console.ReadLine();
            bool indul = false;
            bool befejezte = false;
            foreach (var item in versenyzok)
            {
                if (item.nev == be_nev)
                {
                    indul = true;
                    if (item.befejezes == 100)
                        befejezte = true;
                    break;
                }
            }
            Console.Write("\tIndult egyéniben a sportoló? ");
            if (indul == true)
                Console.WriteLine("Igen");
            else
                Console.WriteLine("Nem");
            
            Console.Write("\tTeljesítette a teljes távot? ");
            if (befejezte == true)
                Console.WriteLine("Igen");
            else
                Console.WriteLine("Nem");

            //7. feladat
            double osszes_ido = 0;
            int db = 0;
            foreach (var item in versenyzok)
            {
                if (item.kategoria == "Ferfi" && item.befejezes == 100)
                {
                    osszes_ido += IdoOraban(item.ido);
                    db++;                        
                }
            }
            Console.WriteLine(osszes_ido/db);

            //8. feladat
            Versenyzo ferfi_gyoztes = null;
            Versenyzo noi_gyoztes = null; ;

            //Megkeresi az első női és férfi versenyzőt
            foreach (var item in versenyzok)
            {
                if (item.kategoria == "Ferfi" && item.befejezes == 100)
                {
                    ferfi_gyoztes = item;
                    break;
                }
            }
            foreach (var item in versenyzok)
            {
                if (item.kategoria == "Noi" && item.befejezes == 100)
                {
                    noi_gyoztes = item;
                    break;
                }
            }
            
            //Elvégzi a vizsgálatot, hogy ki volt a leggyorsabb
            foreach (var item in versenyzok)
            {
                if (item.kategoria == "Ferfi" && item.befejezes == 100 && IdoOraban(item.ido) < IdoOraban(ferfi_gyoztes.ido))
                    ferfi_gyoztes = item;
                if (item.kategoria == "Noi" && item.befejezes == 100 && IdoOraban(item.ido) < IdoOraban(noi_gyoztes.ido))
                    noi_gyoztes = item;
            }

            Console.WriteLine("8. feladat: Verseny győztesei");
            Console.WriteLine("\tNők: {0} ({1}.) - {2}",noi_gyoztes.nev,noi_gyoztes.rajtszam,noi_gyoztes.ido);
            Console.WriteLine("\tFérfiak: {0} ({1}.) - {2}", ferfi_gyoztes.nev, ferfi_gyoztes.rajtszam, ferfi_gyoztes.ido);
        }

        //6. feladat
        public static double IdoOraban(string ido)
        {
            string[] sor = ido.Split(':');

            double ora = double.Parse(sor[0]);
            double perc = double.Parse(sor[1]);
            double mperc = double.Parse(sor[2]);

            return ora+(perc/60)+(mperc/3600);
        }
    }
}
