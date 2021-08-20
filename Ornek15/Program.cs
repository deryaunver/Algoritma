using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek15
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 37;
            int sayiTahmin = 0;
            Console.WriteLine("sayı tahmini yapınız: ");
            while (sayiTahmin != 37)
            {
          
                 sayiTahmin = int.Parse(Console.ReadLine());
                if (sayiTahmin == sayi)
                {
                    
                    Console.WriteLine($"Buldunuz: {sayi} ");
                }
                else if (sayiTahmin < sayi)
                {
                    Console.WriteLine("Daha büyük bir sayı girin!");
                }
                else if (sayiTahmin > sayi)
                {
                    Console.WriteLine("Daha küçük bir sayı girin!");
                }
            }
           

            Console.ReadKey();
        }
    }
}
