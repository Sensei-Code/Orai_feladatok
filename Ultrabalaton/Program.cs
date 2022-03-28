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

        }
    }
}
