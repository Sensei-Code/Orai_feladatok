using System;

namespace Alprogramok
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[5];


            int i = 0;
            int temp = 0;
            bool van; ;
            //Feltolt(tomb);
            //Kiir(tomb);


            int szam =3;

            Dupla(ref szam);

            Console.WriteLine(szam);


            /*while (i < tomb.Length)
            {
                van = false;
                temp = rnd.Next(10, 15);

                for (int j = 0; j < i; j++)
                {
                    if (tomb[j] == temp) van = true;
                }

                if (van==false)
                {
                    tomb[i] =temp;                    
                    Console.WriteLine(tomb[i]);
                    i++;
                }               
                
            }*/
        }


        static void Feltolt(int[] t)
        {
            Random rnd = new Random();
            for (int i = 0; i < t.Length; i++)
            {
                t[i] = rnd.Next(10, 99);
            }        
        }

        static void Kiir(int[] t)
        {
            for (int i = 0; i < t.Length; i++)
            {
                Console.WriteLine(t[i]);
            }
        
        }

        static void Dupla(ref int a)
        {
            a = a * 2;
        }
    }
}
