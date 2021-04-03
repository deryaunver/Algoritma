using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek52
{
    class Program
    {
        static void Main(string[] args)
        {
            // a b c d -->d c b a
            Console.Title = "Recursif";
            bool durum = true;
            while (durum)
            {
                Console.Write("Sayi gir:");
                int sayi = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(Faktoriyel(sayi));
                Console.Write("Çıkış yapmak istiyormusun?[E/H]");
                char cikis = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (cikis=='e'|| cikis=='E')
                {
                    durum = false;
                }
                else
                {
                    Console.WriteLine("devam ediyor..");
                }
            }
         
            Console.ReadLine();

        }

        //static int Faktoriyel(int sayi )
        //{
        //    int faktoriyel = 1;
        //    for (int i = 0; i < sayi; i++)
        //    {
        //        faktoriyel = faktoriyel * i;
        //    }

        //    return faktoriyel;
        //}

        static int Faktoriyel(int sayi)
        {
            if (sayi==0)
            {
                return 1;
            }
            else
            {
                return sayi * Faktoriyel(sayi - 1);
            }
        }
    }
}
