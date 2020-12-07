using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "SAYI TAHMİN OYUNU  :)";
            Random random = new Random();
            int bilgisayarSayı = random.Next(1, 10);
            int can = 3;
            bool durum = true;
            while (durum)
            {
                string kalp = "";
                for (int i = 0; i < can; i++)
                {
                    kalp = kalp + "♥";
                }
                if (can == 0)
                {
                    Console.WriteLine($"malesef sayı: {bilgisayarSayı}");
                   break;
                }
                Console.WriteLine($" 1-10 arası sayı tahmini yapınız: hak: {kalp} ");
                int sayiTahmin = Convert.ToInt32(Console.ReadLine());
                if (bilgisayarSayı==sayiTahmin)
                {
                    Console.WriteLine($"Tebrikler buldunuz: {bilgisayarSayı}");
                    durum = false;
                }
                can--;
            
               
            }
            Console.ReadKey();
        }
    }
}
