using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek54
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Muhteşem sayı";
            // kendisi hariç bütün pozitif  çarpanları kendisine eşit olanlar

            Console.WriteLine("Sayı gir");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            for (int i = 1; i < sayi; i++)
            {
                if (sayi%i==0)
                {
                    toplam = toplam + i;  
                }

            }

            if (sayi==toplam)
            {
                Console.WriteLine("Mükemmel sayıdır");
            }
            else
            {
                Console.WriteLine("Mükemmel sayı değildir");
            }

            Console.ReadKey();

        }
    }
}
