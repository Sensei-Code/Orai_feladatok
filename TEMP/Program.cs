using System;
using System.Collections;
using System.IO;
using System.Collections.Generic;

namespace TEMP
{
    class Jatekos
    {
        public int Srsz;
        public int Mez;
        public string Nev;
        public string Poszt;
        public DateTime Szuletesi_datum;
        public double Magassag;
        public string Lab;
        public int Ertek;   
    }

    class Program
    {
        static void Main(string[] args)
        {

            List<Jatekos> Jatekosok = new List<Jatekos>();
            string file = "jatekosok2022.csv";
            StreamReader sr = new StreamReader(file);
            string sor;
            string[] darabolt;
            

            while (sr.EndOfStream == false)
            {
                sor = sr.ReadLine();
                Console.WriteLine(sor);
                darabolt = sor.Split(';');

                Jatekos temp = new Jatekos();
                temp.Srsz = int.Parse(darabolt[0]);
                temp.Mez = int.Parse(darabolt[1]);
                temp.Nev = darabolt[2];
                temp.Poszt = darabolt[3];
                temp.Szuletesi_datum = DateTime.Parse(darabolt[4]);
                temp.Magassag = Double.Parse(darabolt[5]);
                temp.Lab = darabolt[6];
                temp.Ertek = int.Parse(darabolt[7]);

                Jatekosok.Add(temp);
            
            }
            sr.Close();

            Jatekos legertekesebb = new Jatekos();
            legertekesebb = Jatekosok[0];
            foreach (Jatekos item in Jatekosok)
            {
                if (item.Ertek > legertekesebb.Ertek)
                    legertekesebb = item;
            }

            Console.WriteLine("A legértékesebb játékos: {0}",legertekesebb.Nev);
            Console.WriteLine("Értéke: {0}",legertekesebb.Ertek);


            Console.ReadLine();
        }

        


    }
}
