using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek19
{
    class Program
    {
        static void Main(string[] args)
        {
            //saçmaaaaaaaaaaaa

            int[] sayi = new int[10];
            int toplam = 0;
            int enBuyuk=sayi[1];
            double negToplam = 0;
            double pozToplam = 0;
            double negOrtalama = 0;
            double pozOrtalama = 0;
            for (int i = 1; i <sayi.Length; i++)
            {
                Console.WriteLine($"{i}.sayıyı gir:");
                sayi[i] = Convert.ToInt32(Console.ReadLine());
                toplam += sayi[i];
                if (enBuyuk < sayi[i])
                {
                    enBuyuk = sayi[i];
                }

                if (sayi[i]<0)
                {
                    negToplam += sayi[i];
                    negOrtalama = negToplam / i;
                }

                if (sayi[i] >0)
                {
                    pozToplam += sayi[i];
                    pozOrtalama = pozToplam / i;
                }
            }

            Console.WriteLine($"toplam {toplam}");
            Console.WriteLine($"en buyuk {enBuyuk}");
            Console.WriteLine($"negToplam {negToplam}");
            Console.WriteLine($"pozToplam {pozToplam}");
            Console.WriteLine($"negOrtalama {negOrtalama}");
            Console.WriteLine($"pozOrtalama {pozOrtalama}");


            Console.ReadKey();
        }
    }
}
