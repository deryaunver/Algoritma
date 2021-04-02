using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek49
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = " girilen sayının hangi sayının faktöriyeline eşit olduğunu bulma";
            Console.WriteLine("Sayı gir");
            int sayı = Convert.ToInt32(Console.ReadLine());
            bool durum = true;
            int sayac = 0;
            while (durum)
            {
                sayac = sayac + 1;
                sayı = sayı / sayac;
                if (sayı == 1)
                {
                    Console.WriteLine(sayac);
                    break;
                }
              
            }

            Console.ReadLine();


        }
    }
}
