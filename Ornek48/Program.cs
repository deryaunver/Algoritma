using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek48
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Asal Sayi Kontrolü";

            Console.WriteLine("Bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());

            bool durum = true;
            for (int i = 2; i <=sayi-1; i++)
            {
                if (sayi%i==0)
                {
                    durum = false;
                }
            }

            if (durum==true)
            {
                Console.WriteLine("sayı asaldır");
            }
            else
            {
                Console.WriteLine("sayı asal değildir");
            }

            Console.ReadLine();
        }
    }
}
