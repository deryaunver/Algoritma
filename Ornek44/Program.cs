using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek44
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            bool durum = true;
            while (durum)
            {
                Console.WriteLine("Bir Sayı Girin :");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi % 2 != 0)
                {
                    toplam = toplam + sayi;
                }
                else if (sayi == 0)
                {
                    durum = false;
                }
                else
                {
                    toplam = toplam - sayi;
                }

                if (toplam >= 100)
                {
                    durum = false;
                }


            }
            Console.WriteLine("Toplam = " + toplam);

            Console.ReadKey();


        }
    }
}
